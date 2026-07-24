using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;
using Northwind.LogicaNegocios.Ordenes;
using SistemaInventario.Presentacion;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace dashboard
{
    public partial class Form1 : Form
    {
        private bool isActive = false;
        private readonly ICategoryService _categoriaService;
        private readonly IProductService _productService;
        private readonly ISuppliersService _suppliersService; // Nuevo campo
        private readonly IOrderService _orderService;

        // Constructor modificado
        public Form1(ICategoryService categoryService, IProductService productService, ISuppliersService suppliersService, IOrderService orderService)
        {
            InitializeComponent();
            this._categoriaService = categoryService;
            this._productService = productService;
            this._suppliersService = suppliersService; // Guardar instancia
            this._orderService = orderService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDashboard();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.MouseEnter += (s, e) =>
            {
                if (!isActive) btnDashboard.BackColor = ColorTranslator.FromHtml("#334155");
            };
            btnDashboard.MouseLeave += (s, e) =>
            {
                if (!isActive) btnDashboard.BackColor = Color.Transparent;
            };

        }

        private void btnProduct_MouseEnter(object sender, EventArgs e)
        {
            btnProduct.MouseEnter += (s, e) =>
            {
                if (!isActive) btnProduct.BackColor = ColorTranslator.FromHtml("#334155");
            };
            btnProduct.MouseLeave += (s, e) =>
            {
                if (!isActive) btnProduct.BackColor = Color.Transparent;
            };
        }

        private void btnCategories_MouseEnter(object sender, EventArgs e)
        {
            btnCategories.MouseEnter += (s, e) =>
            {
                if (!isActive) btnCategories.BackColor = ColorTranslator.FromHtml("#334155");
            };
            btnCategories.MouseLeave += (s, e) =>
            {
                if (!isActive) btnCategories.BackColor = Color.Transparent;
            };
        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = false;
            var userControl = new UserControlSuplidores(_suppliersService);
            userControl.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(userControl);
        }

        private void btnSuplidores_MouseEnter(object sender, EventArgs e)
        {
            btnSuplidores.MouseEnter += (s, e) =>
            {
                if (!isActive) btnSuplidores.BackColor = ColorTranslator.FromHtml("#334155");
            };
            btnSuplidores.MouseLeave += (s, e) =>
            {
                if (!isActive) btnSuplidores.BackColor = Color.Transparent;
            };
        }

        private void btnPapelera_MouseEnter(object sender, EventArgs e)
        {
            btnPapelera.MouseEnter += (s, e) =>
            {
                if (!isActive) btnPapelera.BackColor = ColorTranslator.FromHtml("#334155");
            };
            btnPapelera.MouseLeave += (s, e) =>
            {
                if (!isActive) btnPapelera.BackColor = Color.Transparent;
            };
        }

        private void panelTopBar_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(ColorTranslator.FromHtml("#E2E8F0"), 0.5f);
            e.Graphics.DrawLine(pen, 0, panelTopBar.Height - 1, panelTopBar.Width, panelTopBar.Height - 1);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MostrarDashboard();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            MostrarCategorias();

        }

        private void conteinerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Evento de pintura — no crear controles aquí.
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            MostrarOrdenes();
        }

        private void MostrarDashboard()
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = true;
            var dashboard = new ucDashboard(_productService, _categoriaService, _suppliersService, NavegarDesdeDashboard)
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            conteinerPanel.Controls.Add(dashboard);
        }

        private void MostrarProductos()
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = false;
            var userControl = new UserControlProducts(_productService, _categoriaService, _suppliersService) { Dock = DockStyle.Fill };
            conteinerPanel.Controls.Add(userControl);
        }

        private void MostrarCategorias()
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = false;
            conteinerPanel.Controls.Add(new UserControlCategories(_categoriaService, _productService) { Dock = DockStyle.Fill });
        }

        private void MostrarOrdenes()
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = false;
            conteinerPanel.Controls.Add(new UserControlGestionOrdenes(_orderService, _productService) { Dock = DockStyle.Fill });
        }

        private void MostrarPapelera()
        {
            conteinerPanel.Controls.Clear();
            conteinerPanel.AutoScroll = false;
            conteinerPanel.Controls.Add(new UserControlPapelera { Dock = DockStyle.Fill });
        }

        private void NavegarDesdeDashboard(DashboardAction action)
        {
            switch (action)
            {
                case DashboardAction.Products:
                    MostrarProductos();
                    break;
                case DashboardAction.NewProduct:
                    MostrarProductos();
                    using (var form = new Form2(_productService, _categoriaService, _suppliersService)) form.ShowDialog(this);
                    break;
                case DashboardAction.NewOrder:
                    MostrarOrdenes();
                    using (var form = new FormOrder(_orderService, _productService)) form.ShowDialog(this);
                    break;
                case DashboardAction.NewCategory:
                    MostrarCategorias();
                    break;
                case DashboardAction.Trash:
                    MostrarPapelera();
                    break;
            }
        }

      
    }
}
