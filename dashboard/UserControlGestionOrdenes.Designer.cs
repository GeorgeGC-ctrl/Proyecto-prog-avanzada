namespace SistemaInventario.Presentacion
{
    partial class UserControlGestionOrdenes
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
            OrdenesDgv = new DataGridView();
            panel1 = new Panel();
            btnNuevaOrden = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)OrdenesDgv).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesDgv
            // 
            OrdenesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            OrdenesDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            OrdenesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdenesDgv.Location = new Point(3, 85);
            OrdenesDgv.Name = "OrdenesDgv";
            OrdenesDgv.RowHeadersWidth = 62;
            OrdenesDgv.Size = new Size(1458, 970);
            OrdenesDgv.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevaOrden);
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 91);
            panel1.TabIndex = 1;
            // 
            // btnNuevaOrden
            // 
            btnNuevaOrden.BackColor = Color.FromArgb(37, 99, 235);
            btnNuevaOrden.FlatAppearance.BorderSize = 0;
            btnNuevaOrden.FlatStyle = FlatStyle.Flat;
            btnNuevaOrden.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaOrden.ForeColor = Color.White;
            btnNuevaOrden.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnNuevaOrden.IconColor = Color.White;
            btnNuevaOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevaOrden.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaOrden.Location = new Point(1091, 25);
            btnNuevaOrden.Name = "btnNuevaOrden";
            btnNuevaOrden.Size = new Size(216, 54);
            btnNuevaOrden.TabIndex = 11;
            btnNuevaOrden.Text = "Nueva Orden";
            btnNuevaOrden.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevaOrden.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaOrden.UseVisualStyleBackColor = false;
            btnNuevaOrden.Click += btnNuevaOrden_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(13, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar orden...";
            txtBuscar.Size = new Size(342, 31);
            txtBuscar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(OrdenesDgv);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1458, 970);
            panel2.TabIndex = 2;
            // 
            // UserControlGestionOrdenes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControlGestionOrdenes";
            Size = new Size(1458, 970);
            Load += UserControlGestionOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)OrdenesDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrdenesDgv;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnNuevaOrden;
        private TextBox txtBuscar;
    }
}
