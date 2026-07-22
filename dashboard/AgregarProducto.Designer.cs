namespace SistemaInventario.Presentacion
{
    partial class AgregarProducto
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            BtnNuevo = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            cbSuplidor = new ComboBox();
            label6 = new Label();
            cbCategoria = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            txtStock = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(BtnNuevo);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 694);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(397, 616);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.BackColor = Color.FromArgb(37, 99, 235);
            BtnNuevo.FlatAppearance.BorderSize = 0;
            BtnNuevo.FlatStyle = FlatStyle.Popup;
            BtnNuevo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevo.ForeColor = Color.White;
            BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            BtnNuevo.IconColor = Color.Black;
            BtnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNuevo.Location = new Point(215, 616);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(153, 55);
            BtnNuevo.TabIndex = 6;
            BtnNuevo.Text = "Guardar";
            BtnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            BtnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNuevo.UseVisualStyleBackColor = false;
            BtnNuevo.Click += iconButton3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(cbSuplidor);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(cbCategoria);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 305);
            panel4.Name = "panel4";
            panel4.Size = new Size(573, 283);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            checkBox1.Location = new Point(24, 227);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 25);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(296, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(296, 137);
            label10.Name = "label10";
            label10.Size = new Size(133, 21);
            label10.TabIndex = 14;
            label10.Text = "Nivel de reorden";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(24, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 31);
            textBox2.TabIndex = 13;
            textBox2.Text = "`";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(296, 55);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 12;
            label7.Text = "Suplidor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(24, 137);
            label9.Name = "label9";
            label9.Size = new Size(138, 21);
            label9.TabIndex = 12;
            label9.Text = "Unidades Pedidas";
            // 
            // cbSuplidor
            // 
            cbSuplidor.FlatStyle = FlatStyle.Popup;
            cbSuplidor.FormattingEnabled = true;
            cbSuplidor.Location = new Point(296, 79);
            cbSuplidor.Name = "cbSuplidor";
            cbSuplidor.Size = new Size(228, 33);
            cbSuplidor.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(24, 55);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 10;
            label6.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FlatStyle = FlatStyle.Popup;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(24, 79);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(228, 33);
            cbCategoria.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 10;
            label5.Text = "Clasificacion";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtStock);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPrecio);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(573, 221);
            panel3.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(264, 153);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(192, 31);
            txtStock.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(264, 117);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 10;
            label8.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(24, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(171, 31);
            txtPrecio.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(24, 117);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(24, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(432, 31);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(24, 35);
            label3.Name = "label3";
            label3.Size = new Size(171, 21);
            label3.TabIndex = 6;
            label3.Text = "Nombre del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 5;
            label2.Text = "Informacion basica";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 84);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 4;
            label1.Text = "Nuevo producto";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Cube;
            iconPictureBox1.IconColor = Color.FromArgb(37, 99, 235);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 53;
            iconPictureBox1.Location = new Point(24, 14);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox1.Size = new Size(59, 53);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AgregarProducto";
            Size = new Size(573, 694);
            Load += AgregarProducto_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private Label label7;
        private ComboBox cbSuplidor;
        private Label label6;
        private ComboBox cbCategoria;
        private Label label5;
        private TextBox txtPrecio;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private TextBox textBox2;
        private Label label9;
        private TextBox txtStock;
        private Label label8;
        private TextBox textBox1;
        private Label label10;
        private CheckBox checkBox1;
    }
}
