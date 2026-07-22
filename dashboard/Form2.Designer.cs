namespace SistemaInventario.Presentacion
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelAgregar = new Panel();
            agregarProducto1 = new AgregarProducto();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panelAgregar
            // 
            panelAgregar.Controls.Add(agregarProducto1);
            panelAgregar.Dock = DockStyle.Fill;
            panelAgregar.Location = new Point(0, 0);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(573, 693);
            panelAgregar.TabIndex = 0;
            // 
            // agregarProducto1
            // 
            agregarProducto1.Location = new Point(3, 0);
            agregarProducto1.Name = "agregarProducto1";
            agregarProducto1.Size = new Size(570, 693);
            agregarProducto1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 693);
            Controls.Add(panelAgregar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            Load += Form2_Load;
            panelAgregar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregar;
        private AgregarProducto agregarProducto1;
    }
}