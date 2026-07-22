using Northwind.LogicaNegocios.Suplidores;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Constructor para agregar (sin ID)
        public Form3(ISuppliersService suppliersService) : this()
        {
            _suppliersService = suppliersService;
        }
        // Constructor para editar (con ID)
        public Form3(ISuppliersService suppliersService, int? suplidorId) : this()
        {
            _suppliersService = suppliersService;
            _suplidorId = suplidorId;
        }
        private ISuppliersService? _suppliersService;
        private int? _suplidorId;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = _suplidorId.HasValue ? "Editar Suplidor" : "Nuevo Suplidor";
            // Inicializar el UC y pasarle las dependencias
            ucAgregarSuplidor1.InitializeDependencies(_suppliersService!, _suplidorId);
        }
    }
}

