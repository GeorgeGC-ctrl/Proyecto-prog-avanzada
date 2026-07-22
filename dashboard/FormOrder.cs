using System;
using System.Windows.Forms;
using Northwind.LogicaNegocios.Ordenes;
using Northwind.LogicaNegocios.Productos;

namespace SistemaInventario.Presentacion
{
    public partial class FormOrder : Form
    {
        private IOrderService? _orderService;
        private IProductService? _productService;
        private int? _orderId;

        // Constructor sin parámetros para el Diseñador de Visual Studio
        public FormOrder()
        {
            InitializeComponent();
        }

        public FormOrder(IOrderService orderService, IProductService productService, int? orderId = null) : this()
        {
            _orderService = orderService;
            _productService = productService;
            _orderId = orderId;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            this.Text = _orderId.HasValue ? $"Detalle de Orden #{_orderId}" : "Nueva Orden";

            // Inicializar el UserControl incrustado pasándole las dependencias
            ucAgregarOrden1.InitializeDependencies(_orderService!, _productService!, _orderId);
        }
    }
}
