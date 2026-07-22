using Microsoft.Data.SqlClient;
using Northwind.Entities.DTOs;
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
    public partial class ucAgregarSuplidor : UserControl
    {
        private ISuppliersService? _suppliersService;
        private int? _suplidorId;
        private readonly ErrorProvider _errorProvider = new();
        // Constructor sin parámetros — requerido por el Designer
        public ucAgregarSuplidor()
        {
            InitializeComponent();
        }
        // Llamado desde Form3_Load para inyectar dependencias
        public void InitializeDependencies(ISuppliersService suppliersService, int? suplidorId = null)
        {
            _suppliersService = suppliersService;
            _suplidorId = suplidorId;
            if (_suplidorId.HasValue)
                _ = CargarDatosParaEditar(_suplidorId.Value);
        }
        // ── Cargar datos (modo edición) ───────────────────────────
        private async Task CargarDatosParaEditar(int id)
        {
            try
            {
                var suplidor = await _suppliersService!.GetSupplierByIdAsync(id);
                txtEmpresa.Text = suplidor.CompanyName;
                txtContacto.Text = suplidor.ContactName;
                txtWeb.Text = suplidor.Address;
                textBox1.Text = suplidor.Country;
                textBox2.Text = suplidor.City;
                txtTelefono.Text = suplidor.Phone;
                txtCorreo.Text = suplidor.Fax;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ── Guardar (Crear o Actualizar) ──────────────────────────
        private async void iconButton3_Click(object sender, EventArgs e)
        {
            _errorProvider.SetError(txtEmpresa, "");
            _errorProvider.SetError(txtContacto, "");
            _errorProvider.SetError(txtWeb, "");
            _errorProvider.SetError(textBox1, "");
            _errorProvider.SetError(textBox2, "");
            _errorProvider.SetError(txtTelefono, "");
            _errorProvider.SetError(txtCorreo, "");

            bool hasErrors = false;

            if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                _errorProvider.SetError(txtEmpresa, "El nombre de la compañía es obligatorio.");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(txtContacto.Text))
            {
                _errorProvider.SetError(txtContacto, "El nombre del contacto no puede estar vacío.");
                hasErrors = true;
            }

            if (hasErrors)
                return;

            try
            {
                var dto = new CreateSuppliersDto
                {
                    CompanyName = txtEmpresa.Text.Trim(),
                    ContactName = txtContacto.Text.Trim(),
                    Address = txtWeb.Text.Trim(),
                    Country = textBox1.Text.Trim(),
                    City = textBox2.Text.Trim(),
                    Phone = txtTelefono.Text.Trim(),
                    Fax = txtCorreo.Text.Trim()
                };
                if (_suplidorId.HasValue)
                    await _suppliersService!.UpdateSupplierAsync(_suplidorId.Value, dto);
                else
                    await _suppliersService!.AddSupplierAsync(dto);
                MessageBox.Show("Suplidor guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Cerrar el Form contenedor
                ParentForm?.Close();
            }
            catch (FluentValidation.ValidationException valEx)
            {
                foreach (var error in valEx.Errors)
                {
                    if (error.PropertyName.Contains("CompanyName"))
                    {
                        _errorProvider.SetError(txtEmpresa, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("ContactName"))
                    {
                        _errorProvider.SetError(txtContacto, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("Address"))
                    {
                        _errorProvider.SetError(txtWeb, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("Country"))
                    {
                        _errorProvider.SetError(textBox1, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("City"))
                    {
                        _errorProvider.SetError(textBox2, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("Phone"))
                    {
                        _errorProvider.SetError(txtTelefono, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("Fax"))
                    {
                        _errorProvider.SetError(txtCorreo, error.ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show(error.ErrorMessage, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ── Cancelar ──────────────────────────────────────────────
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }
    }

}

