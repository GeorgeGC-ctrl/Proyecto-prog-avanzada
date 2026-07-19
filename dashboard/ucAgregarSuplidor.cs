using Microsoft.Data.SqlClient;
using SistemaInventario.Entidades;
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

namespace SistemaInventario.Presentacion
{
    public partial class ucAgregarSuplidor : UserControl
    {
        private readonly SuplidoresBL suplidoresBL = new SuplidoresBL();
        public ucAgregarSuplidor()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Suplidores suplidores = ObtenerProductoDesdeFormulario();
                suplidoresBL.RegistrarSuplidor(suplidores);
                MessageBox.Show("¡Suplidor guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
        
        private Suplidores ObtenerProductoDesdeFormulario()
        {
            return new Suplidores
            {
                Empresa = txtEmpresa.Text.Trim(),
                Contacto = txtContacto.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtCorreo.Text.Trim(),
                website= txtWeb.Text.Trim(),
                
            };

        }
    }
}
