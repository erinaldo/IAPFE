using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAP.BL;
using IAP.BE;
using DevExpress.Utils;
using IAP.Win.Clases;
using IAP.Win.Comercial;
using DevExpress.Skins;
using System.Net;

namespace IAP.Win.Comercial
{
    public partial class frm_ArqueoOS : Form
    {
        BL.Comercial BLComercial = new BL.Comercial();
        public frm_ArqueoOS()
        {
            InitializeComponent();
        }
        private void OnFormatGrid()
        {
            gvwcabecera.BeginUpdate();

            gvwcabecera.OptionsBehavior.AutoPopulateColumns = false;
            gvwcabecera.OptionsBehavior.ReadOnly = false;
            gvwcabecera.OptionsBehavior.Editable = false;
            gvwcabecera.OptionsView.ColumnAutoWidth = false;

            //Extras
            gvwcabecera.OptionsCustomization.AllowQuickHideColumns = false;
            gvwcabecera.OptionsView.ShowGroupedColumns = true; //Solo se configura en Tipo vista GridView
            gvwcabecera.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            //gvDetalle.OptionsBehavior.AutoExpandAllGroups = true; 
            gvwcabecera.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwcabecera.OptionsView.ShowGroupPanel = false;
            gvwcabecera.OptionsMenu.EnableColumnMenu = false;
            gvwcabecera.OptionsMenu.EnableGroupPanelMenu = false;
            gvwcabecera.OptionsMenu.EnableFooterMenu = false;
            gvwcabecera.OptionsCustomization.AllowFilter = true;
            gvwcabecera.OptionsCustomization.AllowSort = true;


            //CreateGridColumn(gvwcabecera, "", "FlgCheck", 1, DevExpress.Utils.FormatType.None, "x", true, 25);
            CreateGridColumn(gvwcabecera, "Fecha", "fecha", 1, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "cdocu", 2, FormatType.None, "x", false, 60);
            CreateGridColumn(gvwcabecera, "Numero Documento", "ndocu", 3, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Nombre Cliente", "nomcli", 4, FormatType.None, "x", true, 40);
            CreateGridColumn(gvwcabecera, "RUC", "ruccli", 5, FormatType.None, "x", true, 60);
            CreateGridColumn(gvwcabecera, "codcdv", "codcdv", 6, FormatType.None, "x", false, 100);
            CreateGridColumn(gvwcabecera, "Condicion Venta", "nomcodcdv", 7, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Moneda", "mone", 8, FormatType.None, "x", true, 100);
            
            
            CreateGridColumn(gvwcabecera, "Tipo Cambio", "tcam", 9, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total Neto", "tota", 10, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwcabecera, "Total IGV", "toti", 11, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwcabecera, "Total", "totn", 12, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Estado Arqueo", "flag_arqueado", 13, DevExpress.Utils.FormatType.None, "x", true, 80);
            CreateGridColumn(gvwcabecera, "Fecha Arqueo", "fechaarqueo", 14, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Usuario Arqueo", "usuarioArqueo", 15, FormatType.None, "x", true, 100);




            gvwcabecera.EndUpdate();


            gvwos.BeginUpdate();

            gvwos.OptionsBehavior.AutoPopulateColumns = false;
            gvwos.OptionsBehavior.ReadOnly = false;
            gvwos.OptionsBehavior.Editable = false;
            gvwos.OptionsView.ColumnAutoWidth = false;

            //Extras
            gvwos.OptionsCustomization.AllowQuickHideColumns = false;
            gvwos.OptionsView.ShowGroupedColumns = true; //Solo se configura en Tipo vista GridView
            gvwos.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            //gvDetalle.OptionsBehavior.AutoExpandAllGroups = true; 
            gvwos.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwos.OptionsView.ShowGroupPanel = false;
            gvwos.OptionsMenu.EnableColumnMenu = false;
            gvwos.OptionsMenu.EnableGroupPanelMenu = false;
            gvwos.OptionsMenu.EnableFooterMenu = false;
            gvwos.OptionsCustomization.AllowFilter = true;
            gvwos.OptionsCustomization.AllowSort = true;


            //CreateGridColumn(gvwcabecera, "", "FlgCheck", 1, DevExpress.Utils.FormatType.None, "x", true, 25);
            CreateGridColumn(gvwos, "Fecha", "fecha", 1, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwos, "Tipo", "cdocu", 2, FormatType.None, "x", false, 60);
            CreateGridColumn(gvwos, "Numero Documento", "ndocu", 3, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwos, "Nombre Cliente", "nomcli", 4, FormatType.None, "x", true, 40);
            CreateGridColumn(gvwos, "RUC", "ruccli", 5, FormatType.None, "x", false, 60);
            CreateGridColumn(gvwos, "codcdv", "codcdv", 6, FormatType.None, "x", false, 100);
            CreateGridColumn(gvwos, "Condicion Venta", "nomcodcdv", 7, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwos, "Moneda", "mone", 8, FormatType.None, "x", true, 100);


            CreateGridColumn(gvwos, "Tipo Cambio", "tcam", 9, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwos, "Total Neto", "tota", 10, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwos, "Total IGV", "toti", 11, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwos, "Total", "totn", 12, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwos, "Saldo", "saldo", 13, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwos, "Cancelado", "flag_cancelado", 14, DevExpress.Utils.FormatType.None, "x", true, 80);
            CreateGridColumn(gvwos, "Estado Arqueo", "flag_arqueado", 15, DevExpress.Utils.FormatType.None, "x", true, 80);
            CreateGridColumn(gvwos, "Fecha Arqueo", "fechaarqueo", 16, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwos, "Usuario Arqueo", "usuarioArqueo", 17, FormatType.None, "x", true, 100);




            gvwos.EndUpdate();

        }
        private void CreateGridColumn(DevExpress.XtraGrid.Views.Grid.GridView gv, string caption, string field, int visibleindex, DevExpress.Utils.FormatType formatType, string formatString, bool visible, int withField = 0)
        {
            DevExpress.XtraGrid.Columns.GridColumn gc = gv.Columns.Add();
            gc.Caption = caption;
            gc.FieldName = field;
            gc.VisibleIndex = visibleindex;
            gc.Visible = visible;
            gc.AppearanceHeader.Options.UseTextOptions = true;
            gc.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gc.OptionsColumn.AllowEdit = false;




            if (field == "FlgCheck" && gv.Name == "gvwcabecera")
            {
                gc.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            }

            //if (field== "Flg_Fe" && gv.Name== "gvwcabecera")
            //{
            //    gc.OptionsColumn.AllowEdit = true;
            //    ieEstadoFe.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            //    ieEstadoFe.NullText = " ";
            //    //ieEstadoFe.Images=
            //    gc.ColumnEdit = ieEstadoFe;

            //    //gridView1.Columns["Picture"].ColumnEdit = pictureEdit;
            //}
            //linkPdf

            
            
            if (withField != 0)
                gc.Width = withField;



            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        private void frm_ArqueoOS_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                dtfecha.EditValue = DateTime.Now;
                dtfechacredito.EditValue = DateTime.Now;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_OS_Arqueo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvwcabecera.RowCount==0)
                {
                    MessageBox.Show("No se ha realizado la consulta, primero realize la busqueda de los documentos.","Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Esta seguro de realizar el arqueo de la fecha seleccionada?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Registrando>>>>"))
                    {
                        guardar_OS_Arqueo(true, "01");
                        cargar_OS_Arqueo();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guardar_OS_Arqueo(Boolean estado,string codcdv)
        {
            if(codcdv=="01")
                BLComercial.RegistrarArqueo_OS(Convert.ToDateTime(dtfecha.EditValue), estado, Dns.GetHostName(), codcdv, Convert.ToDouble(txttotalsoles.Text), Convert.ToDouble(txttotaldolares.Text),Global.vUserBaseDatos);
            else
                BLComercial.RegistrarArqueo_OS(Convert.ToDateTime(dtfechacredito.EditValue), estado, Dns.GetHostName(), "02", Convert.ToDouble(txttotalsolescancelado_credito.Text.Replace("S/","")), Convert.ToDouble(txttotaldolarescancelado_credito.Text.Replace("$", "")), Global.vUserBaseDatos);
        }
        
        private void cargar_OS_Arqueo()
        {
            txttotalsoles.Text = string.Empty;
            txttotaldolares.Text = string.Empty;
            List<OrdenServicio> lst = new List<OrdenServicio>();
            lst = BLComercial.ObtenerArqueo_OS(Convert.ToDateTime(dtfecha.EditValue),"01", Global.vUserBaseDatos);
            gccabecera.DataSource = lst;

            double soles = Math.Round(lst.Where(x => x.mone == "S").Sum(x => x.totn),2);
            double dolares = Math.Round(lst.Where(x => x.mone == "D").Sum(x => x.totn),2);

            txttotalsoles.Text = soles.ToString();
            txttotaldolares.Text = dolares.ToString();
        }

        private void cargar_OS_ArqueoCredito()
        {
            txttotalsoles_Credito.Text = string.Empty;
            txttotaldolares_credito.Text = string.Empty;
            List<OrdenServicio> lst = new List<OrdenServicio>();
            lst = BLComercial.ObtenerArqueo_OS(Convert.ToDateTime(dtfechacredito.EditValue),"02", Global.vUserBaseDatos);
            gcos.DataSource = lst;

            double soles = Math.Round(lst.Where(x => x.mone == "S").Sum(x => x.totn), 2);
            double dolares = Math.Round(lst.Where(x => x.mone == "D").Sum(x => x.totn), 2);

            txttotalsoles_Credito.Text = soles.ToString();
            txttotaldolares_credito.Text = dolares.ToString();

            soles = Math.Round(lst.Where(x => x.mone == "S").Sum(x => x.totn), 2) -
                Math.Round(lst.Where(x => x.mone == "S").Sum(x => x.saldo), 2);
            dolares = Math.Round(lst.Where(x => x.mone == "D").Sum(x => x.totn), 2)-
                Math.Round(lst.Where(x => x.mone == "D").Sum(x => x.saldo), 2);

            txttotalsolescancelado_credito.Text = soles.ToString();
            txttotaldolarescancelado_credito.Text = dolares.ToString();

        }

        private void btnbuscarCredito_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_OS_ArqueoCredito();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardarCredito_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvwos.RowCount == 0)
                {
                    MessageBox.Show("No se ha realizado la consulta, primero realize la busqueda de los documentos.", "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Esta seguro de realizar el arqueo de la fecha seleccionada?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Registrando>>>>"))
                    {
                        guardar_OS_Arqueo(true, "02");
                        cargar_OS_ArqueoCredito();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (gvwos.RowCount == 0)
                    return;

                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gcos.MainView;
                if (x.RowCount <= 0) return;
                gcos.ContextMenuStrip.Visible = false;


                switch (e.ClickedItem.Name)
                {

                    case "mnuabonaros":
                        {
                            bool cancelado= Convert.ToBoolean(gvwos.GetFocusedRowCellValue("flag_cancelado").ToString().Trim());
                            if(cancelado)
                            {
                                MessageBox.Show("El documento seleccionado ya esta cancelado", "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            panel_abono.Visible = true;
                            txtcdocu_credito.Text= gvwos.GetFocusedRowCellValue("cdocu").ToString().Trim();
                            txtcliente_credito.Text = gvwos.GetFocusedRowCellValue("nomcli").ToString().Trim();
                            txtdocumento_credito.Text = gvwos.GetFocusedRowCellValue("ndocu").ToString().Trim();
                            txttotaldocumento_credito.Text = gvwos.GetFocusedRowCellValue("saldo").ToString();
                            txtabonodocumento_credito.Text = gvwos.GetFocusedRowCellValue("saldo").ToString();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancelarabono_Click(object sender, EventArgs e)
        {
            LimpiarAbono();
            panel_abono.Visible = false;
        }
        private void LimpiarAbono()
        {
            txtcdocu_credito.Text = string.Empty;
            txtcliente_credito.Text = string.Empty;
            txtdocumento_credito.Text = string.Empty;
            txttotaldocumento_credito.Text = string.Empty;
            txtabonodocumento_credito.Text = string.Empty;
        }

        private void btnguardarabono_Click(object sender, EventArgs e)
        {
            try
            {
                if((txtabonodocumento_credito.Text==string.Empty ? 0 : Convert.ToDouble(txtabonodocumento_credito.Text))==0)
                {
                    MessageBox.Show("El abono del documento tiene que ser superior a 0.", "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double saldo = Convert.ToDouble(txttotaldocumento_credito.Text);
                double abono = Convert.ToDouble(txtabonodocumento_credito.Text);

                if (abono > saldo)
                {
                    MessageBox.Show("El abono no puede ser superior al saldo", "Utilitario ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GuardarAbono();
                panel_abono.Visible = false;
                LimpiarAbono();
                cargar_OS_ArqueoCredito();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarAbono()
        {
            BLComercial.RegistrarAbono_OS(txtcdocu_credito.Text, txtdocumento_credito.Text,Convert.ToDouble(txtabonodocumento_credito.Text), Global.vUserBaseDatos);
            
        }
    }
}
