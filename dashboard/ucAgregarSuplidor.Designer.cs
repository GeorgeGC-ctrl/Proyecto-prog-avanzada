namespace SistemaInventario.Presentacion
{
    partial class ucAgregarSuplidor
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new MaskedTextBox();
            label9 = new Label();
            txtContacto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            txtWeb = new TextBox();
            label4 = new Label();
            txtEmpresa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 717);
            panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.IndianRed;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(311, 636);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(177, 58);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Cancelar";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(16, 185, 129);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(101, 636);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(179, 58);
            iconButton3.TabIndex = 6;
            iconButton3.Text = "Guardar";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtCorreo);
            panel4.Controls.Add(txtTelefono);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtContacto);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 388);
            panel4.Name = "panel4";
            panel4.Size = new Size(521, 233);
            panel4.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(206, 143);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(269, 31);
            txtCorreo.TabIndex = 18;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(13, 143);
            txtTelefono.Mask = "000-000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(159, 31);
            txtTelefono.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(207, 119);
            label9.Name = "label9";
            label9.Size = new Size(33, 21);
            label9.TabIndex = 16;
            label9.Text = "Fax";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(13, 74);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(432, 31);
            txtContacto.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(13, 119);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 12;
            label7.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(13, 50);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 10;
            label6.Text = "Persona de contacto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 10;
            label5.Text = "Contacto";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtWeb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtEmpresa);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(521, 304);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(279, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 31);
            textBox1.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(279, 209);
            label10.Name = "label10";
            label10.Size = new Size(61, 21);
            label10.TabIndex = 11;
            label10.Text = "Ciudad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(12, 209);
            label8.Name = "label8";
            label8.Size = new Size(38, 21);
            label8.TabIndex = 10;
            label8.Text = "Pais";
            // 
            // txtWeb
            // 
            txtWeb.BorderStyle = BorderStyle.FixedSingle;
            txtWeb.Location = new Point(12, 153);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(432, 31);
            txtWeb.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 8;
            label4.Text = "Direccion";
            // 
            // txtEmpresa
            // 
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.Location = new Point(12, 69);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(432, 31);
            txtEmpresa.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 35);
            label3.Name = "label3";
            label3.Size = new Size(176, 21);
            label3.TabIndex = 6;
            label3.Text = "Nombre de la Empresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Empresa";
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 84);
            panel2.TabIndex = 0;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.WhiteSmoke;
            iconPictureBox3.ForeColor = Color.FromArgb(16, 185, 129);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Truck;
            iconPictureBox3.IconColor = Color.FromArgb(16, 185, 129);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 53;
            iconPictureBox3.Location = new Point(25, 16);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Padding = new Padding(5, 0, 10, 0);
            iconPictureBox3.Size = new Size(59, 53);
            iconPictureBox3.TabIndex = 5;
            iconPictureBox3.TabStop = false;
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
            label1.Text = "Nuevo suplidor";
            // 
            // ucAgregarSuplidor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucAgregarSuplidor";
            Size = new Size(521, 717);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private TextBox txtWeb;
        private Label label4;
        private TextBox txtEmpresa;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TextBox txtCorreo;
        private MaskedTextBox txtTelefono;
        private Label label9;
        private TextBox txtContacto;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
    }
}
