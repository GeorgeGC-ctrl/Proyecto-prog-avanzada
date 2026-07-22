using Northwind.Entidades.DTOs;
using Northwind.LogicaNegocios.Categorias;
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

        public UserControlCategories(ICategoryService categoryService)
        {
            InitializeComponent();
            this._categoryService = categoryService;
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
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre de la categoría es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var errors = string.Join("\n", valEx.Errors.Select(err => err.ErrorMessage));
                MessageBox.Show(errors, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            if (CatDgv.SelectedRows.Count > 0)
            {
                var category = (CategoryDto)CatDgv.SelectedRows[0].DataBoundItem;

                _selectedCategoryId = category.Id;
                txtNombre.Text = category.Nombre;
                txtDescripcion.Text = category.Descripcion;
                iconButton5.Text = "Actualizar"; // Cambiar texto del botón de guardar
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

       

        // Lógica al presionar el lápiz (Editar)
        // Método que se ejecuta al presionar el lápiz (Editar)
        private void EjecutarEditar(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < CatDgv.Rows.Count)
            {
                // Obtenemos la categoría asociada a esa fila
                var category = (CategoryDto)CatDgv.Rows[rowIndex].DataBoundItem;
                _selectedCategoryId = category.Id;
                txtNombre.Text = category.Nombre;
                txtDescripcion.Text = category.Descripcion;
                iconButton5.Text = "Actualizar"; // Cambia el botón de guardar a Actualizar
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
