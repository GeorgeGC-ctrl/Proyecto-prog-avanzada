using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI.DatagridViewStyle
{
    public class DataGridViewStyleHelper
    {
        //    public static void AplicarEstiloModerno(
        //        DataGridView dgv,
        //        Action<DataGridViewRow> onEditar,
        //        Action<DataGridViewRow> onEliminar)
        //    {
        //        // 1. Configuración de bordes y grilla general
        //        dgv.EnableHeadersVisualStyles = false;
        //        dgv.BorderStyle = BorderStyle.None;
        //        dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        //        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        //        dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        //        dgv.GridColor = Color.FromArgb(226, 232, 240); // Color gris claro de las líneas (#E2E8F0)
        //        // 2. Estilo del Encabezado (Header)
        //        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252); // Fondo gris muy claro
        //        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);     // Texto oscuro/negrita
        //        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        //        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //        dgv.ColumnHeadersHeight = 40;
        //        // 3. Estilo de las Filas de datos
        //        dgv.DefaultCellStyle.BackColor = Color.White;
        //        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105); // Texto gris oscuro (#475569)
        //        dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        //        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249); // Fondo de selección suave
        //        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
        //        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //        dgv.RowTemplate.Height = 44; // Altura cómoda para ver los botones
        //        // Fila alternativa
        //        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
        //        // Ocultar la barra gris de la izquierda
        //        dgv.RowHeadersVisible = false;
        //        // Configuración de interacción
        //        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //        dgv.MultiSelect = false;
        //        dgv.AllowUserToAddRows = false;
        //        // 4. Crear la columna "Acciones" de forma dinámica si no existe
        //        if (!dgv.Columns.Cast<DataGridViewColumn>().Any(c => c.Name == "Acciones"))
        //        {
        //            var accionesCol = new DataGridViewImageColumn
        //            {
        //                Name = "Acciones",
        //                HeaderText = "Acciones",
        //                Width = 120,
        //                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        //            };
        //            dgv.Columns.Add(accionesCol);
        //        }
        //        // 5. Suscribir los eventos para dibujar los botones y detectar los clicks
        //        dgv.CellPainting -= Dgv_CellPainting;
        //        dgv.CellPainting += Dgv_CellPainting;
        //        // Desvincular eventos anteriores para no duplicar llamadas al refrescar
        //        dgv.CellMouseClick -= (s, e) => Dgv_CellMouseClick(s, e, onEditar, onEliminar);
        //        dgv.CellMouseClick += (s, e) => Dgv_CellMouseClick(s, e, onEditar, onEliminar);
        //    }
        //    // Pinta los dos botones (Editar y Eliminar) dentro de la misma celda de la columna Acciones
        //    private static void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //    {
        //        if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].Name == "Acciones")
        //        {
        //            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
        //            // Tamaño de los botones
        //            int buttonSize = 28;
        //            int spacing = 8;
        //            int totalWidth = (buttonSize * 2) + spacing;
        //            // Centrar los botones en la celda
        //            int startX = e.CellBounds.Left + (e.CellBounds.Width - totalWidth) / 2;
        //            int startY = e.CellBounds.Top + (e.CellBounds.Height - buttonSize) / 2;
        //            Rectangle rectEdit = new Rectangle(startX, startY, buttonSize, buttonSize);
        //            Rectangle rectDelete = new Rectangle(startX + buttonSize + spacing, startY, buttonSize, buttonSize);
        //            // --- DIBUJAR BOTÓN EDITAR ---
        //            // Fondo gris muy suave y borde gris claro
        //            using (var brushEdit = new SolidBrush(Color.FromArgb(248, 250, 252)))
        //            using (var penEdit = new Pen(Color.FromArgb(226, 232, 240)))
        //            {
        //                e.Graphics.FillRectangle(brushEdit, rectEdit);
        //                e.Graphics.DrawRectangle(penEdit, rectEdit);
        //            }
        //            // Ícono del lápiz (gris intermedio)
        //            var imgEdit = IconChar.Pen.ToBitmap(Color.FromArgb(148, 163, 184), 14);
        //            e.Graphics.DrawImage(imgEdit, rectEdit.Left + (rectEdit.Width - imgEdit.Width) / 2, rectEdit.Top + (rectEdit.Height - imgEdit.Height) / 2);
        //            // --- DIBUJAR BOTÓN ELIMINAR ---
        //            // Fondo rojo y borde rojo oscuro
        //            using (var brushDelete = new SolidBrush(Color.FromArgb(239, 68, 68)))
        //            {
        //                e.Graphics.FillRectangle(brushDelete, rectDelete);
        //            }
        //            // Ícono de basura (blanco)
        //            var imgDelete = IconChar.TrashAlt.ToBitmap(Color.White, 14);
        //            e.Graphics.DrawImage(imgDelete, rectDelete.Left + (rectDelete.Width - imgDelete.Width) / 2, rectDelete.Top + (rectDelete.Height - imgDelete.Height) / 2);
        //            e.Handled = true;
        //        }
        //    }
        //    // Detecta el click exacto sobre el botón Editar o el botón Eliminar
        //    private static void Dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e, Action<DataGridViewRow> onEditar, Action<DataGridViewRow> onEliminar)
        //    {
        //        var dgv = (DataGridView)sender;
        //        if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "Acciones")
        //        {
        //            var rect = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

        //            int localX = e.X; // Coordenadas del click relativas a la celda
        //            int localY = e.Y;
        //            int buttonSize = 28;
        //            int spacing = 8;
        //            int totalWidth = (buttonSize * 2) + spacing;
        //            int startX = (rect.Width - totalWidth) / 2;
        //            int startY = (rect.Height - buttonSize) / 2;
        //            Rectangle rectEdit = new Rectangle(startX, startY, buttonSize, buttonSize);
        //            Rectangle rectDelete = new Rectangle(startX + buttonSize + spacing, startY, buttonSize, buttonSize);
        //            if (rectEdit.Contains(localX, localY))
        //            {
        //                onEditar?.Invoke(dgv.Rows[e.RowIndex]);
        //            }
        //            else if (rectDelete.Contains(localX, localY))
        //            {
        //                onEliminar?.Invoke(dgv.Rows[e.RowIndex]);
        //            }
        //        }
        //    }
        //}
        public class TemaGrid
        {
            public Color FondoTarjeta { get; set; }
            public Color FondoEncabezado { get; set; }
            public Color FondoFila { get; set; }
            public Color FondoFilaAlterna { get; set; }
            public Color BordeFila { get; set; }
            public Color TextoPrimario { get; set; }
            public Color TextoSecundario { get; set; }
            public Color SeleccionFila { get; set; }
            public Color BotonEditarFondo { get; set; }
            public Color BotonEditarFondoHover { get; set; }
            public Color BotonEditarIcono { get; set; }
            public Color BotonEliminarFondo { get; set; }
            public Color BotonEliminarFondoHover { get; set; }
            public Color BotonEliminarIcono { get; set; } = Color.White;
            public string FuenteBase { get; set; } = "Segoe UI";
            public string FuenteEncabezado { get; set; } = "Segoe UI";
            public float TamanoFuente { get; set; } = 9.5f;
            public int AltoFila { get; set; } = 48;
            public int AltoEncabezado { get; set; } = 40;
            /// <summary>Tema moderno alineado exactamente a la imagen del mockup.</summary>
            public static TemaGrid Claro() => new TemaGrid
            {
                FondoTarjeta = Color.White,
                FondoEncabezado = Color.FromArgb(248, 250, 252),      // Gris azulado muy claro (#F8FAFC)
                FondoFila = Color.White,
                FondoFilaAlterna = Color.FromArgb(250, 251, 252),    // Fila alterna muy suave (#FAFBFC)
                BordeFila = Color.FromArgb(226, 232, 240),           // Bordes finos de grilla (#E2E8F0)
                TextoPrimario = Color.FromArgb(15, 23, 42),           // Texto oscuro (#0F172A)
                TextoSecundario = Color.FromArgb(71, 85, 105),       // Texto secundario gris slate (#475569)
                SeleccionFila = Color.FromArgb(241, 245, 249),         // Selección suave (#F1F5F9)

                BotonEditarFondo = Color.FromArgb(248, 250, 252),     // Fondo de botón editar claro (#F8FAFC)
                BotonEditarFondoHover = Color.FromArgb(241, 245, 249),
                BotonEditarIcono = Color.FromArgb(148, 163, 184),      // Lápiz gris/slate (#94A3B8)

                BotonEliminarFondo = Color.FromArgb(239, 68, 68),      // Rojo sólido (#EF4444)
                BotonEliminarFondoHover = Color.FromArgb(220, 38, 38),  // Rojo oscuro en hover (#DC2626)
                BotonEliminarIcono = Color.White                      // Bote de basura blanco
            };
            public static TemaGrid Oscuro() => new TemaGrid
            {
                FondoTarjeta = Color.FromArgb(24, 26, 32),
                FondoEncabezado = Color.FromArgb(30, 33, 40),
                FondoFila = Color.FromArgb(24, 26, 32),
                FondoFilaAlterna = Color.FromArgb(28, 30, 37),
                BordeFila = Color.FromArgb(42, 45, 54),
                TextoPrimario = Color.FromArgb(240, 241, 244),
                TextoSecundario = Color.FromArgb(160, 164, 174),
                SeleccionFila = Color.FromArgb(38, 41, 50),
                BotonEditarFondo = Color.FromArgb(44, 47, 57),
                BotonEditarFondoHover = Color.FromArgb(56, 60, 72),
                BotonEliminarFondo = Color.FromArgb(200, 60, 65),
                BotonEliminarFondoHover = Color.FromArgb(220, 80, 85),
                BotonEditarIcono = Color.FromArgb(200, 204, 214)
            };
        }
        /// <summary>
        /// Estiliza el DataGridView con bordes divisorios completos.
        /// </summary>
        public static class EstiloGrid
        {
            public static void AplicarA(DataGridView dgv, TemaGrid tema)
            {
                dgv.BackgroundColor = tema.FondoTarjeta;
                dgv.BorderStyle = BorderStyle.None;

                // Habilitar bordes de celda sencillos (verticales y horizontales)
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                dgv.GridColor = tema.BordeFila;

                dgv.EnableHeadersVisualStyles = false;
                dgv.RowHeadersVisible = false;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToResizeColumns = true;
                dgv.MultiSelect = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.RowTemplate.Height = tema.AltoFila;

                dgv.ColumnHeadersHeight = tema.AltoEncabezado;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Líneas divisorias en cabeceras

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.Font = new Font(tema.FuenteBase, tema.TamanoFuente);
                dgv.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = tema.FondoEncabezado,
                    ForeColor = tema.TextoPrimario,
                    Font = new Font(tema.FuenteEncabezado, tema.TamanoFuente, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    Padding = new Padding(12, 0, 0, 0),
                    SelectionBackColor = tema.FondoEncabezado,
                    SelectionForeColor = tema.TextoPrimario
                };
                dgv.DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = tema.FondoFila,
                    ForeColor = tema.TextoSecundario,
                    SelectionBackColor = tema.SeleccionFila,
                    SelectionForeColor = tema.TextoPrimario,
                    Padding = new Padding(12, 0, 0, 0),
                    Font = new Font(tema.FuenteBase, tema.TamanoFuente)
                };
                dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle(dgv.DefaultCellStyle)
                {
                    BackColor = tema.FondoFilaAlterna
                };
            }
        }
        /// <summary>
        /// Gestiona y pinta la columna de Acciones con los botones de Editar y Eliminar.
        /// </summary>
        public class GestorColumnaAcciones
        {
            private readonly DataGridView _grid;
            private readonly TemaGrid _tema;
            private readonly string _headerText;
            private readonly int _width;
            private const int TamBoton = 26;
            private const int Espacio = 8;
            private int _filaHoverEditar = -1;
            private int _filaHoverEliminar = -1;
            public event Action<int> Editar;      // RowIndex del registro
            public event Action<int> Eliminar;    // RowIndex del registro

            private int ColIndex => _grid.Columns["Acciones"]?.Index ?? -1;

            public GestorColumnaAcciones(DataGridView grid, TemaGrid tema = null, string headerText = "Acciones", int width = 110)
            {
                _grid = grid;
                _tema = tema ?? TemaGrid.Claro();
                _headerText = headerText;
                _width = width;

                // Desvincular eventos anteriores para no duplicar llamadas al refrescar
                _grid.DataError -= Grid_DataError;
                _grid.DataError += Grid_DataError;

                _grid.CellPainting -= Grid_CellPainting;
                _grid.CellPainting += Grid_CellPainting;

                _grid.CellMouseMove -= Grid_CellMouseMove;
                _grid.CellMouseMove += Grid_CellMouseMove;

                _grid.CellMouseLeave -= Grid_CellMouseLeave;
                _grid.CellMouseLeave += Grid_CellMouseLeave;

                _grid.CellMouseClick -= Grid_CellMouseClick;
                _grid.CellMouseClick += Grid_CellMouseClick;

                _grid.DataSourceChanged -= Grid_DataSourceChanged;
                _grid.DataSourceChanged += Grid_DataSourceChanged;

                // Configurar la columna de acciones inicialmente
                AsegurarColumnaAcciones();
            }

            private void Grid_DataError(object sender, DataGridViewDataErrorEventArgs e)
            {
                e.Cancel = true;
            }

            private void Grid_DataSourceChanged(object sender, EventArgs e)
            {
                AsegurarColumnaAcciones();
            }

            private void AsegurarColumnaAcciones()
            {
                var columna = _grid.Columns["Acciones"];
                if (columna == null)
                {
                    columna = new DataGridViewImageColumn
                    {
                        Name = "Acciones",
                        HeaderText = _headerText,
                        Width = _width,
                        ReadOnly = true,
                        SortMode = DataGridViewColumnSortMode.NotSortable,
                        Resizable = DataGridViewTriState.False
                    };
                    _grid.Columns.Add(columna);
                }

                // Ajustar estilo y alinear al centro
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                columna.HeaderCell.Style.Padding = new Padding(0);
                columna.DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Padding = new Padding(0),
                    NullValue = null   // evita FormatException cuando el valor de la celda es DBNull
                };

                // Asegurar que quede al final de la grilla
                if (_grid.Columns.Count > 0)
                {
                    columna.DisplayIndex = _grid.Columns.Count - 1;
                }
            }

            private (Rectangle editar, Rectangle eliminar) CalcularRects(Size tamCelda)
            {
                int totalAncho = TamBoton * 2 + Espacio;
                int x = (tamCelda.Width - totalAncho) / 2;
                int y = (tamCelda.Height - TamBoton) / 2;
                var rectEditar = new Rectangle(x, y, TamBoton, TamBoton);
                var rectEliminar = new Rectangle(x + TamBoton + Espacio, y, TamBoton, TamBoton);
                return (rectEditar, rectEliminar);
            }

            private void Grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
            {
                int colIndex = ColIndex;
                if (colIndex == -1 || e.ColumnIndex != colIndex || e.RowIndex < 0) return;

                // Pintar fondo y líneas de la grilla por defecto
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var (rEditarLocal, rEliminarLocal) = CalcularRects(e.CellBounds.Size);
                var rEditar = new Rectangle(e.CellBounds.X + rEditarLocal.X, e.CellBounds.Y + rEditarLocal.Y, rEditarLocal.Width, rEditarLocal.Height);
                var rEliminar = new Rectangle(e.CellBounds.X + rEliminarLocal.X, e.CellBounds.Y + rEliminarLocal.Y, rEliminarLocal.Width, rEliminarLocal.Height);
                bool hoverEditar = _filaHoverEditar == e.RowIndex;
                bool hoverEliminar = _filaHoverEliminar == e.RowIndex;

                // Dibujar botón Editar (con borde fino gris)
                DibujarBoton(g, rEditar,
                    hoverEditar ? _tema.BotonEditarFondoHover : _tema.BotonEditarFondo,
                    "\uE70F", _tema.BotonEditarIcono, true, _tema.BordeFila);

                // Dibujar botón Eliminar (sin borde, color sólido)
                DibujarBoton(g, rEliminar,
                    hoverEliminar ? _tema.BotonEliminarFondoHover : _tema.BotonEliminarFondo,
                    "\uE74D", _tema.BotonEliminarIcono, false, Color.Empty);

                e.Handled = true;
            }

            private static void DibujarBoton(Graphics g, Rectangle rect, Color fondo, string glifo, Color colorIcono, bool dibujarBorde, Color colorBorde)
            {
                using var path = RectanguloRedondeado(rect, 6);
                using var brocha = new SolidBrush(fondo);
                g.FillPath(brocha, path);
                if (dibujarBorde)
                {
                    using var lapiz = new Pen(colorBorde, 1);
                    g.DrawPath(lapiz, path);
                }
                using var fuente = new Font("Segoe MDL2 Assets", 10f);
                var flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(g, glifo, fuente, rect, colorIcono, flags);
            }

            private static GraphicsPath RectanguloRedondeado(Rectangle b, int radio)
            {
                var path = new GraphicsPath();
                int d = radio * 2;
                path.AddArc(b.X, b.Y, d, d, 180, 90);
                path.AddArc(b.Right - d, b.Y, d, d, 270, 90);
                path.AddArc(b.Right - d, b.Bottom - d, d, d, 0, 90);
                path.AddArc(b.X, b.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                return path;
            }

            private void Grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
            {
                int colIndex = ColIndex;
                if (colIndex == -1 || e.ColumnIndex != colIndex || e.RowIndex < 0) return;

                var (rEditar, rEliminar) = CalcularRects(new Size(_grid.Columns[colIndex].Width, _grid.Rows[e.RowIndex].Height));
                var punto = new Point(e.X, e.Y);
                int nuevoHoverEditar = rEditar.Contains(punto) ? e.RowIndex : -1;
                int nuevoHoverEliminar = rEliminar.Contains(punto) ? e.RowIndex : -1;
                _grid.Cursor = (nuevoHoverEditar != -1 || nuevoHoverEliminar != -1) ? Cursors.Hand : Cursors.Default;
                if (nuevoHoverEditar != _filaHoverEditar || nuevoHoverEliminar != _filaHoverEliminar)
                {
                    _filaHoverEditar = nuevoHoverEditar;
                    _filaHoverEliminar = nuevoHoverEliminar;
                    _grid.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }

            private void Grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
            {
                int colIndex = ColIndex;
                if (colIndex == -1 || e.ColumnIndex != colIndex) return;

                if (_filaHoverEditar == e.RowIndex || _filaHoverEliminar == e.RowIndex)
                {
                    _filaHoverEditar = -1;
                    _filaHoverEliminar = -1;
                    _grid.Cursor = Cursors.Default;
                    _grid.InvalidateCell(e.ColumnIndex, e.RowIndex);
                }
            }

            private void Grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
            {
                int colIndex = ColIndex;
                if (colIndex == -1 || e.ColumnIndex != colIndex || e.RowIndex < 0) return;

                var (rEditar, rEliminar) = CalcularRects(new Size(_grid.Columns[colIndex].Width, _grid.Rows[e.RowIndex].Height));
                var punto = new Point(e.X, e.Y);
                if (rEditar.Contains(punto)) Editar?.Invoke(e.RowIndex);
                else if (rEliminar.Contains(punto)) { _grid.Cursor = Cursors.Default; Eliminar?.Invoke(e.RowIndex); }
            }
        }
    }
}

