using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlOrdenes : UserControl
    {
        

        public UserControlOrdenes()
        {
            InitializeComponent();
            iconButton1.Click += iconButton1_Click;
            iconButton2.Click += iconButton2_Click;
        }

        private void UserControlPapelera_Load_1(object sender, EventArgs e)
        {
            cboOpciones.Items.Add("Suplidores");
            cboOpciones.Items.Add("Categorías");
            cboOpciones.Items.Add("Productos");
            cboOpciones.SelectedIndex = 0;

            EstilizarDgv();
        }

        private void EstilizarDgv()
        {
            dgvPapelera.BorderStyle = BorderStyle.None;
            dgvPapelera.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPapelera.GridColor = Color.FromArgb(226, 232, 240);
            dgvPapelera.BackgroundColor = Color.White;
            dgvPapelera.RowHeadersVisible = false;
            dgvPapelera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPapelera.DefaultCellStyle.BackColor = Color.White;
            dgvPapelera.DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            dgvPapelera.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvPapelera.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            dgvPapelera.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgvPapelera.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            dgvPapelera.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            dgvPapelera.ColumnHeadersHeight = 36;
            dgvPapelera.RowTemplate.Height = 44;
            dgvPapelera.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
        }

        private void RefrescarTabla()
        {
            cboOpciones_SelectedIndexChanged(cboOpciones, EventArgs.Empty);
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboOpciones.SelectedItem.ToString();

           
        }

        private int ObtenerIdSeleccionado()
        {
            if (dgvPapelera.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar un registro.");

            // La primera columna siempre es el Id en las 3 entidades
            return Convert.ToInt32(dgvPapelera.SelectedRows[0].Cells[0].Value);
        }

        // ── Restaurar ──────────────────────────────────────────────────
        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdSeleccionado();
                string opcion = cboOpciones.SelectedItem.ToString();

                var confirmacion = MessageBox.Show(
                    $"¿Desea restaurar este registro de {opcion}?",
                    "Confirmar restauración",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes) return;

               
                MessageBox.Show("Registro restaurado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefrescarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Eliminar permanente ────────────────────────────────────────
        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de eliminación permanente aún no implementada.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}