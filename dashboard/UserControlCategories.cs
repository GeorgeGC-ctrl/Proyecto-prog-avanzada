using SistemaInventario.Entidades;
using SistemaInventario.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class UserControlCategories : UserControl
    {
       

        public UserControlCategories()
        {
            InitializeComponent();
            this.Load += Categories_Load;
            
        }

        private void Categories_Load(object sender, EventArgs e)
        {
           

            CatDgv.BorderStyle = BorderStyle.None;
            CatDgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CatDgv.GridColor = Color.FromArgb(226, 232, 240); // #E2E8F0
            CatDgv.BackgroundColor = Color.White;
            CatDgv.RowHeadersVisible = false;
            CatDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CatDgv.DefaultCellStyle.BackColor = Color.White;
            CatDgv.DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
            CatDgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            CatDgv.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            CatDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            CatDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
            CatDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
            CatDgv.ColumnHeadersHeight = 36;
            CatDgv.RowTemplate.Height = 44;
            CatDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 251, 252);
        }

        private void panelBoton_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelBoton_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelBoton_MouseLeave(object sender, EventArgs e)
        {

        }

        private void panelBoton_Click(object sender, EventArgs e)
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void CatDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Categorias categorias = ObtenerProductoDesdeFormulario();
               

                MessageBox.Show("¡Categoria guardada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private Categorias ObtenerProductoDesdeFormulario()
        {
            return new Categorias
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
            };

        }

        private void iconButton3_Click(object sender, EventArgs e)
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
        private int ObtenerIdSeleccionado()
        {
            if (CatDgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar una Categoria.");

            return Convert.ToInt32(
                CatDgv.SelectedRows[0].Cells["Id"].Value
            );
        }
        public void RefrescarProductos()
        {
            CatDgv.DataSource = null;
           
        }
    }

}


