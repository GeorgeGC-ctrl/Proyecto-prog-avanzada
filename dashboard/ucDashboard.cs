using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace SistemaInventario.Presentacion
{
    public partial class ucDashboard : UserControl
    {
         
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            panelDashboard.AutoScroll = true;
           
        }

       
        // ── Eventos vacíos del Designer ────────────────────────────────
        private void panelDashboard_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint_1(object sender, PaintEventArgs e) { }
        private void pieChart1_Load(object sender, EventArgs e) { }
        private void lblTotalEliminados_Click(object sender, EventArgs e) { }
    }
}