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
            SuplidoresDgv = new DataGridView();
            panel1 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)SuplidoresDgv).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SuplidoresDgv
            // 
            SuplidoresDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SuplidoresDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SuplidoresDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SuplidoresDgv.Location = new Point(3, 85);
            SuplidoresDgv.Name = "SuplidoresDgv";
            SuplidoresDgv.RowHeadersWidth = 62;
            SuplidoresDgv.Size = new Size(1458, 970);
            SuplidoresDgv.TabIndex = 0;
            SuplidoresDgv.CellContentClick += SuplidoresDgv_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 91);
            panel1.TabIndex = 1;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.White;
            iconButton4.BackgroundImageLayout = ImageLayout.None;
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(516, 25);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(157, 54);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Actualizar";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
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
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(254, 242, 242);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(239, 68, 68);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(907, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 54);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(724, 25);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(157, 54);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "Editar";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1458, 970);
            panel2.TabIndex = 2;
            // 
            // UserControlSuplidores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControlSuplidores";
            Size = new Size(1458, 970);
            Load += UserControlSuplidores_Load;
            ((System.ComponentModel.ISupportInitialize)SuplidoresDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SuplidoresDgv;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}
