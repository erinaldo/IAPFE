﻿namespace IAP.Win.Comercial
{
    partial class frm_OrdenServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrdenServicio));
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
            this.gccabecera = new DevExpress.XtraGrid.GridControl();
            this.gvwcabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lecliente = new DevExpress.XtraEditors.LookUpEdit();
            this.panelcliente = new DevExpress.XtraEditors.PanelControl();
            this.btnasignar = new DevExpress.XtraEditors.SimpleButton();
            this.btncancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuasignar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelcliente)).BeginInit();
            this.panelcliente.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnbuscar);
            this.panelControl1.Controls.Add(this.txtdocumento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtcliente);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtfechafinal);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dtfechainicial);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(893, 51);
            this.panelControl1.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(833, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 34);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(747, 10);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(72, 20);
            this.txtdocumento.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(687, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Documento";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(400, 10);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(279, 20);
            this.txtcliente.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(361, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Cliente";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.EditValue = null;
            this.dtfechafinal.Location = new System.Drawing.Point(242, 10);
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
            this.labelControl2.Location = new System.Drawing.Point(201, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "F. Final";
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.EditValue = null;
            this.dtfechainicial.Location = new System.Drawing.Point(67, 10);
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
            this.labelControl1.Location = new System.Drawing.Point(7, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "F. Inicial";
            // 
            // gccabecera
            // 
            this.gccabecera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gccabecera.ContextMenuStrip = this.menu;
            this.gccabecera.Location = new System.Drawing.Point(2, 59);
            this.gccabecera.MainView = this.gvwcabecera;
            this.gccabecera.Name = "gccabecera";
            this.gccabecera.Size = new System.Drawing.Size(893, 393);
            this.gccabecera.TabIndex = 8;
            this.gccabecera.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwcabecera});
            // 
            // gvwcabecera
            // 
            this.gvwcabecera.GridControl = this.gccabecera;
            this.gvwcabecera.Name = "gvwcabecera";
            this.gvwcabecera.OptionsView.ShowGroupPanel = false;
            this.gvwcabecera.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvwcabecera_RowCellClick);
            // 
            // lecliente
            // 
            this.lecliente.Location = new System.Drawing.Point(5, 30);
            this.lecliente.Name = "lecliente";
            this.lecliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lecliente.Properties.PopupFormMinSize = new System.Drawing.Size(300, 0);
            this.lecliente.Properties.PopupWidth = 400;
            this.lecliente.Size = new System.Drawing.Size(279, 20);
            this.lecliente.TabIndex = 9;
            // 
            // panelcliente
            // 
            this.panelcliente.Controls.Add(this.btnasignar);
            this.panelcliente.Controls.Add(this.btncancelar);
            this.panelcliente.Controls.Add(this.labelControl5);
            this.panelcliente.Controls.Add(this.lecliente);
            this.panelcliente.Location = new System.Drawing.Point(282, 145);
            this.panelcliente.Name = "panelcliente";
            this.panelcliente.Size = new System.Drawing.Size(294, 61);
            this.panelcliente.TabIndex = 9;
            this.panelcliente.Visible = false;
            // 
            // btnasignar
            // 
            this.btnasignar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnasignar.ImageOptions.Image")));
            this.btnasignar.Location = new System.Drawing.Point(227, 8);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(25, 20);
            this.btnasignar.TabIndex = 11;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.ImageOptions.Image")));
            this.btncancelar.Location = new System.Drawing.Point(258, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(26, 20);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Asignar Cliente";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuasignar});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(166, 26);
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // mnuasignar
            // 
            this.mnuasignar.Image = global::IAP.Win.Properties.Resources.FindCustomers_16x16;
            this.mnuasignar.Name = "mnuasignar";
            this.mnuasignar.Size = new System.Drawing.Size(165, 22);
            this.mnuasignar.Text = "Reasignar Cliente";
            // 
            // frm_OrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.panelcliente);
            this.Controls.Add(this.gccabecera);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_OrdenServicio";
            this.Text = "Modulo de Ordenes de Servicio";
            this.Load += new System.EventHandler(this.frm_OrdenServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechafinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtfechainicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gccabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwcabecera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelcliente)).EndInit();
            this.panelcliente.ResumeLayout(false);
            this.panelcliente.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl gccabecera;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwcabecera;
        private DevExpress.XtraEditors.LookUpEdit lecliente;
        private DevExpress.XtraEditors.PanelControl panelcliente;
        private DevExpress.XtraEditors.SimpleButton btnasignar;
        private DevExpress.XtraEditors.SimpleButton btncancelar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuasignar;
    }
}