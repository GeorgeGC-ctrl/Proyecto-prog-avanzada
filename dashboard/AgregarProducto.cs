using Microsoft.Data.SqlClient;
using Northwind.Entities.DTOs;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;
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

namespace SistemaInventario.Presentacion
{
    public partial class AgregarProducto : UserControl
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ISuppliersService _suppliersService;
        private ProductsDto _productoDto;
        // 1. CONSTRUCTOR VACÍO (Requerido para que funcione el Diseñador Visual)
        public AgregarProducto()
        {
            InitializeComponent();
        }
        // 2. Método para inicializar dependencias tras la creación del control
        public async Task InitializeDependenciesAsync(IProductService productService, ICategoryService categoryService, ISuppliersService suppliersService, ProductsDto productoDto = null)
        {
            this._productService = productService;
            this._categoryService = categoryService;
            this._suppliersService = suppliersService;
            this._productoDto = productoDto;
            // Cargar combos y datos del producto
            await CargarCombos();
            if (_productoDto != null)
            {
                CargarProducto(_productoDto);
            }
        }
        private async void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Generamos el DTO de creación/actualización con los datos de los controles
                var itemDto = new CreateProductDto
                {
                    ProductName = txtNombre.Text.Trim(),
                    UnitPrice = decimal.TryParse(txtPrecio.Text, out var precio) ? precio : null,
                    UnitsInStock = short.TryParse(txtStock.Text, out var stock) ? stock : null,
                    UnitsOnOrder = short.TryParse(textBox2.Text, out var onOrder) ? onOrder : null,
                    ReorderLevel = short.TryParse(textBox1.Text, out var reorder) ? reorder : null,
                    Discontinued = checkBox1.Checked,
                    CategoryID = cbCategoria.SelectedValue != null ? (int?)cbCategoria.SelectedValue : null,
                    SupplierID = cbSuplidor.SelectedValue != null ? (int?)cbSuplidor.SelectedValue : null,
                    
                };
                if (_productoDto == null)
                {
                    // CREATE
                    await _productService.CreateProductAsync(itemDto);
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE
                    await _productService.UpdateProductAsync(_productoDto.ProductID, itemDto);
                    MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Cerrar el modal contenedor
                Form formContenedor = this.FindForm();
                if (formContenedor != null)
                {
                    formContenedor.DialogResult = DialogResult.OK;
                    formContenedor.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private async Task CargarCombos()
        {
            try
            {
                // 1. Cargar categorías (Usando 'Nombre' e 'Id')
                if (_categoryService != null)
                {
                    var categorias = await _categoryService.GetAllCategoriesAsync();
                    cbCategoria.DataSource = categorias.ToList();
                    cbCategoria.DisplayMember = "Nombre"; // Corregido
                    cbCategoria.ValueMember = "Id";       // Corregido
                }

                // 2. Cargar suplidores (Usando 'CompanyName' y 'SupplierID')
                if (_suppliersService != null)
                {
                    var suplidores = await _suppliersService.GetAllSuppliersAsync();
                    cbSuplidor.DataSource = suplidores.ToList();
                    cbSuplidor.DisplayMember = "CompanyName";
                    cbSuplidor.ValueMember = "SupplierID";
                }

                // 3. Si es modo edición, pre-seleccionar los correspondientes
                if (_productoDto != null)
                {
                    cbCategoria.SelectedValue = _productoDto.CategoryID;
                    cbSuplidor.SelectedValue = _productoDto.SupplierID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías o suplidores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarProducto(ProductsDto productoDto)
        {
            label1.Text = "Editar Producto";
            txtNombre.Text = productoDto.ProductName;
            txtPrecio.Text = productoDto.UnitPrice?.ToString() ?? "0";
            txtStock.Text = productoDto.UnitsInStock?.ToString() ?? "0";
            textBox2.Text = productoDto.UnitsOnOrder?.ToString() ?? "0";
            textBox1.Text = productoDto.ReorderLevel?.ToString() ?? "0";
            checkBox1.Checked = productoDto.Discontinued;
        }

        private async void AgregarProducto_Load(object sender, EventArgs e)
        {            
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form formContenedor = this.FindForm();
            if (formContenedor != null)
            {
                formContenedor.Close();
            }
        }
             
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
