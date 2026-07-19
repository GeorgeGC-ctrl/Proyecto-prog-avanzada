namespace SistemaInventario.Presentacion
{
    
    
        partial class Form4
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

            #region Código generado por el Diseñador de Windows Forms

            /// <summary>
            /// Método necesario para admitir el Diseñador. No se puede modificar
            /// el contenido de este método con el editor de código.
            /// </summary>
            private void InitializeComponent()
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
                this.panelHeader = new System.Windows.Forms.Panel();
                this.lblSubtitulo = new System.Windows.Forms.Label();
                this.lblTitulo = new System.Windows.Forms.Label();
                this.groupDatosPago = new System.Windows.Forms.GroupBox();
                this.txtDescripcion = new System.Windows.Forms.TextBox();
                this.lblDescripcion = new System.Windows.Forms.Label();
                this.txtSaldo = new System.Windows.Forms.TextBox();
                this.lblSaldo = new System.Windows.Forms.Label();
                this.txtMonto = new System.Windows.Forms.TextBox();
                this.lblMonto = new System.Windows.Forms.Label();
                this.cboProveedor = new System.Windows.Forms.ComboBox();
                this.lblProveedor = new System.Windows.Forms.Label();
                this.groupValidaciones = new System.Windows.Forms.GroupBox();
                this.chkFraude = new System.Windows.Forms.CheckBox();
                this.chkSaldo = new System.Windows.Forms.CheckBox();
                this.chkMonto = new System.Windows.Forms.CheckBox();
                this.panelAcciones = new System.Windows.Forms.Panel();
                this.btnLimpiar = new System.Windows.Forms.Button();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.btnProcesar = new System.Windows.Forms.Button();
                this.btnValidar = new System.Windows.Forms.Button();
                this.dgvPagos = new System.Windows.Forms.DataGridView();
                this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.panelFooter = new System.Windows.Forms.Panel();
                this.lblEstado = new System.Windows.Forms.Label();
                this.panelHeader.SuspendLayout();
                this.groupDatosPago.SuspendLayout();
                this.groupValidaciones.SuspendLayout();
                this.panelAcciones.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
                this.panelFooter.SuspendLayout();
                this.SuspendLayout();
                // 
                // panelHeader
                // 
                this.panelHeader.BackColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.panelHeader.Controls.Add(this.lblSubtitulo);
                this.panelHeader.Controls.Add(this.lblTitulo);
                this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
                this.panelHeader.Location = new System.Drawing.Point(0, 0);
                this.panelHeader.Name = "panelHeader";
                this.panelHeader.Size = new System.Drawing.Size(1100, 90);
                this.panelHeader.TabIndex = 0;
                // 
                // lblTitulo
                // 
                this.lblTitulo.AutoSize = true;
                this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.lblTitulo.ForeColor = System.Drawing.Color.White;
                this.lblTitulo.Location = new System.Drawing.Point(30, 15);
                this.lblTitulo.Name = "lblTitulo";
                this.lblTitulo.Size = new System.Drawing.Size(482, 41);
                this.lblTitulo.TabIndex = 0;
                this.lblTitulo.Text = "Procesamiento de Pagos - A2 Banking";
                // 
                // lblSubtitulo
                // 
                this.lblSubtitulo.AutoSize = true;
                this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
                this.lblSubtitulo.Location = new System.Drawing.Point(34, 56);
                this.lblSubtitulo.Name = "lblSubtitulo";
                this.lblSubtitulo.Size = new System.Drawing.Size(261, 21);
                this.lblSubtitulo.TabIndex = 1;
                this.lblSubtitulo.Text = "Validación y procesamiento de transacciones";
                // 
                // groupDatosPago
                // 
                this.groupDatosPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.groupDatosPago.BackColor = System.Drawing.Color.White;
                this.groupDatosPago.Controls.Add(this.txtDescripcion);
                this.groupDatosPago.Controls.Add(this.lblDescripcion);
                this.groupDatosPago.Controls.Add(this.txtSaldo);
                this.groupDatosPago.Controls.Add(this.lblSaldo);
                this.groupDatosPago.Controls.Add(this.txtMonto);
                this.groupDatosPago.Controls.Add(this.lblMonto);
                this.groupDatosPago.Controls.Add(this.cboProveedor);
                this.groupDatosPago.Controls.Add(this.lblProveedor);
                this.groupDatosPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.groupDatosPago.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.groupDatosPago.Location = new System.Drawing.Point(30, 105);
                this.groupDatosPago.Name = "groupDatosPago";
                this.groupDatosPago.Size = new System.Drawing.Size(700, 210);
                this.groupDatosPago.TabIndex = 1;
                this.groupDatosPago.TabStop = false;
                this.groupDatosPago.Text = "Datos del Pago";
                // 
                // lblProveedor
                // 
                this.lblProveedor.AutoSize = true;
                this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.lblProveedor.Location = new System.Drawing.Point(30, 40);
                this.lblProveedor.Name = "lblProveedor";
                this.lblProveedor.Size = new System.Drawing.Size(124, 19);
                this.lblProveedor.TabIndex = 0;
                this.lblProveedor.Text = "Proveedor de Pago";
                // 
                // cboProveedor
                // 
                this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.cboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.cboProveedor.FormattingEnabled = true;
                this.cboProveedor.Items.AddRange(new object[] {
            "PayPal",
            "Stripe",
            "Visa"});
                this.cboProveedor.Location = new System.Drawing.Point(170, 37);
                this.cboProveedor.Name = "cboProveedor";
                this.cboProveedor.Size = new System.Drawing.Size(180, 25);
                this.cboProveedor.TabIndex = 1;
                // 
                // lblMonto
                // 
                this.lblMonto.AutoSize = true;
                this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.lblMonto.Location = new System.Drawing.Point(30, 80);
                this.lblMonto.Name = "lblMonto";
                this.lblMonto.Size = new System.Drawing.Size(49, 19);
                this.lblMonto.TabIndex = 2;
                this.lblMonto.Text = "Monto";
                // 
                // txtMonto
                // 
                this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.txtMonto.Location = new System.Drawing.Point(170, 77);
                this.txtMonto.Name = "txtMonto";
                this.txtMonto.Size = new System.Drawing.Size(180, 25);
                this.txtMonto.TabIndex = 3;
                // 
                // lblSaldo
                // 
                this.lblSaldo.AutoSize = true;
                this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.lblSaldo.Location = new System.Drawing.Point(30, 120);
                this.lblSaldo.Name = "lblSaldo";
                this.lblSaldo.Size = new System.Drawing.Size(112, 19);
                this.lblSaldo.TabIndex = 4;
                this.lblSaldo.Text = "Saldo Disponible";
                // 
                // txtSaldo
                // 
                this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.txtSaldo.Location = new System.Drawing.Point(170, 117);
                this.txtSaldo.Name = "txtSaldo";
                this.txtSaldo.Size = new System.Drawing.Size(180, 25);
                this.txtSaldo.TabIndex = 5;
                // 
                // lblDescripcion
                // 
                this.lblDescripcion.AutoSize = true;
                this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.lblDescripcion.Location = new System.Drawing.Point(30, 160);
                this.lblDescripcion.Name = "lblDescripcion";
                this.lblDescripcion.Size = new System.Drawing.Size(78, 19);
                this.lblDescripcion.TabIndex = 6;
                this.lblDescripcion.Text = "Descripción";
                // 
                // txtDescripcion
                // 
                this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.txtDescripcion.Location = new System.Drawing.Point(170, 157);
                this.txtDescripcion.Multiline = true;
                this.txtDescripcion.Name = "txtDescripcion";
                this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                this.txtDescripcion.Size = new System.Drawing.Size(480, 40);
                this.txtDescripcion.TabIndex = 7;
                // 
                // groupValidaciones
                // 
                this.groupValidaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                this.groupValidaciones.BackColor = System.Drawing.Color.White;
                this.groupValidaciones.Controls.Add(this.chkFraude);
                this.groupValidaciones.Controls.Add(this.chkSaldo);
                this.groupValidaciones.Controls.Add(this.chkMonto);
                this.groupValidaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.groupValidaciones.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.groupValidaciones.Location = new System.Drawing.Point(750, 105);
                this.groupValidaciones.Name = "groupValidaciones";
                this.groupValidaciones.Size = new System.Drawing.Size(320, 210);
                this.groupValidaciones.TabIndex = 2;
                this.groupValidaciones.TabStop = false;
                this.groupValidaciones.Text = "Estado de Validaciones";
                // 
                // chkMonto
                // 
                this.chkMonto.AutoSize = true;
                this.chkMonto.Enabled = false;
                this.chkMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.chkMonto.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.chkMonto.Location = new System.Drawing.Point(30, 50);
                this.chkMonto.Name = "chkMonto";
                this.chkMonto.Size = new System.Drawing.Size(134, 23);
                this.chkMonto.TabIndex = 0;
                this.chkMonto.Text = "Monto válido (> 0)";
                this.chkMonto.UseVisualStyleBackColor = true;
                // 
                // chkSaldo
                // 
                this.chkSaldo.AutoSize = true;
                this.chkSaldo.Enabled = false;
                this.chkSaldo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.chkSaldo.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.chkSaldo.Location = new System.Drawing.Point(30, 90);
                this.chkSaldo.Name = "chkSaldo";
                this.chkSaldo.Size = new System.Drawing.Size(127, 23);
                this.chkSaldo.TabIndex = 1;
                this.chkSaldo.Text = "Saldo disponible";
                this.chkSaldo.UseVisualStyleBackColor = true;
                // 
                // chkFraude
                // 
                this.chkFraude.AutoSize = true;
                this.chkFraude.Enabled = false;
                this.chkFraude.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.chkFraude.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.chkFraude.Location = new System.Drawing.Point(30, 130);
                this.chkFraude.Name = "chkFraude";
                this.chkFraude.Size = new System.Drawing.Size(170, 23);
                this.chkFraude.TabIndex = 2;
                this.chkFraude.Text = "Validación antifraude";
                this.chkFraude.UseVisualStyleBackColor = true;
                // 
                // panelAcciones
                // 
                this.panelAcciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
                this.panelAcciones.Controls.Add(this.btnLimpiar);
                this.panelAcciones.Controls.Add(this.btnGuardar);
                this.panelAcciones.Controls.Add(this.btnProcesar);
                this.panelAcciones.Controls.Add(this.btnValidar);
                this.panelAcciones.Location = new System.Drawing.Point(30, 330);
                this.panelAcciones.Name = "panelAcciones";
                this.panelAcciones.Size = new System.Drawing.Size(1040, 80);
                this.panelAcciones.TabIndex = 3;
                // 
                // btnValidar
                // 
                this.btnValidar.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.btnValidar.BackColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.btnValidar.FlatAppearance.BorderSize = 0;
                this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnValidar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.btnValidar.ForeColor = System.Drawing.Color.White;
                this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
                this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnValidar.Location = new System.Drawing.Point(120, 15);
                this.btnValidar.Name = "btnValidar";
                this.btnValidar.Size = new System.Drawing.Size(180, 50);
                this.btnValidar.TabIndex = 0;
                this.btnValidar.Text = "   Validar";
                this.btnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.btnValidar.UseVisualStyleBackColor = false;
                // 
                // btnProcesar
                // 
                this.btnProcesar.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.btnProcesar.FlatAppearance.BorderSize = 0;
                this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.btnProcesar.ForeColor = System.Drawing.Color.White;
                this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
                this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnProcesar.Location = new System.Drawing.Point(320, 15);
                this.btnProcesar.Name = "btnProcesar";
                this.btnProcesar.Size = new System.Drawing.Size(180, 50);
                this.btnProcesar.TabIndex = 1;
                this.btnProcesar.Text = "   Procesar Pago";
                this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.btnProcesar.UseVisualStyleBackColor = false;
                // 
                // btnGuardar
                // 
                this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.btnGuardar.FlatAppearance.BorderSize = 0;
                this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.btnGuardar.ForeColor = System.Drawing.Color.White;
                this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
                this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnGuardar.Location = new System.Drawing.Point(520, 15);
                this.btnGuardar.Name = "btnGuardar";
                this.btnGuardar.Size = new System.Drawing.Size(180, 50);
                this.btnGuardar.TabIndex = 2;
                this.btnGuardar.Text = "   Guardar";
                this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.btnGuardar.UseVisualStyleBackColor = false;
                // 
                // btnLimpiar
                // 
                this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.btnLimpiar.FlatAppearance.BorderSize = 0;
                this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.btnLimpiar.ForeColor = System.Drawing.Color.White;
                this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
                this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.btnLimpiar.Location = new System.Drawing.Point(720, 15);
                this.btnLimpiar.Name = "btnLimpiar";
                this.btnLimpiar.Size = new System.Drawing.Size(180, 50);
                this.btnLimpiar.TabIndex = 3;
                this.btnLimpiar.Text = "   Limpiar";
                this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                this.btnLimpiar.UseVisualStyleBackColor = false;
                // 
                // dgvPagos
                // 
                this.dgvPagos.AllowUserToAddRows = false;
                this.dgvPagos.AllowUserToDeleteRows = false;
                this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
                this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFecha,
            this.colProveedor,
            this.colMonto,
            this.colEstado});
                this.dgvPagos.Location = new System.Drawing.Point(30, 430);
                this.dgvPagos.Name = "dgvPagos";
                this.dgvPagos.ReadOnly = true;
                this.dgvPagos.RowHeadersVisible = false;
                this.dgvPagos.RowTemplate.Height = 28;
                this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                this.dgvPagos.Size = new System.Drawing.Size(1040, 200);
                this.dgvPagos.TabIndex = 4;
                // 
                // colId
                // 
                this.colId.HeaderText = "ID";
                this.colId.Name = "colId";
                this.colId.ReadOnly = true;
                this.colId.Width = 60;
                // 
                // colFecha
                // 
                this.colFecha.HeaderText = "Fecha";
                this.colFecha.Name = "colFecha";
                this.colFecha.ReadOnly = true;
                this.colFecha.Width = 180;
                // 
                // colProveedor
                // 
                this.colProveedor.HeaderText = "Proveedor";
                this.colProveedor.Name = "colProveedor";
                this.colProveedor.ReadOnly = true;
                this.colProveedor.Width = 180;
                // 
                // colMonto
                // 
                this.colMonto.HeaderText = "Monto";
                this.colMonto.Name = "colMonto";
                this.colMonto.ReadOnly = true;
                this.colMonto.Width = 120;
                // 
                // colEstado
                // 
                this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                this.colEstado.HeaderText = "Estado";
                this.colEstado.Name = "colEstado";
                this.colEstado.ReadOnly = true;
                // 
                // panelFooter
                // 
                this.panelFooter.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
                this.panelFooter.Controls.Add(this.lblEstado);
                this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.panelFooter.Location = new System.Drawing.Point(0, 650);
                this.panelFooter.Name = "panelFooter";
                this.panelFooter.Size = new System.Drawing.Size(1100, 50);
                this.panelFooter.TabIndex = 5;
                // 
                // lblEstado
                // 
                this.lblEstado.AutoSize = true;
                this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(24, 37, 66);
                this.lblEstado.Location = new System.Drawing.Point(30, 15);
                this.lblEstado.Name = "lblEstado";
                this.lblEstado.Size = new System.Drawing.Size(202, 19);
                this.lblEstado.TabIndex = 0;
                this.lblEstado.Text = "Estado: Esperando procesamiento...";
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.ClientSize = new System.Drawing.Size(1100, 700);
                this.Controls.Add(this.panelFooter);
                this.Controls.Add(this.dgvPagos);
                this.Controls.Add(this.panelAcciones);
                this.Controls.Add(this.groupValidaciones);
                this.Controls.Add(this.groupDatosPago);
                this.Controls.Add(this.panelHeader);
                this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.MaximizeBox = true;
                this.MinimumSize = new System.Drawing.Size(1100, 700);
                this.Name = "Form1";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Procesamiento de Pagos - A2 Banking";
                this.panelHeader.ResumeLayout(false);
                this.panelHeader.PerformLayout();
                this.groupDatosPago.ResumeLayout(false);
                this.groupDatosPago.PerformLayout();
                this.groupValidaciones.ResumeLayout(false);
                this.groupValidaciones.PerformLayout();
                this.panelAcciones.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
                this.panelFooter.ResumeLayout(false);
                this.panelFooter.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panelHeader;
            private System.Windows.Forms.Label lblTitulo;
            private System.Windows.Forms.Label lblSubtitulo;
            private System.Windows.Forms.GroupBox groupDatosPago;
            private System.Windows.Forms.Label lblProveedor;
            private System.Windows.Forms.ComboBox cboProveedor;
            private System.Windows.Forms.Label lblMonto;
            private System.Windows.Forms.TextBox txtMonto;
            private System.Windows.Forms.Label lblSaldo;
            private System.Windows.Forms.TextBox txtSaldo;
            private System.Windows.Forms.Label lblDescripcion;
            private System.Windows.Forms.TextBox txtDescripcion;
            private System.Windows.Forms.GroupBox groupValidaciones;
            private System.Windows.Forms.CheckBox chkMonto;
            private System.Windows.Forms.CheckBox chkSaldo;
            private System.Windows.Forms.CheckBox chkFraude;
            private System.Windows.Forms.Panel panelAcciones;
            private System.Windows.Forms.Button btnValidar;
            private System.Windows.Forms.Button btnProcesar;
            private System.Windows.Forms.Button btnGuardar;
            private System.Windows.Forms.Button btnLimpiar;
            private System.Windows.Forms.DataGridView dgvPagos;
            private System.Windows.Forms.DataGridViewTextBoxColumn colId;
            private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
            private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
            private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
            private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
            private System.Windows.Forms.Panel panelFooter;
            private System.Windows.Forms.Label lblEstado;
        }
    }