namespace IAP.Win
{
    partial class frm_ws_android_modificar_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ws_android_modificar_pedido));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbcondicion = new System.Windows.Forms.ComboBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.dtpfechaentrega = new System.Windows.Forms.DateTimePicker();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtdireccion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtcliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtfecha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtrucdni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtdocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcdetallepedido = new DevExpress.XtraGrid.GridControl();
            this.gvw_detallepedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_recalcular = new DevExpress.XtraEditors.SimpleButton();
            this.btncancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnguardar = new DevExpress.XtraEditors.SimpleButton();
            this.txttotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtigv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtsubtotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrucdni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetallepedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_detallepedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtigv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubtotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbcondicion);
            this.groupControl1.Controls.Add(this.cmbestado);
            this.groupControl1.Controls.Add(this.dtpfechaentrega);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtdireccion);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtcliente);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtfecha);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtrucdni);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtdocumento);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(761, 123);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pedido";
            // 
            // cmbcondicion
            // 
            this.cmbcondicion.FormattingEnabled = true;
            this.cmbcondicion.Items.AddRange(new object[] {
            "Contado",
            "Credito",
            "Credito 5 Dias",
            "Credito 10 Dias",
            "Credito 15 Dias",
            "Credito 20 Dias"});
            this.cmbcondicion.Location = new System.Drawing.Point(628, 92);
            this.cmbcondicion.Name = "cmbcondicion";
            this.cmbcondicion.Size = new System.Drawing.Size(121, 21);
            this.cmbcondicion.TabIndex = 18;
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Emitido",
            "Aprobado",
            "Enviado",
            "Cancelado"});
            this.cmbestado.Location = new System.Drawing.Point(628, 68);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 17;
            // 
            // dtpfechaentrega
            // 
            this.dtpfechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaentrega.Location = new System.Drawing.Point(353, 22);
            this.dtpfechaentrega.Name = "dtpfechaentrega";
            this.dtpfechaentrega.Size = new System.Drawing.Size(121, 20);
            this.dtpfechaentrega.TabIndex = 16;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(277, 24);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(70, 13);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Fecha Entrega";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(550, 96);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Condición";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(106, 92);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtdireccion.Properties.Appearance.Options.UseBackColor = true;
            this.txtdireccion.Size = new System.Drawing.Size(368, 20);
            this.txtdireccion.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Dirección";
            // 
            // txtcliente
            // 
            this.txtcliente.Enabled = false;
            this.txtcliente.Location = new System.Drawing.Point(106, 69);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtcliente.Properties.Appearance.Options.UseBackColor = true;
            this.txtcliente.Size = new System.Drawing.Size(368, 20);
            this.txtcliente.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 74);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Cliente";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(106, 22);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtfecha.Properties.Appearance.Options.UseBackColor = true;
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Fecha";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(563, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Estado";
            // 
            // txtrucdni
            // 
            this.txtrucdni.Enabled = false;
            this.txtrucdni.Location = new System.Drawing.Point(106, 46);
            this.txtrucdni.Name = "txtrucdni";
            this.txtrucdni.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtrucdni.Properties.Appearance.Options.UseBackColor = true;
            this.txtrucdni.Size = new System.Drawing.Size(100, 20);
            this.txtrucdni.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "RUC/DNI";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Enabled = false;
            this.txtdocumento.Location = new System.Drawing.Point(628, 24);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtdocumento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtdocumento.Properties.Appearance.Options.UseBackColor = true;
            this.txtdocumento.Properties.Appearance.Options.UseFont = true;
            this.txtdocumento.Size = new System.Drawing.Size(121, 20);
            this.txtdocumento.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(542, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Documento";
            // 
            // gcdetallepedido
            // 
            this.gcdetallepedido.Location = new System.Drawing.Point(0, 128);
            this.gcdetallepedido.MainView = this.gvw_detallepedido;
            this.gcdetallepedido.Name = "gcdetallepedido";
            this.gcdetallepedido.Size = new System.Drawing.Size(761, 268);
            this.gcdetallepedido.TabIndex = 1;
            this.gcdetallepedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_detallepedido});
            // 
            // gvw_detallepedido
            // 
            this.gvw_detallepedido.GridControl = this.gcdetallepedido;
            this.gvw_detallepedido.Name = "gvw_detallepedido";
            this.gvw_detallepedido.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_recalcular);
            this.groupControl2.Controls.Add(this.btncancelar);
            this.groupControl2.Controls.Add(this.btnguardar);
            this.groupControl2.Controls.Add(this.txttotal);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txtigv);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtsubtotal);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Location = new System.Drawing.Point(0, 402);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(761, 75);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Totales";
            // 
            // btn_recalcular
            // 
            this.btn_recalcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_recalcular.Image")));
            this.btn_recalcular.Location = new System.Drawing.Point(615, 31);
            this.btn_recalcular.Name = "btn_recalcular";
            this.btn_recalcular.Size = new System.Drawing.Size(42, 36);
            this.btn_recalcular.TabIndex = 20;
            this.btn_recalcular.Click += new System.EventHandler(this.btn_recalcular_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(714, 31);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(42, 36);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(663, 31);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(42, 36);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(425, 38);
            this.txttotal.Name = "txttotal";
            this.txttotal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txttotal.Properties.Appearance.Options.UseBackColor = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 16;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(391, 41);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Total";
            // 
            // txtigv
            // 
            this.txtigv.Enabled = false;
            this.txtigv.Location = new System.Drawing.Point(263, 38);
            this.txtigv.Name = "txtigv";
            this.txtigv.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtigv.Properties.Appearance.Options.UseBackColor = true;
            this.txtigv.Size = new System.Drawing.Size(100, 20);
            this.txtigv.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(229, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(17, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "IGV";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(106, 38);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtsubtotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Sub-Total";
            // 
            // frm_ws_android_modificar_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 479);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gcdetallepedido);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_ws_android_modificar_pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ws_android_modificar_pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrucdni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdetallepedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_detallepedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtigv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsubtotal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpfechaentrega;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtdireccion;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtcliente;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtfecha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtrucdni;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtdocumento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcdetallepedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_detallepedido;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btncancelar;
        private DevExpress.XtraEditors.SimpleButton btnguardar;
        private DevExpress.XtraEditors.TextEdit txttotal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtigv;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtsubtotal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cmbcondicion;
        private System.Windows.Forms.ComboBox cmbestado;
        private DevExpress.XtraEditors.SimpleButton btn_recalcular;
    }
}