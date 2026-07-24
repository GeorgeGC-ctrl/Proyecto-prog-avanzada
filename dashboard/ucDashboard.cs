using FontAwesome.Sharp;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Northwind.Entidades.DTOs;
using Northwind.Entities.DTOs;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Suplidores;
using static Northwind.UI.DatagridViewStyle.DataGridViewStyleHelper;
using SkiaSharp;

namespace SistemaInventario.Presentacion
{
    public enum DashboardAction { Products, NewProduct, NewOrder, NewCategory, Trash }

    public partial class ucDashboard : UserControl
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISuppliersService _suppliersService;
        private readonly Action<DashboardAction> _navigate;
        private readonly TemaGrid _theme = TemaGrid.Claro();
        private readonly Label _productsValue = ValueLabel();
        private readonly Label _categoriesValue = ValueLabel();
        private readonly Label _suppliersValue = ValueLabel();
        private readonly Label _trashValue = ValueLabel();
        private readonly TableLayoutPanel _lowStockRows = RowsPanel();
        private readonly TableLayoutPanel _topValueRows = RowsPanel();
        private readonly TableLayoutPanel _categoryRows = RowsPanel();
        private readonly PieChart _categoryChart = new()
        {
            Dock = DockStyle.Fill,
            LegendPosition = LegendPosition.Hidden,
            InitialRotation = -90,
            BackColor = Color.Transparent
        };

        public ucDashboard(IProductService productService, ICategoryService categoryService,
            ISuppliersService suppliersService, Action<DashboardAction> navigate)
        {
            _productService = productService;
            _categoryService = categoryService;
            _suppliersService = suppliersService;
            _navigate = navigate;
            InitializeComponent();
            BuildLayout();
        }

        private async void ucDashboard_Load(object? sender, EventArgs e)
        {
            await CargarDatosDashboard();
        }

        private async Task CargarDatosDashboard()
        {
            try
            {
                var productsTask = _productService.GetAllProductsAsync();
                var categoriesTask = _categoryService.GetAllCategoriesAsync();
                var suppliersTask = _suppliersService.GetAllSuppliersAsync();
                await Task.WhenAll(productsTask, categoriesTask, suppliersTask);

                var products = (await productsTask).ToList();
                var categories = (await categoriesTask).ToList();
                var suppliers = (await suppliersTask).ToList();
                var activeProducts = products.Where(product => !product.Discontinued).ToList();

                _productsValue.Text = activeProducts.Count.ToString();
                _categoriesValue.Text = categories.Count.ToString();
                _suppliersValue.Text = suppliers.Count.ToString();
                _trashValue.Text = products.Count(product => product.Discontinued).ToString();

                LoadLowStock(activeProducts);
                LoadTopInventoryValue(activeProducts);
                LoadProductsByCategory(activeProducts, categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los datos del dashboard: {ex.Message}", "Dashboard",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildLayout()
        {
            AddMetric(_productsValue, "Total Productos", "Productos activos", IconChar.Cube, Color.FromArgb(37, 99, 235));
            AddMetric(_categoriesValue, "Categorías", "Categorías registradas", IconChar.Tag, Color.FromArgb(124, 58, 237));
            AddMetric(_suppliersValue, "Suplidores", "Suplidores registrados", IconChar.Truck, Color.FromArgb(16, 185, 129));
            AddMetric(_trashValue, "En papelera", "Productos descontinuados", IconChar.TrashAlt, Color.FromArgb(239, 68, 68));

            var left = Column();
            left.Controls.Add(CreateCard("Productos con mayor valor en inventario", "Precio unitario × existencia actual", "Ver productos →", DashboardAction.Products, _topValueRows, 230));
            left.Controls.Add(CreateCard("Alertas de stock bajo", "Productos en o por debajo de su nivel de reorden", "Ver productos →", DashboardAction.Products, _lowStockRows, 300));

            var right = Column();
            right.Controls.Add(CreateActivityCard());
            right.Controls.Add(CreateCategoryCard());
            right.Controls.Add(CreateQuickActionsCard());

            contentLayout.Controls.Add(left, 0, 0);
            contentLayout.Controls.Add(right, 1, 0);
        }

        private void AddMetric(Label value, string title, string subtitle, IconChar icon, Color accent)
        {
            var card = Card();
            card.Margin = new Padding(0, 0, 16, 0);
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20), ColumnCount = 1, RowCount = 4 };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            var picture = new IconPictureBox { IconChar = icon, IconColor = accent, IconFont = IconFont.Auto, IconSize = 20, Size = new Size(36, 36), BackColor = Color.FromArgb(248, 250, 252), SizeMode = PictureBoxSizeMode.CenterImage };
            layout.Controls.Add(picture, 0, 0);
            layout.Controls.Add(value, 0, 1);
            layout.Controls.Add(LabelFor(title, 9, FontStyle.Regular, _theme.TextoSecundario), 0, 2);
            layout.Controls.Add(LabelFor(subtitle, 8, FontStyle.Regular, Color.FromArgb(148, 163, 184)), 0, 3);
            card.Controls.Add(layout);
            metricsLayout.Controls.Add(card, metricsLayout.Controls.Count, 0);
        }

        private Panel CreateCard(string title, string subtitle, string? action, DashboardAction? navigation, Control contents, int height)
        {
            var card = Card();
            card.Dock = DockStyle.Top;
            card.Height = height;
            card.Margin = new Padding(0, 0, 18, 18);
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20, 18, 20, 14), ColumnCount = 1, RowCount = 2 };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            var header = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2 };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75));
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            header.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));
            header.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            header.Controls.Add(LabelFor(title, 10, FontStyle.Bold, _theme.TextoPrimario), 0, 0);
            header.Controls.Add(LabelFor(subtitle, 8, FontStyle.Regular, Color.FromArgb(148, 163, 184)), 0, 1);
            if (action is not null && navigation.HasValue)
            {
                var link = LabelFor(action, 8, FontStyle.Bold, Color.FromArgb(99, 80, 242));
                link.Dock = DockStyle.Fill; link.TextAlign = ContentAlignment.TopRight; link.Cursor = Cursors.Hand;
                link.Click += (_, _) => _navigate(navigation.Value);
                header.Controls.Add(link, 1, 0); header.SetRowSpan(link, 2);
            }
            contents.Dock = DockStyle.Fill;
            layout.Controls.Add(header, 0, 0);
            layout.Controls.Add(contents, 0, 1);
            card.Controls.Add(layout);
            return card;
        }

        private Panel CreateQuickActionsCard()
        {
            var card = Card(); card.Dock = DockStyle.Top; card.Height = 245; card.Margin = new Padding(0, 0, 0, 18);
            var outer = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20, 18, 20, 16), RowCount = 2 };
            outer.RowStyles.Add(new RowStyle(SizeType.Absolute, 32)); outer.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            outer.Controls.Add(LabelFor("Accesos rápidos", 10, FontStyle.Bold, _theme.TextoPrimario), 0, 0);
            var grid = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 2 };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); grid.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            grid.Controls.Add(QuickAction("Nuevo Producto", IconChar.Plus, DashboardAction.NewProduct), 0, 0);
            grid.Controls.Add(QuickAction("Nueva Orden", IconChar.Plus, DashboardAction.NewOrder), 1, 0);
            grid.Controls.Add(QuickAction("Nueva Categoría", IconChar.Tag, DashboardAction.NewCategory), 0, 1);
            grid.Controls.Add(QuickAction("Ver Papelera", IconChar.TrashAlt, DashboardAction.Trash), 1, 1);
            outer.Controls.Add(grid, 0, 1); card.Controls.Add(outer); return card;
        }

        private Panel CreateCategoryCard()
        {
            var content = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1 };
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57));
            content.Controls.Add(_categoryChart, 0, 0);
            content.Controls.Add(_categoryRows, 1, 0);
            return CreateCard("Productos por categoría", "Distribución sobre los productos activos", null, null, content, 235);
        }

        private Panel CreateActivityCard()
        {
            var content = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            content.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); content.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            var icon = new IconPictureBox { IconChar = IconChar.Clock, IconColor = Color.FromArgb(148, 163, 184), IconFont = IconFont.Auto, IconSize = 22, Dock = DockStyle.Bottom, SizeMode = PictureBoxSizeMode.CenterImage };
            var message = LabelFor("Actividad reciente próximamente", 9, FontStyle.Regular, _theme.TextoSecundario); message.Dock = DockStyle.Top; message.TextAlign = ContentAlignment.TopCenter;
            content.Controls.Add(icon, 0, 0); content.Controls.Add(message, 0, 1);
            return CreateCard("Actividad reciente", "Aún no hay auditoría configurada", null, null, content, 150);
        }

        private Panel QuickAction(string text, IconChar icon, DashboardAction action)
        {
            var button = new Panel { BackColor = Color.FromArgb(248, 250, 252), BorderStyle = BorderStyle.FixedSingle, Dock = DockStyle.Fill, Margin = new Padding(0, 0, 10, 10), Cursor = Cursors.Hand };
            var layout = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12), RowCount = 2 };
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34)); layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            layout.Controls.Add(new IconPictureBox { IconChar = icon, IconColor = Color.FromArgb(99, 80, 242), IconFont = IconFont.Auto, IconSize = 16, Size = new Size(28, 28), BackColor = Color.FromArgb(241, 237, 255), SizeMode = PictureBoxSizeMode.CenterImage }, 0, 0);
            layout.Controls.Add(LabelFor(text, 8.5F, FontStyle.Bold, _theme.TextoPrimario), 0, 1);
            button.Controls.Add(layout); button.Click += (_, _) => _navigate(action);
            foreach (Control control in layout.Controls) control.Click += (_, _) => _navigate(action);
            return button;
        }

        private void LoadLowStock(IEnumerable<ProductsDto> products)
        {
            var lowStock = products.Where(product => (product.UnitsInStock ?? 0) <= (product.ReorderLevel ?? 0)).OrderBy(product => product.UnitsInStock ?? 0).ToList();
            if (lowStock.Count == 0) { SetRows(_lowStockRows, new[] { EmptyMessage("No hay productos con stock bajo") }, 44); return; }
            var rows = new List<Control>();
            foreach (var product in lowStock)
            {
                var stock = product.UnitsInStock ?? 0; var reorder = product.ReorderLevel ?? 0;
                var critical = stock == 0 || stock <= reorder / 2;
                rows.Add(StockRow(product.ProductName, stock, reorder, critical));
            }
            SetRows(_lowStockRows, rows, 46);
        }

        private void LoadTopInventoryValue(IEnumerable<ProductsDto> products)
        {
            var values = products.OrderByDescending(product => (product.UnitPrice ?? 0) * (product.UnitsInStock ?? 0)).Take(5).ToList();
            if (values.Count == 0) { SetRows(_topValueRows, new[] { EmptyMessage("No hay productos activos") }, 40); return; }
            SetRows(_topValueRows, values.Select((product, index) => ValueRow(index + 1, product)), 36);
        }

        private void LoadProductsByCategory(IEnumerable<ProductsDto> products, IReadOnlyList<CategoryDto> categories)
        {
            var productList = products.ToList();
            if (categories.Count == 0)
            {
                _categoryChart.Series = Array.Empty<ISeries>();
                SetRows(_categoryRows, new[] { EmptyMessage("No hay categorías registradas") }, 40);
                return;
            }
            var palette = new[] { new SKColor(99, 80, 242), new SKColor(37, 99, 235), new SKColor(16, 185, 129), new SKColor(217, 119, 6), new SKColor(239, 68, 68) };
            _categoryChart.Series = categories.Select((category, index) =>
                (ISeries)new PieSeries<int>
                {
                    Values = new[] { productList.Count(product => product.CategoryID == category.Id) },
                    Fill = new SolidColorPaint(palette[index % palette.Length]),
                    Stroke = new SolidColorPaint(SKColors.White, 2),
                    DataLabelsSize = 0
                }).ToArray();
            SetRows(_categoryRows, categories.Select(category => CategoryRow(category.Nombre, productList.Count(product => product.CategoryID == category.Id), productList.Count)), 42);
        }

        private Control StockRow(string name, int stock, int reorder, bool critical)
        {
            var row = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 3, Margin = new Padding(0) };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 58));
            var color = critical ? Color.FromArgb(239, 68, 68) : Color.FromArgb(217, 119, 6);
            var badge = LabelFor(critical ? "Crítico" : "Bajo", 7.5F, FontStyle.Bold, color); badge.BackColor = Color.FromArgb(255, 247, 237); badge.Dock = DockStyle.Fill; badge.TextAlign = ContentAlignment.MiddleCenter;
            var text = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 }; text.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); text.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            text.Controls.Add(LabelFor(name, 8.5F, FontStyle.Bold, _theme.TextoPrimario), 0, 0); text.Controls.Add(LabelFor($"Existencia: {stock} · Nivel de reorden: {reorder}", 7.5F, FontStyle.Regular, Color.FromArgb(148, 163, 184)), 0, 1);
            var dot = new Panel { BackColor = color, Size = new Size(7, 7), Anchor = AnchorStyles.Left };
            row.Controls.Add(dot, 0, 0); row.Controls.Add(text, 1, 0); row.Controls.Add(badge, 2, 0); return row;
        }

        private Control ValueRow(int rank, ProductsDto product)
        {
            var total = (product.UnitPrice ?? 0) * (product.UnitsInStock ?? 0);
            var row = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4, Margin = new Padding(0) };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88));
            var number = LabelFor(rank.ToString(), 8, FontStyle.Bold, _theme.TextoSecundario); number.BackColor = Color.FromArgb(248, 250, 252); number.Dock = DockStyle.Fill; number.TextAlign = ContentAlignment.MiddleCenter;
            var units = LabelFor($"{product.UnitsInStock ?? 0} uds.", 7.5F, FontStyle.Regular, Color.FromArgb(148, 163, 184)); units.Dock = DockStyle.Fill; units.TextAlign = ContentAlignment.MiddleRight;
            var amount = LabelFor($"RD$ {total:N2}", 8, FontStyle.Bold, Color.FromArgb(99, 80, 242)); amount.Dock = DockStyle.Fill; amount.TextAlign = ContentAlignment.MiddleRight;
            row.Controls.Add(number, 0, 0); row.Controls.Add(LabelFor(product.ProductName, 8.5F, FontStyle.Bold, _theme.TextoPrimario), 1, 0); row.Controls.Add(units, 2, 0); row.Controls.Add(amount, 3, 0); return row;
        }

        private Control CategoryRow(string name, int count, int total)
        {
            var row = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, Margin = new Padding(0) };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); row.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28));
            var track = new Panel { BackColor = Color.FromArgb(226, 232, 240), Dock = DockStyle.Bottom, Height = 7, Margin = new Padding(0, 0, 0, 3) };
            var fill = new Panel { BackColor = Color.FromArgb(99, 80, 242), Dock = DockStyle.Left, Width = total == 0 ? 0 : (int)(track.Width * count / (float)total) };
            track.Controls.Add(fill); track.Resize += (_, _) => fill.Width = total == 0 ? 0 : (int)(track.Width * count / (float)total);
            var group = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 }; group.RowStyles.Add(new RowStyle(SizeType.Absolute, 20)); group.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); group.Controls.Add(LabelFor(name, 8, FontStyle.Regular, _theme.TextoPrimario), 0, 0); group.Controls.Add(track, 0, 1);
            row.Controls.Add(group, 0, 0); var countLabel = LabelFor(count.ToString(), 8, FontStyle.Bold, _theme.TextoPrimario); countLabel.Dock = DockStyle.Fill; countLabel.TextAlign = ContentAlignment.TopRight; row.Controls.Add(countLabel, 1, 0); return row;
        }

        private static Panel Card() => new() { BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle };
        private static TableLayoutPanel RowsPanel() => new() { ColumnCount = 1, Dock = DockStyle.Fill, AutoScroll = true, BackColor = Color.Transparent, GrowStyle = TableLayoutPanelGrowStyle.AddRows };
        private static void SetRows(TableLayoutPanel container, IEnumerable<Control> controls, int height)
        {
            container.SuspendLayout();
            container.Controls.Clear();
            container.RowStyles.Clear();
            container.RowCount = 0;
            foreach (var control in controls)
            {
                container.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
                container.Controls.Add(control, 0, container.RowCount++);
            }
            container.ResumeLayout();
        }
        private static Panel Column() => new() { Dock = DockStyle.Fill, Padding = new Padding(0), BackColor = Color.Transparent };
        private static Label ValueLabel() => LabelFor("0", 26, FontStyle.Bold, Color.FromArgb(15, 23, 42));
        private static Label EmptyMessage(string message) { var label = LabelFor(message, 9, FontStyle.Regular, Color.FromArgb(100, 116, 139)); label.Dock = DockStyle.Fill; label.TextAlign = ContentAlignment.MiddleCenter; return label; }
        private static Label LabelFor(string text, float size, FontStyle style, Color color) => new() { AutoSize = true, Text = text, Font = new Font("Segoe UI", size, style), ForeColor = color, BackColor = Color.Transparent };
    }
}
