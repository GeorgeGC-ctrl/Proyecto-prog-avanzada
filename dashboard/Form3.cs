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

        private void Form3_Load(object sender, EventArgs e)
        {
            ucAgregarSuplidor agregarSuplidor = new ucAgregarSuplidor();
            agregarSuplidor.Dock = DockStyle.Fill;
            panel1.Controls.Add(agregarSuplidor);

        }
    }
}
