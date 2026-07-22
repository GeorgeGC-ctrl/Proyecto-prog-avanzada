using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Northwind.Entities.DTOs;
using Northwind.LogicaNegocios.Ordenes;
using Northwind.LogicaNegocios.Productos;
using SistemaInventario.Entidades;

namespace SistemaInventario.Presentacion
{
    public partial class ucAgregarOrden : UserControl
    {
        private IOrderService? _orderService;
        private IProductService? _productService;
        private int? _orderId;
        private BindingList<DetalleOrdenItem> _detalles = new();
        private readonly ErrorProvider _errorProvider = new();

        public ucAgregarOrden()
        {
            InitializeComponent();
        }

        private void ucAgregarOrden_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = _detalles;
            ConfigureDetailsGrid();

            cbProducto.SelectedIndexChanged += cbProducto_SelectedIndexChanged;
        }

        public void InitializeDependencies(IOrderService orderService, IProductService productService, int? orderId = null)
        {
            _orderService = orderService;
            _productService = productService;
            _orderId = orderId;

            // Cargar productos en combo
            _ = CargarProductosComboAsync();

            if (_orderId.HasValue)
            {
                lblTitulo.Text = $"Detalles de la Orden #{_orderId}";
                btnGuardar.Visible = false; // Solo visualización
                _ = CargarOrdenExistenteAsync(_orderId.Value);
            }
            else
            {
                lblTitulo.Text = "Nueva Orden de Venta";
                btnGuardar.Visible = true;
            }
        }

        private async Task CargarProductosComboAsync()
        {
            if (_productService != null)
            {
                try
                {
                    var productos = await _productService.GetAllProductsAsync();
                    cbProducto.DataSource = productos.ToList();
                    cbProducto.DisplayMember = "ProductName";
                    cbProducto.ValueMember = "ProductID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbProducto_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbProducto.SelectedItem is Products product)
            {
                txtPrecioUnidad.Text = product.UnitPrice.HasValue 
                    ? product.UnitPrice.Value.ToString("0.00") 
                    : "0.00";
            }
        }

        private async Task CargarOrdenExistenteAsync(int orderId)
        {
            if (_orderService != null)
            {
                try
                {
                    var order = await _orderService.GetOrderByIdAsync(orderId);
                    txtCliente.Text = order.CustomerID;
                    txtDireccion.Text = order.ShipAddress;
                    txtCiudad.Text = order.ShipCity;
                    txtPais.Text = order.ShipCountry;
                    if (order.OrderDate.HasValue)
                        dtpRequerida.Value = order.OrderDate.Value;

                    // Deshabilitar edición
                    txtCliente.ReadOnly = true;
                    txtDireccion.ReadOnly = true;
                    txtCiudad.ReadOnly = true;
                    txtPais.ReadOnly = true;
                    dtpRequerida.Enabled = false;
                    cbProducto.Enabled = false;
                    txtPrecioUnidad.ReadOnly = true;
                    txtCantidad.ReadOnly = true;
                    txtDescuento.ReadOnly = true;
                    btnAgregarDetalle.Enabled = false;
                    btnEliminarDetalle.Enabled = false;

                    // Cargar detalles
                    _detalles.Clear();
                    foreach (var det in order.Detalles)
                    {
                        _detalles.Add(new DetalleOrdenItem
                        {
                            ProductID = det.ProductID,
                            ProductName = det.ProductName,
                            UnitPrice = det.UnitPrice,
                            Quantity = det.Quantity,
                            Discount = det.Discount
                        });
                    }

                    ActualizarTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar orden existente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDetailsGrid()
        {
            if (dgvDetalles.Columns["ProductID"] != null)
                dgvDetalles.Columns["ProductID"].Visible = false;

            if (dgvDetalles.Columns["ProductName"] != null)
                dgvDetalles.Columns["ProductName"].HeaderText = "Producto";

            if (dgvDetalles.Columns["UnitPrice"] != null)
            {
                dgvDetalles.Columns["UnitPrice"].HeaderText = "Precio Unit.";
                dgvDetalles.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            }

            if (dgvDetalles.Columns["Quantity"] != null)
                dgvDetalles.Columns["Quantity"].HeaderText = "Cant.";

            if (dgvDetalles.Columns["Discount"] != null)
            {
                dgvDetalles.Columns["Discount"].HeaderText = "Desc.";
                dgvDetalles.Columns["Discount"].DefaultCellStyle.Format = "P0"; // Porcentaje
            }

            if (dgvDetalles.Columns["Subtotal"] != null)
            {
                dgvDetalles.Columns["Subtotal"].HeaderText = "Subtotal";
                dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            _errorProvider.SetError(cbProducto, "");
            _errorProvider.SetError(txtPrecioUnidad, "");
            _errorProvider.SetError(txtCantidad, "");
            _errorProvider.SetError(txtDescuento, "");

            bool hasErrors = false;

            if (cbProducto.SelectedValue == null)
            {
                _errorProvider.SetError(cbProducto, "Debe seleccionar un producto.");
                hasErrors = true;
            }

            if (!decimal.TryParse(txtPrecioUnidad.Text, out decimal price) || price < 0)
            {
                _errorProvider.SetError(txtPrecioUnidad, "Ingrese un precio válido.");
                hasErrors = true;
            }

            if (!short.TryParse(txtCantidad.Text, out short qty) || qty <= 0)
            {
                _errorProvider.SetError(txtCantidad, "La cantidad debe ser mayor a 0.");
                hasErrors = true;
            }

            if (!float.TryParse(txtDescuento.Text, out float discount) || discount < 0 || discount > 1)
            {
                _errorProvider.SetError(txtDescuento, "El descuento debe estar entre 0 y 1.");
                hasErrors = true;
            }

            if (hasErrors)
                return;

            int prodId = (int)cbProducto.SelectedValue;
            string prodName = cbProducto.Text;

            // Buscar si ya existe para acumular
            var existente = _detalles.FirstOrDefault(d => d.ProductID == prodId);
            if (existente != null)
            {
                existente.Quantity += qty;
                existente.UnitPrice = price;
                existente.Discount = discount;
                _detalles.ResetBindings();
            }
            else
            {
                _detalles.Add(new DetalleOrdenItem
                {
                    ProductID = prodId,
                    ProductName = prodName,
                    UnitPrice = price,
                    Quantity = qty,
                    Discount = discount
                });
            }

            ActualizarTotal();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.SelectedRows.Count > 0)
            {
                var item = (DetalleOrdenItem)dgvDetalles.SelectedRows[0].DataBoundItem;
                _detalles.Remove(item);
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Seleccione una línea de detalle de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarTotal()
        {
            decimal total = _detalles.Sum(d => d.Subtotal);
            lblTotal.Text = total.ToString("C2");
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _errorProvider.SetError(txtCliente, "");
            _errorProvider.SetError(txtDireccion, "");
            _errorProvider.SetError(txtCiudad, "");
            _errorProvider.SetError(txtPais, "");
            _errorProvider.SetError(dgvDetalles, "");

            bool hasErrors = false;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                _errorProvider.SetError(txtCliente, "El ID del cliente es obligatorio.");
                hasErrors = true;
            }

            if (_detalles.Count == 0)
            {
                _errorProvider.SetError(dgvDetalles, "Debe agregar al menos un producto a la orden.");
                hasErrors = true;
            }

            if (hasErrors)
                return;

            try
            {
                var dto = new CreateOrderDto
                {
                    CustomerID = txtCliente.Text.Trim(),
                    RequiredDate = dtpRequerida.Value,
                    ShipAddress = txtDireccion.Text.Trim(),
                    ShipCity = txtCiudad.Text.Trim(),
                    ShipCountry = txtPais.Text.Trim(),
                    Detalles = _detalles.Select(d => new CreateOrderDetailDto
                    {
                        ProductID = d.ProductID,
                        UnitPrice = d.UnitPrice,
                        Quantity = d.Quantity,
                        Discount = d.Discount
                    }).ToList()
                };

                if (_orderService != null)
                {
                    await _orderService.CreateOrderAsync(dto);
                    MessageBox.Show("¡Orden de venta creada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ParentForm?.Close();
                }
            }
            catch (FluentValidation.ValidationException valEx)
            {
                foreach (var error in valEx.Errors)
                {
                    if (error.PropertyName.Contains("CustomerID"))
                    {
                        _errorProvider.SetError(txtCliente, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("ShipAddress"))
                    {
                        _errorProvider.SetError(txtDireccion, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("ShipCity"))
                    {
                        _errorProvider.SetError(txtCiudad, error.ErrorMessage);
                    }
                    else if (error.PropertyName.Contains("ShipCountry"))
                    {
                        _errorProvider.SetError(txtPais, error.ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show(error.ErrorMessage, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }
    }

    // Helper item para el DataGridView
    public class DetalleOrdenItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal Subtotal => UnitPrice * Quantity * (1 - (decimal)Discount);
    }
}
