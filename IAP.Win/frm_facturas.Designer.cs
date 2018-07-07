namespace IAP.Win
{
    partial class frm_facturas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_facturas));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp2 = new DevExpress.XtraTab.XtraTabPage();
            this.tp1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcdetalle = new DevExpress.XtraGrid.GridControl();
            this.gvwdetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gccabecera = new DevExpress.XtraGrid.GridControl();
            this.gvwcabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtdocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtcliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechafinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtfechainicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1066, 619);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp1,
            this.tp2});
            // 
            // tp2
            // 
            this.tp2.Name = "tp2";
            this.tp2.Size = new System.Drawing.Size(1060, 591);
            this.tp2.Text = "Procesos";
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.panelControl2);
            this.tp1.Controls.Add(this.panelControl1);
            this.tp1.Name = "tp1";
            this.tp1.Size = new System.Drawing.Size(1060, 591);
            this.tp1.Text = "Consultas";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcdetalle);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.gccabecera);
            this.panelControl2.Location = new System.Drawing.Point(3, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1054, 531);
            this.panelControl2.TabIndex = 1;
            // 
            // gcdetalle
            // 
            this.gcdetalle.Location = new System.Drawing.Point(5, 268);
            this.gcdetalle.MainView = this.gvwdetalle;
            this.gcdetalle.Name = "gcdetalle";
            this.gcdetalle.Size = new System.Drawing.Size(1044, 259);
            this.gcdetalle.TabIndex = 2;
            this.gcdetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwdetalle});
            // 
            // gvwdetalle
            // 
            this.gvwdetalle.GridControl = this.gcdetalle;
            this.gvwdetalle.Name = "gvwdetalle";
            this.gvwdetalle.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 250);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Detalle";
            // 
            // gccabecera
            // 
            this.gccabecera.Location = new System.Drawing.Point(5, 5);
            this.gccabecera.MainView = this.gvwcabecera;
            this.gccabecera.Name = "gccabecera";
            this.gccabecera.Size = new System.Drawing.Size(1044, 239);
            this.gccabecera.TabIndex = 0;
            this.gccabecera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwcabecera});
            // 
            // gvwcabecera
            // 
            this.gvwcabecera.GridControl = this.gccabecera;
            this.gvwcabecera.Name = "gvwcabecera";
            this.gvwcabecera.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnbuscar);
            this.panelControl1.Controls.Add(this.txtdocumento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtcliente);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtfechafinal);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtfechainicial);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1054, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(848, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 34);
            this.btnbuscar.TabIndex = 8;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(732, 9);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(95, 20);
            this.txtdocumento.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(672, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Documento";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(440, 9);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(215, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(401, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cliente";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.EditValue = null;
            this.dtfechafinal.Location = new System.Drawing.Point(270, 9);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechafinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechafinal.Size = new System.Drawing.Size(108, 20);
            this.dtfechafinal.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(210, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha Final";
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.EditValue = null;
            this.dtfechainicial.Location = new System.Drawing.Point(86, 10);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechainicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtfechainicial.Size = new System.Drawing.Size(108, 20);
            this.dtfechainicial.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha Inicial";
            // 
            // frm_facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 619);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frm_facturas";
            this.Text = "frm_facturas";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp2;
        private DevExpress.XtraTab.XtraTabPage tp1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcdetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwdetalle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gccabecera;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwcabecera;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit txtdocumento;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtcliente;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtfechafinal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtfechainicial;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}