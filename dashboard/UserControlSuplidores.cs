using Northwind.LogicaNegocios.Suplidores;
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
using System.Windows.Media.Media3D;
using static Northwind.UI.DatagridViewStyle.DataGridViewStyleHelper;

namespace SistemaInventario.Presentacion
{
    public partial class UserControlSuplidores : UserControl

    {
        private readonly ISuppliersService _suppliersService;

        public UserControlSuplidores(ISuppliersService suppliersService)
        {
            InitializeComponent();
            _suppliersService = suppliersService;
        }

        private async void UserControlSuplidores_Load(object sender, EventArgs e)
        {
            EstiloGrid.AplicarA(SuplidoresDgv, TemaGrid.Claro());

            // 2. Creamos el gestor de acciones una sola vez
            var acciones = new GestorColumnaAcciones(SuplidoresDgv, TemaGrid.Claro());
            acciones.Editar += (rowIndex) => EjecutarEditar(rowIndex);
            acciones.Eliminar += (rowIndex) => EjecutarEliminar(rowIndex);

            await RefrescarSuplidores();
           
        }

        public void EjecutarEditar(int rowIndex)
        {
            try
            {
                int id = ObtenerIdSeleccionado();
                var form = new Form3(_suppliersService, id);
                form.ShowDialog();
                _ = RefrescarSuplidores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void EjecutarEliminar(int rowIndex)
        {
            try
            {
                int id = ObtenerIdSeleccionado();
                var respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este suplidor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    await _suppliersService.DeleteSupplierAsync(id);
                    MessageBox.Show("Suplidor eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefrescarSuplidores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task RefrescarSuplidores()
        {            
            try
            {
                var suplidores = await _suppliersService.GetAllSuppliersAsync();
                SuplidoresDgv.DataSource = suplidores.ToList();
                // Ocultar ID y renombrar columnas
                if (SuplidoresDgv.Columns["SupplierID"] != null)
                    SuplidoresDgv.Columns["SupplierID"].Visible = false;
                if (SuplidoresDgv.Columns["CompanyName"] != null)
                    SuplidoresDgv.Columns["CompanyName"].HeaderText = "Empresa";
                if (SuplidoresDgv.Columns["ContactName"] != null)
                    SuplidoresDgv.Columns["ContactName"].HeaderText = "Contacto";
                if (SuplidoresDgv.Columns["Address"] != null)
                    SuplidoresDgv.Columns["Address"].HeaderText = "Dirección";
                if (SuplidoresDgv.Columns["City"] != null)
                    SuplidoresDgv.Columns["City"].HeaderText = "Ciudad";
                if (SuplidoresDgv.Columns["Country"] != null)
                    SuplidoresDgv.Columns["Country"].HeaderText = "País";
                if (SuplidoresDgv.Columns["Phone"] != null)
                    SuplidoresDgv.Columns["Phone"].HeaderText = "Teléfono";
                if (SuplidoresDgv.Columns["Fax"] != null)
                    SuplidoresDgv.Columns["Fax"].HeaderText = "Fax";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar suplidores: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuplidoresDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int ObtenerIdSeleccionado()
        {
            if (SuplidoresDgv.SelectedRows.Count == 0)
                throw new Exception("Debe seleccionar un suplidor.");
            return Convert.ToInt32(
                SuplidoresDgv.SelectedRows[0].Cells["SupplierID"].Value
            );
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var form = new Form3(_suppliersService);
            form.ShowDialog();
            _ = RefrescarSuplidores();
        }

      
    }
}
