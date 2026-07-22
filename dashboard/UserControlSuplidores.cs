using SistemaInventario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlSuplidores : UserControl

    {
       
        public UserControlSuplidores()
        {
            InitializeComponent();
            
        }

        private void UserControlSuplidores_Load(object sender, EventArgs e)
        {         
           
            SuplidoresDgv.BorderStyle = BorderStyle.None;
            SuplidoresDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SuplidoresDgv.GridColor = Color.FromArgb(226, 232, 240); // #E2E8F0
            SuplidoresDgv.BackgroundColor = Color.White;
            SuplidoresDgv.RowHeadersVisible = false;
            SuplidoresDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SuplidoresDgv.DefaultCellStyle.BackColor = Color.White;
            SuplidoresDgv.DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            SuplidoresDgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            SuplidoresDgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            SuplidoresDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            SuplidoresDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            SuplidoresDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            SuplidoresDgv.ColumnHeadersHeight = 36;
            SuplidoresDgv.RowTemplate.Height = 44;
            SuplidoresDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
        }

        private void SuplidoresDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ObtenerIdSeleccionado();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este Producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    
                    MessageBox.Show(
                        "Suplidor eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RefrescarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void RefrescarProductos()
        {
            SuplidoresDgv.DataSource = null;
            
        }
        private int ObtenerIdSeleccionado()
        {
            if (SuplidoresDgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar un suplidor.");

            return Convert.ToInt32(
                SuplidoresDgv.SelectedRows[0].Cells["Id"].Value
            );
        }

    }
}
