using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;
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
        // Constructor modificado
        public Form1(ICategoryService categoryService, IProductService productService, ISuppliersService suppliersService)
        {
            InitializeComponent();
            this._categoriaService = categoryService;
            this._productService = productService;
            this._suppliersService = suppliersService; // Guardar instancia
        }

        private async void Form1_Load1(object? sender, EventArgs e)
        {
            var userControl = new ucDashboard();
            userControl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gestionarCategortToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Cargar el ucDashboard al inicio
            var dashboard = new ucDashboard();
            dashboard.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(dashboard);
        }

        private void nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nav_MouseEnter(object sender, EventArgs e)
        {

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
            var userControl = new UserControlSuplidores();
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            conteinerPanel.Controls.Clear();
            var userControl = new ucDashboard();
            userControl.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(userControl);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            conteinerPanel.Controls.Clear();
            var userControl = new UserControlProducts(_productService, _categoriaService, _suppliersService);
            userControl.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(userControl);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            conteinerPanel.Controls.Clear();
            var Categorias = new UserControlCategories(_categoriaService);
            Categorias.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(Categorias);

        }

        private void conteinerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Evento de pintura — no crear controles aquí.
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            conteinerPanel.Controls.Clear();
            var userControl = new UserControlPapelera();
            userControl.Dock = DockStyle.Fill;
            conteinerPanel.Controls.Add(userControl);
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
