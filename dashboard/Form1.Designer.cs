using FontAwesome.Sharp;

namespace dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Sidebar = new Panel();
            nav = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnPapelera = new IconButton();
            btnSuplidores = new IconButton();
            btnCategories = new IconButton();
            btnProduct = new IconButton();
            btnDashboard = new IconButton();
            logo = new Panel();
            LogoIcon = new IconPictureBox();
            System = new Label();
            panel2 = new Panel();
            conteinerPanel = new Panel();
            panelTopBar = new Panel();
            lbTituloPag = new Label();
            Sidebar.SuspendLayout();
            nav.SuspendLayout();
            logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoIcon).BeginInit();
            panel2.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(30, 41, 59);
            Sidebar.Controls.Add(nav);
            Sidebar.Controls.Add(logo);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(300, 903);
            Sidebar.TabIndex = 0;
            // 
            // nav
            // 
            nav.AutoScroll = true;
            nav.BackColor = Color.Transparent;
            nav.Controls.Add(label2);
            nav.Controls.Add(label1);
            nav.Controls.Add(btnPapelera);
            nav.Controls.Add(btnSuplidores);
            nav.Controls.Add(btnCategories);
            nav.Controls.Add(btnProduct);
            nav.Controls.Add(btnDashboard);
            nav.Dock = DockStyle.Fill;
            nav.Location = new Point(0, 64);
            nav.Name = "nav";
            nav.Padding = new Padding(10, 8, 10, 8);
            nav.Size = new Size(300, 839);
            nav.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(16, 194);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 7;
            label2.Text = "Gestion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 6;
            label1.Text = "Principal";
            // 
            // btnPapelera
            // 
            btnPapelera.FlatAppearance.BorderSize = 0;
            btnPapelera.FlatStyle = FlatStyle.Flat;
            btnPapelera.ForeColor = Color.Transparent;
            btnPapelera.IconChar = IconChar.Receipt;
            btnPapelera.IconColor = SystemColors.Highlight;
            btnPapelera.IconFont = IconFont.Auto;
            btnPapelera.ImageAlign = ContentAlignment.MiddleLeft;
            btnPapelera.Location = new Point(7, 342);
            btnPapelera.Name = "btnPapelera";
            btnPapelera.Padding = new Padding(10, 0, 20, 0);
            btnPapelera.Size = new Size(280, 60);
            btnPapelera.TabIndex = 5;
            btnPapelera.Text = "Ordenes";
            btnPapelera.TextAlign = ContentAlignment.MiddleLeft;
            btnPapelera.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPapelera.UseVisualStyleBackColor = true;
            btnPapelera.Click += btnPapelera_Click;
            btnPapelera.MouseEnter += btnPapelera_MouseEnter;
            // 
            // btnSuplidores
            // 
            btnSuplidores.FlatAppearance.BorderSize = 0;
            btnSuplidores.FlatStyle = FlatStyle.Flat;
            btnSuplidores.ForeColor = Color.Transparent;
            btnSuplidores.IconChar = IconChar.TruckField;
            btnSuplidores.IconColor = SystemColors.Highlight;
            btnSuplidores.IconFont = IconFont.Auto;
            btnSuplidores.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuplidores.Location = new Point(7, 282);
            btnSuplidores.Name = "btnSuplidores";
            btnSuplidores.Padding = new Padding(10, 0, 20, 0);
            btnSuplidores.Size = new Size(280, 60);
            btnSuplidores.TabIndex = 4;
            btnSuplidores.Text = "Suplidores";
            btnSuplidores.TextAlign = ContentAlignment.MiddleLeft;
            btnSuplidores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuplidores.UseVisualStyleBackColor = true;
            btnSuplidores.Click += btnSuplidores_Click;
            btnSuplidores.MouseEnter += btnSuplidores_MouseEnter;
            // 
            // btnCategories
            // 
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.Transparent;
            btnCategories.IconChar = IconChar.Tags;
            btnCategories.IconColor = SystemColors.Highlight;
            btnCategories.IconFont = IconFont.Auto;
            btnCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategories.Location = new Point(7, 222);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(10, 0, 20, 0);
            btnCategories.Size = new Size(280, 60);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categorias";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            btnCategories.MouseEnter += btnCategories_MouseEnter;
            // 
            // btnProduct
            // 
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = Color.Transparent;
            btnProduct.IconChar = IconChar.BoxesPacking;
            btnProduct.IconColor = SystemColors.Highlight;
            btnProduct.IconFont = IconFont.Solid;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(7, 102);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(10, 0, 20, 0);
            btnProduct.Size = new Size(280, 60);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Productos";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            btnProduct.MouseEnter += btnProduct_MouseEnter;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.IconChar = IconChar.ChartSimple;
            btnDashboard.IconColor = SystemColors.Highlight;
            btnDashboard.IconFont = IconFont.Solid;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(7, 36);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(280, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.MouseEnter += btnDashboard_MouseEnter;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Controls.Add(LogoIcon);
            logo.Controls.Add(System);
            logo.Dock = DockStyle.Top;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Padding = new Padding(16, 14, 16, 14);
            logo.Size = new Size(300, 64);
            logo.TabIndex = 0;
            // 
            // LogoIcon
            // 
            LogoIcon.BackColor = Color.Transparent;
            LogoIcon.Dock = DockStyle.Left;
            LogoIcon.ForeColor = SystemColors.ControlText;
            LogoIcon.IconChar = IconChar.BellConcierge;
            LogoIcon.IconColor = SystemColors.ControlText;
            LogoIcon.IconFont = IconFont.Auto;
            LogoIcon.Location = new Point(16, 14);
            LogoIcon.Name = "LogoIcon";
            LogoIcon.Size = new Size(32, 36);
            LogoIcon.TabIndex = 0;
            LogoIcon.TabStop = false;
            // 
            // System
            // 
            System.AutoSize = true;
            System.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            System.ForeColor = Color.FromArgb(241, 245, 249);
            System.Location = new Point(87, 26);
            System.Name = "System";
            System.Size = new Size(119, 30);
            System.TabIndex = 1;
            System.Text = "SystemInv";
            // 
            // panel2
            // 
            panel2.Controls.Add(conteinerPanel);
            panel2.Controls.Add(panelTopBar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 903);
            panel2.TabIndex = 1;
            // 
            // conteinerPanel
            // 
            conteinerPanel.AutoScroll = true;
            conteinerPanel.Dock = DockStyle.Fill;
            conteinerPanel.Location = new Point(0, 56);
            conteinerPanel.Name = "conteinerPanel";
            conteinerPanel.Size = new Size(974, 847);
            conteinerPanel.TabIndex = 1;
            conteinerPanel.Paint += conteinerPanel_Paint;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.White;
            panelTopBar.Controls.Add(lbTituloPag);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new Padding(20, 0, 20, 0);
            panelTopBar.Size = new Size(974, 56);
            panelTopBar.TabIndex = 0;
            panelTopBar.Paint += panelTopBar_Paint;
            // 
            // lbTituloPag
            // 
            lbTituloPag.AutoSize = true;
            lbTituloPag.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloPag.ForeColor = Color.FromArgb(15, 23, 42);
            lbTituloPag.Location = new Point(40, 14);
            lbTituloPag.Name = "lbTituloPag";
            lbTituloPag.Size = new Size(197, 30);
            lbTituloPag.TabIndex = 0;
            lbTituloPag.Text = "Sistema Inventario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1274, 903);
            Controls.Add(panel2);
            Controls.Add(Sidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1280, 720);
            Name = "Form1";
            Text = "System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Sidebar.ResumeLayout(false);
            nav.ResumeLayout(false);
            nav.PerformLayout();
            logo.ResumeLayout(false);
            logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoIcon).EndInit();
            panel2.ResumeLayout(false);
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private UserControlCategories categories1;
        private Panel Sidebar;
        private Panel panel2;
        private Panel logo;
        private Label System;
        private Panel panelTopBar;
        private Panel nav;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSuplidores;
        private FontAwesome.Sharp.IconButton btnCategories;
        private FontAwesome.Sharp.IconButton btnPapelera;
        private Label label1;
        private Label label2;
        private Label lbTituloPag;
        private FontAwesome.Sharp.IconPictureBox LogoIcon;
        private Panel conteinerPanel;
    }
}
