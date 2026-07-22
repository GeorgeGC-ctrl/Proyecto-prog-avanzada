namespace SistemaInventario.Presentacion
{
    partial class FormOrder
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
            panel1 = new Panel();
            ucAgregarOrden1 = new ucAgregarOrden();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ucAgregarOrden1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 960);
            panel1.TabIndex = 0;
            // 
            // ucAgregarOrden1
            // 
            ucAgregarOrden1.Dock = DockStyle.Fill;
            ucAgregarOrden1.Location = new Point(0, 0);
            ucAgregarOrden1.Name = "ucAgregarOrden1";
            ucAgregarOrden1.Size = new Size(960, 960);
            ucAgregarOrden1.TabIndex = 0;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 960);
            Controls.Add(panel1);
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrder";
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ucAgregarOrden ucAgregarOrden1;
    }
}
