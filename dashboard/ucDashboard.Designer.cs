namespace SistemaInventario.Presentacion
{
    partial class ucDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dashboardLayout = new TableLayoutPanel();
            metricsLayout = new TableLayoutPanel();
            contentLayout = new TableLayoutPanel();
            SuspendLayout();

            dashboardLayout.AutoSize = true;
            dashboardLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashboardLayout.BackColor = Color.FromArgb(245, 247, 250);
            dashboardLayout.ColumnCount = 1;
            dashboardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            dashboardLayout.Controls.Add(metricsLayout, 0, 0);
            dashboardLayout.Controls.Add(contentLayout, 0, 1);
            dashboardLayout.Dock = DockStyle.Top;
            dashboardLayout.Padding = new Padding(28);
            dashboardLayout.RowCount = 2;
            dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 168F));
            dashboardLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 720F));

            metricsLayout.ColumnCount = 4;
            metricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            metricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            metricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            metricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            metricsLayout.Dock = DockStyle.Fill;
            metricsLayout.RowCount = 1;
            metricsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            contentLayout.ColumnCount = 2;
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            contentLayout.Dock = DockStyle.Fill;
            contentLayout.RowCount = 1;
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(dashboardLayout);
            Name = "ucDashboard";
            Size = new Size(1278, 944);
            Load += ucDashboard_Load;
            ResumeLayout(false);
        }

        private TableLayoutPanel dashboardLayout;
        private TableLayoutPanel metricsLayout;
        private TableLayoutPanel contentLayout;
    }
}
