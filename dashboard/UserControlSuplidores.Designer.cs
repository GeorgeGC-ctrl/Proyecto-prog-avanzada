namespace SistemaInventario.Presentacion
{
    partial class UserControlSuplidores
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
            textBox1 = new TextBox();
            panel2 = new Panel();
            SuplidoresDgv = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SuplidoresDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 91);
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
            iconButton3.Location = new Point(1091, 25);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(216, 54);
            iconButton3.TabIndex = 11;
            iconButton3.Text = "Nuevo Suplidor";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 25);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar suplidor";
            textBox1.Size = new Size(342, 31);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(SuplidoresDgv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1458, 879);
            panel2.TabIndex = 2;
            // 
            // SuplidoresDgv
            // 
            SuplidoresDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuplidoresDgv.Dock = DockStyle.Fill;
            SuplidoresDgv.Location = new Point(0, 0);
            SuplidoresDgv.Name = "SuplidoresDgv";
            SuplidoresDgv.RowHeadersWidth = 62;
            SuplidoresDgv.Size = new Size(1458, 879);
            SuplidoresDgv.TabIndex = 0;
            // 
            // UserControlSuplidores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlSuplidores";
            Size = new Size(1458, 970);
            Load += UserControlSuplidores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SuplidoresDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView SuplidoresDgv;
    }
}
