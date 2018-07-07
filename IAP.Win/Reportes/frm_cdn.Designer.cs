namespace IAP.Win
{
    partial class frm_cdn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cdn));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnexportar = new DevExpress.XtraEditors.SimpleButton();
            this.btnprocesar = new DevExpress.XtraEditors.SimpleButton();
            this.dtpfechaf = new System.Windows.Forms.DateTimePicker();
            this.dtpfechai = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LookUpEdit_Familia = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lookUpEdit_SubFam = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lookUpEdit_Vendedor = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_cdn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Familia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SubFam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Vendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnexportar);
            this.groupControl1.Controls.Add(this.btnprocesar);
            this.groupControl1.Controls.Add(this.dtpfechaf);
            this.groupControl1.Controls.Add(this.dtpfechai);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LookUpEdit_Familia);
            this.groupControl1.Controls.Add(this.lookUpEdit_SubFam);
            this.groupControl1.Controls.Add(this.lookUpEdit_Vendedor);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(958, 107);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "PARAMETROS PARA LA CONSULTA";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnexportar
            // 
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.Location = new System.Drawing.Point(758, 40);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(43, 33);
            this.btnexportar.TabIndex = 11;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnprocesar
            // 
            this.btnprocesar.Image = ((System.Drawing.Image)(resources.GetObject("btnprocesar.Image")));
            this.btnprocesar.Location = new System.Drawing.Point(695, 39);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(45, 34);
            this.btnprocesar.TabIndex = 10;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // dtpfechaf
            // 
            this.dtpfechaf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaf.Location = new System.Drawing.Point(86, 64);
            this.dtpfechaf.Name = "dtpfechaf";
            this.dtpfechaf.Size = new System.Drawing.Size(105, 21);
            this.dtpfechaf.TabIndex = 6;
            // 
            // dtpfechai
            // 
            this.dtpfechai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechai.Location = new System.Drawing.Point(86, 34);
            this.dtpfechai.Name = "dtpfechai";
            this.dtpfechai.Size = new System.Drawing.Size(105, 21);
            this.dtpfechai.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(455, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Vendedor :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(240, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Sub Familia :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(261, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Familia :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha Final :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha Inicial :";
            // 
            // LookUpEdit_Familia
            // 
            this.LookUpEdit_Familia.Location = new System.Drawing.Point(306, 34);
            this.LookUpEdit_Familia.Name = "LookUpEdit_Familia";
            this.LookUpEdit_Familia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Familia.Properties.NullText = "[Vacío]";
            this.LookUpEdit_Familia.Size = new System.Drawing.Size(130, 20);
            this.LookUpEdit_Familia.TabIndex = 7;
            this.LookUpEdit_Familia.EditValueChanged += new System.EventHandler(this.LookUpEdit_Familia_EditValueChanged);
            // 
            // lookUpEdit_SubFam
            // 
            this.lookUpEdit_SubFam.Location = new System.Drawing.Point(306, 67);
            this.lookUpEdit_SubFam.Name = "lookUpEdit_SubFam";
            this.lookUpEdit_SubFam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_SubFam.Properties.NullText = "[Vacío]";
            this.lookUpEdit_SubFam.Size = new System.Drawing.Size(130, 20);
            this.lookUpEdit_SubFam.TabIndex = 8;
            // 
            // lookUpEdit_Vendedor
            // 
            this.lookUpEdit_Vendedor.Location = new System.Drawing.Point(514, 36);
            this.lookUpEdit_Vendedor.Name = "lookUpEdit_Vendedor";
            this.lookUpEdit_Vendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Vendedor.Properties.NullText = "[Vacío]";
            this.lookUpEdit_Vendedor.Size = new System.Drawing.Size(130, 20);
            this.lookUpEdit_Vendedor.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainer1.Size = new System.Drawing.Size(958, 536);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_cdn);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(958, 425);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "LISTADO DE RESULTADOS";
            // 
            // gc_cdn
            // 
            this.gc_cdn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_cdn.Location = new System.Drawing.Point(2, 20);
            this.gc_cdn.MainView = this.gridView1;
            this.gc_cdn.Name = "gc_cdn";
            this.gc_cdn.Size = new System.Drawing.Size(954, 403);
            this.gc_cdn.TabIndex = 0;
            this.gc_cdn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_cdn;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frm_cdn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_cdn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Diario de Negocio";
            this.Load += new System.EventHandler(this.frm_cdn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Familia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SubFam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Vendedor.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_cdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpfechaf;
        private System.Windows.Forms.DateTimePicker dtpfechai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_cdn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit LookUpEdit_Familia;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lookUpEdit_SubFam;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lookUpEdit_Vendedor;
        private DevExpress.XtraEditors.SimpleButton btnexportar;
        private DevExpress.XtraEditors.SimpleButton btnprocesar;
    }
}