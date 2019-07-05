namespace IAP.Win
{
    partial class frm_importar_asiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_importar_asiento));
            this.cmbanno = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.txthaber = new DevExpress.XtraEditors.TextEdit();
            this.txtdebe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcasientos = new DevExpress.XtraGrid.GridControl();
            this.gvwasientos = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthaber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdebe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcasientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwasientos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbanno
            // 
            this.cmbanno.FormattingEnabled = true;
            this.cmbanno.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2025"});
            this.cmbanno.Location = new System.Drawing.Point(107, 13);
            this.cmbanno.Name = "cmbanno";
            this.cmbanno.Size = new System.Drawing.Size(121, 21);
            this.cmbanno.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seleccione Año";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(949, 461);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Importar Asientos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.btn_guardar);
            this.splitContainer1.Panel1.Controls.Add(this.txthaber);
            this.splitContainer1.Panel1.Controls.Add(this.txtdebe);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbanno);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcasientos);
            this.splitContainer1.Size = new System.Drawing.Size(945, 439);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(556, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(319, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Hacer clic en guardar solo si cuadran los montos del DEBE y HABER";
            // 
            // btn_guardar
            // 
            this.btn_guardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.ImageOptions.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(892, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 38);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "simpleButton2";
            this.btn_guardar.ToolTip = "Guardar Informacion";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txthaber
            // 
            this.txthaber.Location = new System.Drawing.Point(797, 13);
            this.txthaber.Name = "txthaber";
            this.txthaber.Size = new System.Drawing.Size(76, 20);
            this.txthaber.TabIndex = 6;
            // 
            // txtdebe
            // 
            this.txtdebe.Location = new System.Drawing.Point(659, 13);
            this.txtdebe.Name = "txtdebe";
            this.txtdebe.Size = new System.Drawing.Size(76, 20);
            this.txtdebe.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(759, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Haber";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(625, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Debe";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(237, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(42, 38);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.ToolTip = "Seleccionar libro de Excel, la hoja debe llamarse asientos";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcasientos
            // 
            this.gcasientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcasientos.Location = new System.Drawing.Point(0, 0);
            this.gcasientos.MainView = this.gvwasientos;
            this.gcasientos.Name = "gcasientos";
            this.gcasientos.Size = new System.Drawing.Size(945, 384);
            this.gcasientos.TabIndex = 0;
            this.gcasientos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwasientos});
            // 
            // gvwasientos
            // 
            this.gvwasientos.GridControl = this.gcasientos;
            this.gvwasientos.Name = "gvwasientos";
            this.gvwasientos.OptionsView.ShowGroupPanel = false;
            // 
            // frm_importar_asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 461);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_importar_asiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txthaber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdebe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcasientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwasientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbanno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.TextEdit txthaber;
        private DevExpress.XtraEditors.TextEdit txtdebe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcasientos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwasientos;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}