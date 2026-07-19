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
    public partial class Form2 : Form
    {
        private Productos _producto;
        public Form2()
        {
            InitializeComponent();
            _producto = new Productos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Dock = DockStyle.Fill;
            panelAgregar.Controls.Add(agregarProducto);

            if (_producto != null)
                agregarProducto.CargarProducto(_producto);
        }
    }
}
