namespace dashboard
{
    partial class UserControlCategories
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
            CatDgv = new DataGridView();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnNuevaCategoria = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            panelProductosAsociados = new Panel();
            lblProdAsocTexto = new Label();
            lblProdAsocBadge = new Label();
            lblCharCount = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)CatDgv).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panelProductosAsociados.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CatDgv
            // 
            CatDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CatDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CatDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CatDgv.Location = new Point(0, 0);
            CatDgv.Name = "CatDgv";
            CatDgv.RowHeadersWidth = 62;
            CatDgv.Size = new Size(974, 369);
            CatDgv.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnNuevaCategoria);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1636, 76);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar categoria";
            textBox1.Size = new Size(339, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.FromArgb(99, 102, 241);
            btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            btnNuevaCategoria.FlatStyle = FlatStyle.Flat;
            btnNuevaCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNuevaCategoria.ForeColor = Color.White;
            btnNuevaCategoria.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnNuevaCategoria.IconColor = Color.White;
            btnNuevaCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaCategoria.IconSize = 20;
            btnNuevaCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaCategoria.Location = new Point(1385, 15);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(210, 46);
            btnNuevaCategoria.TabIndex = 1;
            btnNuevaCategoria.Text = "Nueva Categoría";
            btnNuevaCategoria.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevaCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(CatDgv);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(977, 861);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(1045, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 524);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(iconButton5);
            panel4.Controls.Add(iconButton4);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(550, 524);
            panel4.TabIndex = 1;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(139, 92, 246);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(323, 456);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(5, 0, 10, 0);
            iconButton5.Size = new Size(183, 52);
            iconButton5.TabIndex = 8;
            iconButton5.Text = "Guardar";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.Silver;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Popup;
            iconButton4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(125, 456);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(161, 52);
            iconButton4.TabIndex = 7;
            iconButton4.Text = "Cancelar";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panelProductosAsociados);
            panel6.Controls.Add(lblCharCount);
            panel6.Controls.Add(txtDescripcion);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtNombre);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(0, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(550, 357);
            panel6.TabIndex = 1;
            // 
            // panelProductosAsociados
            // 
            panelProductosAsociados.BackColor = Color.FromArgb(243, 244, 246);
            panelProductosAsociados.Controls.Add(lblProdAsocTexto);
            panelProductosAsociados.Controls.Add(lblProdAsocBadge);
            panelProductosAsociados.Location = new Point(24, 28);
            panelProductosAsociados.Name = "panelProductosAsociados";
            panelProductosAsociados.Size = new Size(503, 40);
            panelProductosAsociados.TabIndex = 10;
            // 
            // lblProdAsocTexto
            // 
            lblProdAsocTexto.AutoSize = true;
            lblProdAsocTexto.Font = new Font("Segoe UI Semibold", 8F);
            lblProdAsocTexto.ForeColor = SystemColors.ControlDarkDark;
            lblProdAsocTexto.Location = new Point(10, 10);
            lblProdAsocTexto.Name = "lblProdAsocTexto";
            lblProdAsocTexto.Size = new Size(161, 21);
            lblProdAsocTexto.TabIndex = 0;
            lblProdAsocTexto.Text = "Productos asociados";
            // 
            // lblProdAsocBadge
            // 
            lblProdAsocBadge.AutoSize = true;
            lblProdAsocBadge.BackColor = Color.FromArgb(238, 242, 255);
            lblProdAsocBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblProdAsocBadge.ForeColor = Color.FromArgb(99, 102, 241);
            lblProdAsocBadge.Location = new Point(350, 8);
            lblProdAsocBadge.Name = "lblProdAsocBadge";
            lblProdAsocBadge.Size = new Size(100, 21);
            lblProdAsocBadge.TabIndex = 1;
            lblProdAsocBadge.Text = "0 productos";
            lblProdAsocBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCharCount
            // 
            lblCharCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCharCount.AutoSize = true;
            lblCharCount.Font = new Font("Segoe UI", 7.5F);
            lblCharCount.ForeColor = SystemColors.ControlDark;
            lblCharCount.Location = new Point(367, 280);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(47, 20);
            lblCharCount.TabIndex = 11;
            lblCharCount.Text = "0/200";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(24, 190);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(503, 120);
            txtDescripcion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(24, 165);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 8;
            label4.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(24, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(432, 31);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(24, 90);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(24, 3);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 5;
            label2.Text = "Informacion basica";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label1);
            panel7.Controls.Add(iconPictureBox1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(550, 84);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 4;
            label1.Text = "Nueva catgoria";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.FromArgb(139, 92, 246);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tag;
            iconPictureBox1.IconColor = Color.FromArgb(139, 92, 246);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(24, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox1.Size = new Size(59, 53);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // UserControlCategories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControlCategories";
            Size = new Size(1636, 937);
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)CatDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelProductosAsociados.ResumeLayout(false);
            panelProductosAsociados.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView CatDgv;
        private Panel panel1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnNuevaCategoria;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel6;
        private Panel panelProductosAsociados;
        private Label lblProdAsocTexto;
        private Label lblProdAsocBadge;
        private Label lblCharCount;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Panel panel7;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}
