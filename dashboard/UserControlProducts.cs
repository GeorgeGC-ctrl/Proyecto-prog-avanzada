using SistemaInventario.Entidades;
using SistemaInventario.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlProducts : UserControl
    {
        
        public UserControlProducts()
        {
            InitializeComponent();

        }

        private void UserControlProducts_Load(object sender, EventArgs e)
        {
           

            ProductosDgv.BorderStyle = BorderStyle.None;
            ProductosDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductosDgv.GridColor = Color.FromArgb(226, 232, 240); // #E2E8F0
            ProductosDgv.BackgroundColor = Color.White;
            ProductosDgv.RowHeadersVisible = false;
            ProductosDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductosDgv.DefaultCellStyle.BackColor = Color.White;
            ProductosDgv.DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            ProductosDgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            ProductosDgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            ProductosDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            ProductosDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            ProductosDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            ProductosDgv.ColumnHeadersHeight = 36;
            ProductosDgv.RowTemplate.Height = 44;
            ProductosDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void iconButton3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ProductosDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefrescarProductos()
        {
            ProductosDgv.DataSource = null;
           
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            RefrescarProductos();
        }
        private int ObtenerIdSeleccionado()
        {
            if (ProductosDgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar un producto.");

            return Convert.ToInt32(
                ProductosDgv.SelectedRows[0].Cells["Id"].Value
            );
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductosDgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto para editar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var fila = ProductosDgv.SelectedRows[0];

                var producto = new Productos
                {
                    Id = Convert.ToInt32(fila.Cells["Id"].Value),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Precio = Convert.ToDecimal(fila.Cells["Precio"].Value),
                    CategoriaId = Convert.ToInt32(fila.Cells["CategoriaId"].Value),
                    SuplidorId = Convert.ToInt32(fila.Cells["SuplidorId"].Value)
                };

                Form2 form2 = new Form2();
                form2.ShowDialog();
                RefrescarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

