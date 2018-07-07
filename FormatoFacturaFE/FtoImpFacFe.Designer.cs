namespace FormatoFacturaFE
{
    partial class FtoImpFacFe
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
            this.rpvwfactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvwfactura
            // 
            this.rpvwfactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvwfactura.Location = new System.Drawing.Point(0, 0);
            this.rpvwfactura.Name = "rpvwfactura";
            this.rpvwfactura.Size = new System.Drawing.Size(558, 537);
            this.rpvwfactura.TabIndex = 0;
            // 
            // FtoImpFacFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 537);
            this.Controls.Add(this.rpvwfactura);
            this.Name = "FtoImpFacFe";
            this.Text = ".:: Impresion de Factura ::.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvwfactura;
    }
}

