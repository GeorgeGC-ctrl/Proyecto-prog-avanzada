using Northwind.Entities.DTOs;
using Northwind.LogicaNegocios.Ordenes;
using Northwind.LogicaNegocios.Productos;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Northwind.UI.DatagridViewStyle.DataGridViewStyleHelper;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlGestionOrdenes : UserControl
    {
        private readonly IOrderService? _orderService;
        private readonly IProductService? _productService;
        private List<OrdersDto> _allOrders = new();

        public UserControlGestionOrdenes()
        {
            InitializeComponent();
        }

        public UserControlGestionOrdenes(IOrderService orderService, IProductService productService) : this()
        {
            _orderService = orderService;
            _productService = productService;
        }

        private async void UserControlGestionOrdenes_Load(object sender, EventArgs e)
        {
            EstiloGrid.AplicarA(OrdenesDgv, TemaGrid.Claro());
            
            var acciones = new GestorColumnaAcciones(OrdenesDgv, TemaGrid.Claro());
            
            acciones.Editar += (rowIndex) => EjecutarEditar(rowIndex);
            acciones.Eliminar += (rowIndex) => EjecutarEliminar(rowIndex);
            txtBuscar.TextChanged += TxtBuscar_TextChanged;

            await RefrescarOrdenes();
        }

        private async void EjecutarEliminar(int rowIndex)
        {

            try
            {
                int orderId = ObtenerIdSeleccionado();
                var confirmResult = MessageBox.Show(
                    $"¿Está seguro de eliminar la orden #{orderId}?\nEsto también eliminará todas sus líneas de detalle.",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    if (_orderService != null)
                    {
                        await _orderService.DeleteOrderAsync(orderId);
                        MessageBox.Show("Orden eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefrescarOrdenes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task RefrescarOrdenes()
        {
            if (_orderService != null)
            {
                try
                {
                    var data = await _orderService.GetAllOrdersAsync();
                    _allOrders = data.ToList();
                    OrdenesDgv.DataSource = null;
                    OrdenesDgv.DataSource = _allOrders;

                    ConfigureGridColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar órdenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureGridColumns()
        {
            if (OrdenesDgv.Columns["OrderID"] != null)
            {
                OrdenesDgv.Columns["OrderID"].HeaderText = "Nº Orden";
                OrdenesDgv.Columns["OrderID"].DisplayIndex = 0;
            }
            if (OrdenesDgv.Columns["CustomerID"] != null)
            {
                OrdenesDgv.Columns["CustomerID"].HeaderText = "Cliente";
                OrdenesDgv.Columns["CustomerID"].DisplayIndex = 1;
            }
            if (OrdenesDgv.Columns["OrderDate"] != null)
            {
                OrdenesDgv.Columns["OrderDate"].HeaderText = "Fecha";
                OrdenesDgv.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                OrdenesDgv.Columns["OrderDate"].DisplayIndex = 2;
            }
            if (OrdenesDgv.Columns["ShipName"] != null)
            {
                OrdenesDgv.Columns["ShipName"].HeaderText = "Destinatario";
                OrdenesDgv.Columns["ShipName"].DisplayIndex = 3;
            }
            if (OrdenesDgv.Columns["ShipCity"] != null)
            {
                OrdenesDgv.Columns["ShipCity"].HeaderText = "Ciudad";
                OrdenesDgv.Columns["ShipCity"].DisplayIndex = 4;
            }
            if (OrdenesDgv.Columns["ShipCountry"] != null)
            {
                OrdenesDgv.Columns["ShipCountry"].HeaderText = "País";
                OrdenesDgv.Columns["ShipCountry"].DisplayIndex = 5;
            }
            if (OrdenesDgv.Columns["Freight"] != null)
            {
                OrdenesDgv.Columns["Freight"].HeaderText = "Flete";
                OrdenesDgv.Columns["Freight"].DefaultCellStyle.Format = "N2";
                OrdenesDgv.Columns["Freight"].DisplayIndex = 6;
            }

            // Ocultar columnas internas/no deseadas
            string[] hideCols = { "EmployeeID", "RequiredDate", "ShippedDate", "ShipAddress" };
            foreach (var col in hideCols)
            {
                if (OrdenesDgv.Columns[col] != null)
                    OrdenesDgv.Columns[col].Visible = false;
            }
        }

        private void TxtBuscar_TextChanged(object? sender, EventArgs e)
        {
            string query = txtBuscar.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query))
            {
                OrdenesDgv.DataSource = _allOrders;
            }
            else
            {
                var filtered = _allOrders
                    .Where(o => (o.CustomerID != null && o.CustomerID.ToLower().Contains(query)) ||
                                (o.ShipName != null && o.ShipName.ToLower().Contains(query)) ||
                                (o.ShipCity != null && o.ShipCity.ToLower().Contains(query)) ||
                                o.OrderID.ToString().Contains(query))
                    .ToList();
                OrdenesDgv.DataSource = filtered;
            }
        }

        private async void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            if (_orderService != null && _productService != null)
            {
                using var form = new FormOrder(_orderService, _productService);
                form.ShowDialog();
                await RefrescarOrdenes();
            }
        }

        private async void btnEditarOrden_Click(object sender, EventArgs e)
        {
          
        }

        private async void EjecutarEditar(int rowIndez)
        {
            try
            {
                int orderId = ObtenerIdSeleccionado();
                if (_orderService != null && _productService != null)
                {
                    using var form = new FormOrder(_orderService, _productService, orderId);
                    form.ShowDialog();
                    await RefrescarOrdenes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void btnEliminarOrden_Click(object sender, EventArgs e)
        {
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await RefrescarOrdenes();
        }

        private int ObtenerIdSeleccionado()
        {
            if (OrdenesDgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar una orden de la lista.");

            return Convert.ToInt32(OrdenesDgv.SelectedRows[0].Cells["OrderID"].Value);
        }
    }
}
