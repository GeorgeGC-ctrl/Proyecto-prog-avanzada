using Northwind.Entidades.DTOs;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.UI.DatagridViewStyle;
using SistemaInventario.Entidades;
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
using static Northwind.UI.DatagridViewStyle.DataGridViewStyleHelper;

namespace dashboard
{
    public partial class UserControlCategories : UserControl
    {        
        private int? _selectedCategoryId = null;
        private List<CategoryDto> _allCategories = new List<CategoryDto>();
        private readonly ICategoryService _categoryService;
        private readonly IProductService? _productService;
        private readonly ErrorProvider _errorProvider = new();

        public UserControlCategories(ICategoryService categoryService) : this(categoryService, null)
        {
        }

        public UserControlCategories(ICategoryService categoryService, IProductService? productService)
        {
            InitializeComponent();
            this._categoryService = categoryService;
            this._productService = productService;

            // Subscripción a los cambios de texto para actualizar dinámicamente la UI
            txtNombre.TextChanged += TxtNombre_TextChanged;
            txtDescripcion.TextChanged += TxtDescripcion_TextChanged;
        }
       
        private async void Categories_Load(object sender, EventArgs e)
        {
            // 1. Aplicamos el estilo al grid
            EstiloGrid.AplicarA(CatDgv, TemaGrid.Claro());
            // 2. Creamos el gestor de acciones (creará automáticamente la columna de botones)
            var acciones = new GestorColumnaAcciones(CatDgv, TemaGrid.Claro());
            // 3. Suscribimos los eventos de los botones a nuestros métodos
            acciones.Editar += (rowIndex) => EjecutarEditar(rowIndex);
            acciones.Eliminar += (rowIndex) => EjecutarEliminar(rowIndex);
            // 4. Cargamos los datos desde la base de datos (una sola vez)
            await RefrescarCategorias();

            // Configurar el formulario en modo "Nueva Categoría" al inicio
            LimpiarFormulario();
        }

        private async Task RefrescarCategorias()
        {
            if (_categoryService != null)
            {
                try
                {
                    var data = await _categoryService.GetAllCategoriesAsync();
                    _allCategories = data.ToList();

                    CatDgv.DataSource = null;
                    CatDgv.DataSource = _allCategories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            LimpiarFormulario();
        }

        private void CatDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                _errorProvider.Clear();

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    _errorProvider.SetError(txtNombre, "El nombre de la categoría es obligatorio.");
                    return;
                }
                var dto = new CreateCategoryDto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };
                if (_selectedCategoryId == null)
                {
                    // Guardar nuevo registro
                    await _categoryService.CreateCategoryAsync(dto);
                    MessageBox.Show("¡Categoría guardada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizar registro existente
                    await _categoryService.UpdateCategoryAsync(_selectedCategoryId.Value, dto);
                    MessageBox.Show("¡Categoría actualizada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarFormulario();
                await RefrescarCategorias();
            }
            catch (FluentValidation.ValidationException valEx)
            {
                foreach (var error in valEx.Errors)
                {
                    if (error.PropertyName.Contains("Nombre"))
                    {
                        _errorProvider.SetError(txtNombre, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("Descripcion"))
                    {
                        _errorProvider.SetError(txtDescripcion, error.ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show(error.ErrorMessage, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            if (CatDgv.SelectedRows.Count > 0)
            {
                try
                {
                    var category = (CategoryDto)CatDgv.SelectedRows[0].DataBoundItem;
                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de eliminar la categoría '{category.Nombre}'?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        await _categoryService.DeleteCategoryAsync(category.Id);
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        await RefrescarCategorias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila en la tabla para poder eliminarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            _selectedCategoryId = null;
            iconButton5.Text = "Guardar";
            _errorProvider.Clear();
            ActualizarTitulo();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (CatDgv.SelectedRows.Count > 0)
            {
                var category = (CategoryDto)CatDgv.SelectedRows[0].DataBoundItem;
                _selectedCategoryId = category.Id;
                txtNombre.Text = category.Nombre;
                txtDescripcion.Text = category.Descripcion;
                iconButton5.Text = "Actualizar"; 
                ActualizarTitulo();
                _ = ActualizarProductosAsociados(category.Id);
            }
            else
            {
                MessageBox.Show("Seleccione una fila en la tabla para poder editarla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query))
            {
                CatDgv.DataSource = _allCategories;
            }
            else
            {
                var filtered = _allCategories
                    .Where(c => c.Nombre.ToLower().Contains(query) ||
                                (c.Descripcion != null && c.Descripcion.ToLower().Contains(query)))
                    .ToList();
                CatDgv.DataSource = filtered;
            }
        }

        private void TxtNombre_TextChanged(object? sender, EventArgs e)
        {
            ActualizarTitulo();
        }

        private void TxtDescripcion_TextChanged(object? sender, EventArgs e)
        {
            lblCharCount.Text = $"{txtDescripcion.Text.Length}/200";
        }

        private void ActualizarTitulo()
        {
            if (_selectedCategoryId == null)
            {
                label1.Text = "Nueva categoría";
                panelProductosAsociados.Visible = false;
            }
            else
            {
                label1.Text = $"Editando: {txtNombre.Text}";
                panelProductosAsociados.Visible = true;
            }
        }

        private async Task ActualizarProductosAsociados(int categoryId)
        {
            if (_productService != null)
            {
                try
                {
                    var productos = await _productService.GetAllProductsAsync();
                    int count = productos.Count(p => p.CategoryID == categoryId);
                    lblProdAsocBadge.Text = $"{count} productos";
                }
                catch
                {
                    lblProdAsocBadge.Text = "0 productos";
                }
            }
            else
            {
                lblProdAsocBadge.Text = "0 productos";
            }
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        // Método que se ejecuta al presionar el lápiz (Editar)
        private void EjecutarEditar(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < CatDgv.Rows.Count)
            {
                var category = (CategoryDto)CatDgv.Rows[rowIndex].DataBoundItem;
                _selectedCategoryId = category.Id;
                txtNombre.Text = category.Nombre;
                txtDescripcion.Text = category.Descripcion;
                iconButton5.Text = "Actualizar"; 
                ActualizarTitulo();
                _ = ActualizarProductosAsociados(category.Id);
            }
        }

        // Método que se ejecuta al presionar la papelera (Eliminar)
        private async void EjecutarEliminar(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < CatDgv.Rows.Count)
            {
                try
                {
                    var category = (CategoryDto)CatDgv.Rows[rowIndex].DataBoundItem;
                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de eliminar la categoría '{category.Nombre}'?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        await _categoryService.DeleteCategoryAsync(category.Id);
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        await RefrescarCategorias();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
