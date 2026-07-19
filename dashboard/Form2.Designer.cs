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
            SuspendLayout();
            // 
            // panelAgregar
            // 
            panelAgregar.Dock = DockStyle.Fill;
            panelAgregar.Location = new Point(0, 0);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(553, 531);
            panelAgregar.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 531);
            Controls.Add(panelAgregar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregar;
    }
}