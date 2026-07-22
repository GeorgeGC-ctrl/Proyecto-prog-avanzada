namespace SistemaInventario.Presentacion
{
    partial class ucAgregarOrden
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
            panelDetalle = new GroupBox();
            lblTotal = new Label();
            label12 = new Label();
            dgvDetalles = new DataGridView();
            btnEliminarDetalle = new FontAwesome.Sharp.IconButton();
            btnAgregarDetalle = new FontAwesome.Sharp.IconButton();
            txtDescuento = new TextBox();
            label11 = new Label();
            txtCantidad = new TextBox();
            label10 = new Label();
            txtPrecioUnidad = new TextBox();
            label9 = new Label();
            cbProducto = new ComboBox();
            label8 = new Label();
            panelCabecera = new GroupBox();
            dtpRequerida = new DateTimePicker();
            label7 = new Label();
            txtPais = new TextBox();
            label6 = new Label();
            txtCiudad = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtCliente = new TextBox();
            label3 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panelTop = new Panel();
            pbIcono = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            panel1.SuspendLayout();
            panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            panelCabecera.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelDetalle);
            panel1.Controls.Add(panelCabecera);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(panelTop);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 950);
            panel1.TabIndex = 0;
            // 
            // panelDetalle
            // 
            panelDetalle.Controls.Add(lblTotal);
            panelDetalle.Controls.Add(label12);
            panelDetalle.Controls.Add(dgvDetalles);
            panelDetalle.Controls.Add(btnEliminarDetalle);
            panelDetalle.Controls.Add(btnAgregarDetalle);
            panelDetalle.Controls.Add(txtDescuento);
            panelDetalle.Controls.Add(label11);
            panelDetalle.Controls.Add(txtCantidad);
            panelDetalle.Controls.Add(label10);
            panelDetalle.Controls.Add(txtPrecioUnidad);
            panelDetalle.Controls.Add(label9);
            panelDetalle.Controls.Add(cbProducto);
            panelDetalle.Controls.Add(label8);
            panelDetalle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            panelDetalle.ForeColor = SystemColors.ControlText;
            panelDetalle.Location = new Point(12, 340);
            panelDetalle.Name = "panelDetalle";
            panelDetalle.Size = new Size(926, 520);
            panelDetalle.TabIndex = 2;
            panelDetalle.TabStop = false;
            panelDetalle.Text = "Detalles de la Orden";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotal.Location = new Point(780, 470);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(83, 32);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "RD$ 0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(690, 470);
            label12.Name = "label12";
            label12.Size = new Size(92, 32);
            label12.TabIndex = 21;
            label12.Text = "TOTAL:";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.BackgroundColor = Color.White;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(18, 120);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 62;
            dgvDetalles.Size = new Size(890, 330);
            dgvDetalles.TabIndex = 20;
            
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.BackColor = Color.FromArgb(254, 242, 242);
            btnEliminarDetalle.FlatAppearance.BorderColor = Color.FromArgb(239, 68, 68);
            btnEliminarDetalle.FlatStyle = FlatStyle.Flat;
            btnEliminarDetalle.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            btnEliminarDetalle.ForeColor = Color.FromArgb(239, 68, 68);
            btnEliminarDetalle.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarDetalle.IconColor = Color.FromArgb(239, 68, 68);
            btnEliminarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarDetalle.IconSize = 24;
            btnEliminarDetalle.Location = new Point(780, 58);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(128, 40);
            btnEliminarDetalle.TabIndex = 19;
            btnEliminarDetalle.Text = "Quitar";
            btnEliminarDetalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarDetalle.UseVisualStyleBackColor = false;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            btnAgregarDetalle.FlatStyle = FlatStyle.Flat;
            btnAgregarDetalle.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            btnAgregarDetalle.ForeColor = Color.White;
            btnAgregarDetalle.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregarDetalle.IconColor = Color.White;
            btnAgregarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarDetalle.IconSize = 24;
            btnAgregarDetalle.Location = new Point(640, 58);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(128, 40);
            btnAgregarDetalle.TabIndex = 18;
            btnAgregarDetalle.Text = "Agregar";
            btnAgregarDetalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarDetalle.UseVisualStyleBackColor = false;
            btnAgregarDetalle.Click += btnAgregarDetalle_Click;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(530, 62);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(90, 31);
            txtDescuento.TabIndex = 17;
            txtDescuento.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(530, 35);
            label11.Name = "label11";
            label11.Size = new Size(84, 21);
            label11.TabIndex = 16;
            label11.Text = "Desc. (0-1)";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(420, 62);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(90, 31);
            txtCantidad.TabIndex = 15;
            txtCantidad.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(420, 35);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 14;
            label10.Text = "Cantidad";
            // 
            // txtPrecioUnidad
            // 
            txtPrecioUnidad.Location = new Point(290, 62);
            txtPrecioUnidad.Name = "txtPrecioUnidad";
            txtPrecioUnidad.Size = new Size(110, 31);
            txtPrecioUnidad.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(290, 35);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 12;
            label9.Text = "Precio";
            // 
            // cbProducto
            // 
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(18, 62);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(250, 33);
            cbProducto.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(18, 35);
            label8.Name = "label8";
            label8.Size = new Size(78, 21);
            label8.TabIndex = 10;
            label8.Text = "Producto";
            // 
            // panelCabecera
            // 
            panelCabecera.Controls.Add(dtpRequerida);
            panelCabecera.Controls.Add(label7);
            panelCabecera.Controls.Add(txtPais);
            panelCabecera.Controls.Add(label6);
            panelCabecera.Controls.Add(txtCiudad);
            panelCabecera.Controls.Add(label5);
            panelCabecera.Controls.Add(txtDireccion);
            panelCabecera.Controls.Add(label4);
            panelCabecera.Controls.Add(txtCliente);
            panelCabecera.Controls.Add(label3);
            panelCabecera.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            panelCabecera.Location = new Point(12, 100);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(926, 220);
            panelCabecera.TabIndex = 1;
            panelCabecera.TabStop = false;
            panelCabecera.Text = "Información General";
            // 
            // dtpRequerida
            // 
            dtpRequerida.Format = DateTimePickerFormat.Short;
            dtpRequerida.Location = new Point(530, 62);
            dtpRequerida.Name = "dtpRequerida";
            dtpRequerida.Size = new Size(378, 31);
            dtpRequerida.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(530, 35);
            label7.Name = "label7";
            label7.Size = new Size(165, 21);
            label7.TabIndex = 18;
            label7.Text = "Fecha Requerimiento";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(274, 152);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(230, 31);
            txtPais.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(274, 125);
            label6.Name = "label6";
            label6.Size = new Size(38, 21);
            label6.TabIndex = 16;
            label6.Text = "País";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(18, 152);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(230, 31);
            txtCiudad.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(18, 125);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 14;
            label5.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(530, 152);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(378, 31);
            txtDireccion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(530, 125);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 12;
            label4.Text = "Dirección";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(18, 62);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(486, 31);
            txtCliente.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 10;
            label3.Text = "ID del Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 24;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(760, 880);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 58);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(16, 185, 129);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 24;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(560, 880);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 58);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Confirmar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(pbIcono);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(950, 84);
            panelTop.TabIndex = 0;
            // 
            // pbIcono
            // 
            pbIcono.BackColor = Color.WhiteSmoke;
            pbIcono.ForeColor = Color.FromArgb(37, 99, 235);
            pbIcono.IconChar = FontAwesome.Sharp.IconChar.CartFlatbedSuitcase;
            pbIcono.IconColor = Color.FromArgb(37, 99, 235);
            pbIcono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIcono.IconSize = 53;
            pbIcono.Location = new Point(25, 16);
            pbIcono.Name = "pbIcono";
            pbIcono.Padding = new Padding(5, 0, 10, 0);
            pbIcono.Size = new Size(59, 53);
            pbIcono.TabIndex = 5;
            pbIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitulo.Location = new Point(101, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 28);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Nueva Orden";
            // 
            // ucAgregarOrden
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucAgregarOrden";
            Size = new Size(950, 950);
            panel1.ResumeLayout(false);
            panelDetalle.ResumeLayout(false);
            panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Panel panelTop;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox pbIcono;
        private GroupBox panelCabecera;
        private TextBox txtCliente;
        private Label label3;
        private TextBox txtPais;
        private Label label6;
        private TextBox txtCiudad;
        private Label label5;
        private TextBox txtDireccion;
        private Label label4;
        private DateTimePicker dtpRequerida;
        private Label label7;
        private GroupBox panelDetalle;
        private Label label8;
        private ComboBox cbProducto;
        private TextBox txtPrecioUnidad;
        private Label label9;
        private TextBox txtCantidad;
        private Label label10;
        private TextBox txtDescuento;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnAgregarDetalle;
        private FontAwesome.Sharp.IconButton btnEliminarDetalle;
        private DataGridView dgvDetalles;
        private Label lblTotal;
        private Label label12;
    }
}
