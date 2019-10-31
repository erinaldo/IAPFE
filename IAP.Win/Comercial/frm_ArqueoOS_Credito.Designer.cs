namespace IAP.Win.Comercial
{
    partial class frm_ArqueoOS_Credito
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
            this.gcEstadoCuenta = new DevExpress.XtraGrid.GridControl();
            this.gvwEstadoCuenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstadoCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEstadoCuenta
            // 
            this.gcEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEstadoCuenta.Location = new System.Drawing.Point(0, 0);
            this.gcEstadoCuenta.MainView = this.gvwEstadoCuenta;
            this.gcEstadoCuenta.Name = "gcEstadoCuenta";
            this.gcEstadoCuenta.Size = new System.Drawing.Size(800, 450);
            this.gcEstadoCuenta.TabIndex = 0;
            this.gcEstadoCuenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwEstadoCuenta});
            // 
            // gvwEstadoCuenta
            // 
            this.gvwEstadoCuenta.GridControl = this.gcEstadoCuenta;
            this.gvwEstadoCuenta.Name = "gvwEstadoCuenta";
            this.gvwEstadoCuenta.OptionsView.ShowFooter = true;
            this.gvwEstadoCuenta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwEstadoCuenta_RowCellStyle);
            // 
            // frm_ArqueoOS_Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcEstadoCuenta);
            this.Name = "frm_ArqueoOS_Credito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ArqueoOS_Credito";
            this.Load += new System.EventHandler(this.frm_ArqueoOS_Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEstadoCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwEstadoCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEstadoCuenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwEstadoCuenta;
    }
}