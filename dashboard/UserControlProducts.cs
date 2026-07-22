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
using static Northwind.UI.DatagridViewStyle.DataGridViewStyleHelper;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlProducts : UserControl
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISuppliersService _suppliersService;
        public UserControlProducts(IProductService productService, ICategoryService categoryService, ISuppliersService suppliersService)
        {
            InitializeComponent();
            this._productService = productService;
            this._categoryService = categoryService;
            this._suppliersService = suppliersService;
        }

        private async void UserControlProducts_Load(object sender, EventArgs e)
        {
            await RefrescarProductos();

            
        }
        public async Task RefrescarProductos()
        {
            try
            {
                var datos = await _productService.GetAllProductsAsync();
                ProductosDgv.DataSource = null;
                ProductosDgv.DataSource = datos.ToList();
                // Ocultar columnas de ID
                if (ProductosDgv.Columns["SupplierID"] != null) ProductosDgv.Columns["SupplierID"].Visible = false;
                if (ProductosDgv.Columns["CategoryID"] != null) ProductosDgv.Columns["CategoryID"].Visible = false;
                // Renombrar columnas para la UI
                if (ProductosDgv.Columns["ProductName"] != null) ProductosDgv.Columns["ProductName"].HeaderText = "Producto";
                if (ProductosDgv.Columns["CategoriaNombre"] != null) ProductosDgv.Columns["CategoriaNombre"].HeaderText = "Categoría";
                if (ProductosDgv.Columns["SuplidorNombre"] != null) ProductosDgv.Columns["SuplidorNombre"].HeaderText = "Suplidor";
                if (ProductosDgv.Columns["UnitPrice"] != null) ProductosDgv.Columns["UnitPrice"].HeaderText = "Precio";
                if (ProductosDgv.Columns["UnitsInStock"] != null) ProductosDgv.Columns["UnitsInStock"].HeaderText = "En Stock";

                if (ProductosDgv.Columns["Discontinued"] != null)
                    ProductosDgv.Columns["Discontinued"].Visible = false;
                // Renombrar la nueva columna de texto
                if (ProductosDgv.Columns["Estado"] != null) ProductosDgv.Columns["Estado"].HeaderText = "Estado";

                EstiloGrid.AplicarA(ProductosDgv, TemaGrid.Claro());
                var acciones = new GestorColumnaAcciones(ProductosDgv, TemaGrid.Claro());

                acciones.Editar += (rowIndex) => EjecutarEditar(rowIndex);
                acciones.Eliminar += (rowIndex) => EjecutarEliminar(rowIndex);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void iconButton3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_productService, _categoryService, _suppliersService, null);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                await RefrescarProductos();
            }

        }
        
        public async void EjecutarEditar(int rowIndex)
        {
            try
            {
                if (ProductosDgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto de la lista para editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Recuperamos el DTO de la fila seleccionada
                var productoDto = (ProductsDto)ProductosDgv.SelectedRows[0].DataBoundItem;
                Form2 form2 = new Form2(_productService, _categoryService, _suppliersService, productoDto);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    await RefrescarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void EjecutarEliminar(int rowIndex)
        {
            try
            {
                if (ProductosDgv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var productoDto = (ProductsDto)ProductosDgv.SelectedRows[0].DataBoundItem;
                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de eliminar el producto '{productoDto.ProductName}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    await _productService.DeleteProductAsync(productoDto.ProductID);
                    MessageBox.Show(
                        "Producto eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await RefrescarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

       
    }
}

