using SistemaInventario.LogicaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    public partial class Prueba : Form
    {
        private readonly ICategoryService _categoryService;

        public Prueba(ICategoryService categoryService)
        {
            InitializeComponent();
            this._categoryService = categoryService;
        }

        private async void Prueba_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=await _categoryService.GetAllCategoriesAsync();
        }
    }
}
