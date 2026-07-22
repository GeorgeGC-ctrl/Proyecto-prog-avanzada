namespace SistemaInventario.Presentacion
{
    partial class UserControlProducts
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
            panel1 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            ProductosDgv = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 82);
            panel1.TabIndex = 1;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(37, 99, 235);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(1123, 18);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(216, 54);
            iconButton3.TabIndex = 5;
            iconButton3.Text = "Nuevo Producto";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(391, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 33);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 18);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar productos";
            textBox1.Size = new Size(304, 31);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(ProductosDgv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1376, 701);
            panel2.TabIndex = 2;
            // 
            // ProductosDgv
            // 
            ProductosDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDgv.Dock = DockStyle.Fill;
            ProductosDgv.Location = new Point(0, 0);
            ProductosDgv.Name = "ProductosDgv";
            ProductosDgv.RowHeadersWidth = 62;
            ProductosDgv.Size = new Size(1376, 701);
            ProductosDgv.TabIndex = 0;
            // 
            // UserControlProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlProducts";
            Size = new Size(1376, 783);
            Load += UserControlProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductosDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel2;
        private DataGridView ProductosDgv;
    }
}
