using Microsoft.Data.SqlClient;
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
    public partial class AgregarProducto : UserControl
    {
        private readonly ProductosBL _productosBL;
        private readonly BL _bl;
        private readonly SuplidoresBL _suplidoresBL;


        public AgregarProducto()
        {
            InitializeComponent();
            _productosBL = new ProductosBL();
            _bl = new BL();
            _suplidoresBL = new SuplidoresBL();
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Productos producto = ObtenerProductoDesdeFormulario();

                if (_productoId.HasValue)
                {
                    producto.Id = _productoId.Value;
                    _productosBL.ActualizarProducto(producto);
                    MessageBox.Show("¡Producto actualizado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _productosBL.RegistrarProducto(producto);
                    MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private Productos ObtenerProductoDesdeFormulario()
        {

            return new Productos
            {
                Nombre = txtNombre.Text.Trim(),
                Precio = decimal.Parse(txtPrecio.Text),
                CategoriaId = (int)cbCategoria.SelectedValue,
                SuplidorId = (int)cbSuplidor.SelectedValue

            };

        }
        private void CargarCombos()
        {
            cbCategoria.DataSource = _bl.ComboCategorias();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";

            cbSuplidor.DataSource = _suplidoresBL.ComboSuplidores();
            cbSuplidor.DisplayMember = "Empresa";
            cbSuplidor.ValueMember = "Id";
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private int? _productoId = null; 

        public void CargarProducto(Productos producto)
        {
            _productoId = producto.Id;
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            cbCategoria.SelectedValue = producto.CategoriaId;
            cbSuplidor.SelectedValue = producto.SuplidorId;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
