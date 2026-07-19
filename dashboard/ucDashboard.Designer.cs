namespace SistemaInventario.Presentacion
{
    partial class ucDashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            panelDashboard = new Panel();
            panelPaste = new Panel();
            panelChart = new Panel();
            panel3 = new Panel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalEliminados = new Label();
            label8 = new Label();
            panel2 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalSuplidores = new Label();
            label6 = new Label();
            panel5 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalCategorias = new Label();
            label4 = new Label();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblTotalProductos = new Label();
            label1 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panelDashboard.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(panelPaste);
            panelDashboard.Controls.Add(panelChart);
            panelDashboard.Controls.Add(panel3);
            panelDashboard.Controls.Add(panel2);
            panelDashboard.Controls.Add(panel5);
            panelDashboard.Controls.Add(panel1);
            panelDashboard.Controls.Add(pieChart1);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1278, 991);
            panelDashboard.TabIndex = 0;
            panelDashboard.Paint += panelDashboard_Paint;
            // 
            // panelPaste
            // 
            panelPaste.Location = new Point(688, 274);
            panelPaste.Name = "panelPaste";
            panelPaste.Size = new Size(551, 391);
            panelPaste.TabIndex = 5;
            panelPaste.Paint += panel4_Paint_1;
            // 
            // panelChart
            // 
            panelChart.Location = new Point(62, 258);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(567, 375);
            panelChart.TabIndex = 4;
            panelChart.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(iconPictureBox4);
            panel3.Controls.Add(lblTotalEliminados);
            panel3.Controls.Add(label8);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(955, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 150);
            panel3.TabIndex = 3;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.WhiteSmoke;
            iconPictureBox4.ForeColor = Color.FromArgb(239, 68, 68);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconPictureBox4.IconColor = Color.FromArgb(239, 68, 68);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 53;
            iconPictureBox4.Location = new Point(152, 3);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox4.Size = new Size(59, 53);
            iconPictureBox4.TabIndex = 2;
            iconPictureBox4.TabStop = false;
            // 
            // lblTotalEliminados
            // 
            lblTotalEliminados.AutoSize = true;
            lblTotalEliminados.Font = new Font("Segoe UI", 18F);
            lblTotalEliminados.ForeColor = Color.Black;
            lblTotalEliminados.Location = new Point(18, 48);
            lblTotalEliminados.Name = "lblTotalEliminados";
            lblTotalEliminados.Size = new Size(115, 48);
            lblTotalEliminados.TabIndex = 1;
            lblTotalEliminados.Text = "label7";
            lblTotalEliminados.Click += lblTotalEliminados_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(18, 105);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 0;
            label8.Text = "En papelera";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconPictureBox3);
            panel2.Controls.Add(lblTotalSuplidores);
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(650, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 150);
            panel2.TabIndex = 3;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = Color.FromArgb(16, 185, 129);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconPictureBox3.IconColor = Color.FromArgb(16, 185, 129);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 53;
            iconPictureBox3.Location = new Point(152, 3);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox3.Size = new Size(59, 53);
            iconPictureBox3.TabIndex = 2;
            iconPictureBox3.TabStop = false;
            // 
            // lblTotalSuplidores
            // 
            lblTotalSuplidores.AutoSize = true;
            lblTotalSuplidores.Font = new Font("Segoe UI", 18F);
            lblTotalSuplidores.ForeColor = Color.Black;
            lblTotalSuplidores.Location = new Point(18, 48);
            lblTotalSuplidores.Name = "lblTotalSuplidores";
            lblTotalSuplidores.Size = new Size(39, 48);
            lblTotalSuplidores.TabIndex = 1;
            lblTotalSuplidores.Text = "2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(18, 105);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 0;
            label6.Text = "Suplidores";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(iconPictureBox2);
            panel5.Controls.Add(lblTotalCategorias);
            panel5.Controls.Add(label4);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(347, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 150);
            panel5.TabIndex = 3;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.WhiteSmoke;
            iconPictureBox2.ForeColor = Color.FromArgb(139, 92, 246);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconPictureBox2.IconColor = Color.FromArgb(139, 92, 246);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 53;
            iconPictureBox2.Location = new Point(152, 3);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox2.Size = new Size(59, 53);
            iconPictureBox2.TabIndex = 2;
            iconPictureBox2.TabStop = false;
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Font = new Font("Segoe UI", 18F);
            lblTotalCategorias.ForeColor = Color.Black;
            lblTotalCategorias.Location = new Point(18, 48);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(39, 48);
            lblTotalCategorias.TabIndex = 1;
            lblTotalCategorias.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(18, 105);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 0;
            label4.Text = "Categorias";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(lblTotalProductos);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(58, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 150);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cube;
            iconPictureBox1.IconColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(152, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox1.Size = new Size(59, 53);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 18F);
            lblTotalProductos.ForeColor = Color.Black;
            lblTotalProductos.Location = new Point(18, 48);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(39, 48);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(18, 105);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Productos";
            // 
            // pieChart1
            // 
            pieChart1.AutoUpdateEnabled = true;
            pieChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            pieChart1.Legend = skDefaultLegend1;
            pieChart1.Location = new Point(1260, 742);
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(150, 150);
            pieChart1.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            pieChart1.Tooltip = skDefaultTooltip1;
            pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDashboard);
            Name = "ucDashboard";
            Size = new Size(1278, 991);
            Load += ucDashboard_Load;
            panelDashboard.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDashboard;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblTotalProductos;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label lblTotalEliminados;
        private Label label8;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label lblTotalSuplidores;
        private Label label6;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label lblTotalCategorias;
        private Label label4;
        private Panel panelChart;
        private Panel panelPaste;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}
