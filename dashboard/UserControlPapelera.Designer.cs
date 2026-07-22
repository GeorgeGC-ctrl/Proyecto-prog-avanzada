namespace SistemaInventario.Presentacion
{
    partial class UserControlPapelera
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
            panel3 = new Panel();
            dgvPapelera = new DataGridView();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            cboOpciones = new ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPapelera).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1381, 956);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvPapelera);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1381, 871);
            panel3.TabIndex = 1;
            // 
            // dgvPapelera
            // 
            dgvPapelera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPapelera.Dock = DockStyle.Fill;
            dgvPapelera.Location = new Point(0, 0);
            dgvPapelera.Name = "dgvPapelera";
            dgvPapelera.RowHeadersWidth = 62;
            dgvPapelera.Size = new Size(1381, 871);
            dgvPapelera.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(cboOpciones);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1381, 85);
            panel2.TabIndex = 0;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(239, 68, 68);
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            iconButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(915, 21);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(276, 54);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Eliminar Permanente";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(16, 185, 129);
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(684, 21);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(196, 54);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Restaurar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar en papelera";
            textBox1.Size = new Size(304, 31);
            textBox1.TabIndex = 1;
            // 
            // cboOpciones
            // 
            cboOpciones.FlatStyle = FlatStyle.Flat;
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Location = new Point(386, 33);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(204, 33);
            cboOpciones.TabIndex = 0;
            cboOpciones.SelectedIndexChanged += cboOpciones_SelectedIndexChanged;
            // 
            // UserControlPapelera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControlPapelera";
            Size = new Size(1381, 956);
            Load += UserControlPapelera_Load_1;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPapelera).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox cboOpciones;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel3;
        private DataGridView dgvPapelera;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
