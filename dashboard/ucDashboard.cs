using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using SistemaInventario.LogicaNegocios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace SistemaInventario.Presentacion
{
    public partial class ucDashboard : UserControl
    {
        private readonly DashboardBLL dashboardBLL = new DashboardBLL();
        private readonly ProductosBL productosBL = new ProductosBL();

        // Controles LINQ agregados por código
        private DataGridView dgvLinq;
        private ComboBox cboConsulta;
        private Label lblTituloLinq;
        private Panel panelLinq;

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            panelDashboard.AutoScroll = true;
            CargarStats();
            InicializarPanelLinq();
            CargarGraficos();
            CargarConsultaLinq();
        }

        // ── Stats cards ────────────────────────────────────────────────
        public void CargarStats()
        {
            try
            {
                var stats = dashboardBLL.GetStats();
                lblTotalProductos.Text = stats.TotalProductos.ToString("N0");
                lblTotalCategorias.Text = stats.TotalCategorias.ToString("N0");
                lblTotalSuplidores.Text = stats.TotalSuplidores.ToString("N0");
                lblTotalEliminados.Text = stats.TotalEliminados.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar estadísticas: {ex.Message}");
            }
        }

        // ── Gráficos con datos reales ───────────────────────────────────
        private void CargarGraficos()
        {
            try
            {
                // --- CartesianChart: productos por categoría ---
                var porCategoria = productosBL.ProductosPorCategoria();

                var barChart = new CartesianChart { Dock = DockStyle.Fill, BackColor = Color.White };
                barChart.Series = new ISeries[]
                {
                    new ColumnSeries<int>
                    {
                        Values       = porCategoria.Select(x => x.Total).ToArray(),
                        Fill         = new SolidColorPaint(SKColor.Parse("#2563EB")),
                        Rx = 6, Ry  = 6,
                        MaxBarWidth  = 40,
                        Name         = "Productos"
                    }
                };
                barChart.XAxes = new Axis[]
                {
                    new Axis
                    {
                        Labels       = porCategoria.Select(x => x.Categoria).ToArray(),
                        LabelsPaint  = new SolidColorPaint(SKColor.Parse("#94A3B8")),
                        SeparatorsPaint = null,
                        TicksPaint   = null
                    }
                };
                barChart.YAxes = new Axis[]
                {
                    new Axis
                    {
                        LabelsPaint     = new SolidColorPaint(SKColor.Parse("#94A3B8")),
                        SeparatorsPaint = new SolidColorPaint(SKColor.Parse("#E2E8F0"))
                        {
                            StrokeThickness = 0.5f
                        }
                    }
                };
                panelChart.Controls.Clear();
                panelChart.Controls.Add(barChart);

                // --- PieChart: top 5 suplidores ---
                var top5 = productosBL.Top5Suplidores();
                var colores = new[] { "#2563EB", "#10B981", "#8B5CF6", "#F59E0B", "#EF4444" };

                var pieSeries = top5.Select((x, i) => new PieSeries<double>
                {
                    Values = new double[] { x.Total },
                    Name = x.Suplidor,
                    Fill = new SolidColorPaint(SKColor.Parse(colores[i % colores.Length])),
                    InnerRadius = 60
                }).ToArray<ISeries>();

                var pie = new PieChart { Dock = DockStyle.Fill, BackColor = Color.White };
                pie.Series = pieSeries;
                panelPaste.Controls.Clear();
                panelPaste.Controls.Add(pie);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar gráficos: {ex.Message}");
            }
        }

        // ── Panel LINQ ─────────────────────────────────────────────────
        private void InicializarPanelLinq()
        {
            // Panel contenedor — debajo de los gráficos
            panelLinq = new Panel
            {
                Location = new Point(58, 680),
                Size = new Size(1181, 280),
                BackColor = Color.White
            };

            lblTituloLinq = new Label
            {
                Text = "Consultas LINQ",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(12, 12),
                AutoSize = true
            };

            cboConsulta = new ComboBox
            {
                Location = new Point(12, 44),
                Size = new Size(380, 33),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9f),
                FlatStyle = FlatStyle.Popup
            };
            cboConsulta.Items.AddRange(new object[]
            {
                "1. Productos agrupados por categoría",
                "2. Top 5 suplidores con más productos",
                "3. Productos entre RD$100 y RD$500",
                "4. Búsqueda parcial (contiene 'a')",
                "5. Promedio de precios por categoría"
            });
            cboConsulta.SelectedIndexChanged += (s, e) => CargarConsultaLinq();

            dgvLinq = new DataGridView
            {
                Location = new Point(12, 88),
                Size = new Size(1157, 175),
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(226, 232, 240),
                BackgroundColor = Color.White,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false
            };
            dgvLinq.DefaultCellStyle.BackColor = Color.White;
            dgvLinq.DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvLinq.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvLinq.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgvLinq.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvLinq.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            dgvLinq.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            dgvLinq.ColumnHeadersHeight = 36;
            dgvLinq.RowTemplate.Height = 40;
            dgvLinq.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);

            panelLinq.Controls.Add(lblTituloLinq);
            panelLinq.Controls.Add(cboConsulta);
            panelLinq.Controls.Add(dgvLinq);
            panelDashboard.Controls.Add(panelLinq);

            cboConsulta.SelectedIndex = 0;
        }

        private void CargarConsultaLinq()
        {
            if (cboConsulta == null || dgvLinq == null) return;

            try
            {
                dgvLinq.DataSource = null;
                dgvLinq.Columns.Clear();

                switch (cboConsulta.SelectedIndex)
                {
                    case 0: // Productos por categoría
                        var q1 = productosBL.ProductosPorCategoria()
                            .Select(x => new { Categoría = x.Categoria, TotalProductos = x.Total })
                            .ToList();
                        dgvLinq.DataSource = q1;
                        break;

                    case 1: // Top 5 suplidores
                        var q2 = productosBL.Top5Suplidores()
                            .Select(x => new { Suplidor = x.Suplidor, TotalProductos = x.Total })
                            .ToList();
                        dgvLinq.DataSource = q2;
                        break;

                    case 2: // Rango de precios
                        var q3 = productosBL.ProductosPorRangoYCategoria(100, 500, "")
                            .Select(p => new { p.Nombre, Precio = p.Precio.ToString("C2"), Categoría = p.CategoriaNombre })
                            .ToList();
                        dgvLinq.DataSource = q3;
                        break;

                    case 3: // Búsqueda parcial
                        var q4 = productosBL.BuscarProductos("a")
                            .Select(p => new { p.Nombre, Precio = p.Precio.ToString("C2"), Categoría = p.CategoriaNombre })
                            .ToList();
                        dgvLinq.DataSource = q4;
                        break;

                    case 4: // Promedio por categoría
                        var q5 = productosBL.PromedioPrecioPorCategoria()
                            .Select(x => new { Categoría = x.Categoria, PromedioPrecio = x.Promedio.ToString("C2") })
                            .ToList();
                        dgvLinq.DataSource = q5;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar consulta: {ex.Message}");
            }
        }

        // ── Eventos vacíos del Designer ────────────────────────────────
        private void panelDashboard_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint_1(object sender, PaintEventArgs e) { }
        private void pieChart1_Load(object sender, EventArgs e) { }
        private void lblTotalEliminados_Click(object sender, EventArgs e) { }
    }
}