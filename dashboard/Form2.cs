using SistemaInventario.Entidades;
using Northwind.LogicaNegocios.Productos;
using Northwind.LogicaNegocios.Categorias;
using Northwind.LogicaNegocios.Suplidores;
using Northwind.Entities.DTOs;
using System;
using System.Windows.Forms;

namespace SistemaInventario.Presentacion
{
    public partial class Form2 : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ISuppliersService _suppliersService;
        private readonly ProductsDto _productoDto;

        public Form2(IProductService productService, ICategoryService categoryService, ISuppliersService suppliersService, ProductsDto productoDto = null)
        {
            InitializeComponent();
            _productService = productService;
            _categoryService = categoryService;
            _suppliersService = suppliersService;
            _productoDto = productoDto;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            // Llamamos al inicializador asíncrono sobre el control agregarProducto1 del Diseñador
            await agregarProducto1.InitializeDependenciesAsync(_productService, _categoryService, _suppliersService, _productoDto);
        }
    }
}