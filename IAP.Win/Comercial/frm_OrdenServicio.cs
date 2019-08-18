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
using DevExpress.XtraGrid.Views.Grid;


namespace IAP.Win.Comercial
{
    public partial class frm_OrdenServicio : Form
    {
        List<OrdenServicio> _lstordenservicio = new List<OrdenServicio>();
        List<OrdenServicioLinea> _lstordenservicioLinea = new List<OrdenServicioLinea>();
        BL.Comercial eCom = new BL.Comercial();

        #region Procesos

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


            CreateGridColumn(gvwcabecera, "", "FlgCheck", 1, DevExpress.Utils.FormatType.None, "x", true, 25);
            CreateGridColumn(gvwcabecera, "Estado App", "EstadoPedido", 2, DevExpress.Utils.FormatType.Numeric, "d", true, 80);
            CreateGridColumn(gvwcabecera, "IdPedido Android", "IdPedidoAndroid", 3, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Fecha", "fecha", 4, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "cdocu", 5, FormatType.None, "x", false, 60);
            CreateGridColumn(gvwcabecera, "NroDocumento", "ndocu", 6, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Codigo Cliente", "codcli", 7, FormatType.None, "x", false, 40);
            CreateGridColumn(gvwcabecera, "Nombre cliente", "nomcli", 8, FormatType.None, "x", true, 250);
            CreateGridColumn(gvwcabecera, "Ruc", "ruccli", 9, FormatType.None, "x", true, 100);
            
            CreateGridColumn(gvwcabecera, "T Cambio", "tcam", 10, DevExpress.Utils.FormatType.Numeric, "d2", true, 40);
            CreateGridColumn(gvwcabecera, "Total Neto", "tota", 11, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total IGV", "toti", 12, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total", "totn", 13, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "flagEstado", "flag", 14, DevExpress.Utils.FormatType.Numeric, "d", false, 80);
            CreateGridColumn(gvwcabecera, "Estado", "flagnombre", 15, DevExpress.Utils.FormatType.Numeric, "d", true, 80);

            
            CreateGridColumn(gvwcabecera, "Entrega", "DirEnt", 16, DevExpress.Utils.FormatType.Numeric, "d", true, 300);
            CreateGridColumn(gvwcabecera, "CodUsuarioRegistro", "CodUsuarioRegistro", 17, DevExpress.Utils.FormatType.Numeric, "d", true, 80);
            CreateGridColumn(gvwcabecera, "flag_Estadopedido", "flag_Estadopedido", 18, DevExpress.Utils.FormatType.Numeric, "d", false, 80);
            

            gvwcabecera.EndUpdate();

            gvwdetalle.BeginUpdate();

            gvwdetalle.OptionsBehavior.AutoPopulateColumns = false;
            gvwdetalle.OptionsBehavior.ReadOnly = false;
            gvwdetalle.OptionsBehavior.Editable = false;
            gvwdetalle.OptionsView.ColumnAutoWidth = false;

            //Extras
            gvwdetalle.OptionsCustomization.AllowQuickHideColumns = false;
            gvwdetalle.OptionsView.ShowGroupedColumns = true; //Solo se configura en Tipo vista GridView
            gvwdetalle.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            //gvDetalle.OptionsBehavior.AutoExpandAllGroups = true; 
            gvwdetalle.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwdetalle.OptionsView.ShowGroupPanel = false;
            gvwdetalle.OptionsMenu.EnableColumnMenu = false;
            gvwdetalle.OptionsMenu.EnableGroupPanelMenu = false;
            gvwdetalle.OptionsMenu.EnableFooterMenu = false;
            gvwdetalle.OptionsCustomization.AllowFilter = true;
            gvwdetalle.OptionsCustomization.AllowSort = true;

            CreateGridColumn(gvwdetalle, "Codigo", "codf", 1, FormatType.None, "x", true, 150);
            CreateGridColumn(gvwdetalle, "Codi", "codi", 2, FormatType.None, "x", true, 150);
            CreateGridColumn(gvwdetalle, "Descripción", "descr", 3, FormatType.None, "x", true, 200);

            CreateGridColumn(gvwdetalle, "Marca", "marc", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Medida", "umed", 5, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Cantidad", "cant", 6, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "P. Unitario", "preu", 7, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "SubTotal", "tota", 8, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "Total", "totn", 9, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);

            gvwdetalle.EndUpdate();
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
            //if(field== "EstadoPedido" && gv.Name== "gvwcabecera")
            //{
            //    gc.AppearanceCell.BackColor = Color.AliceBlue;
            //}



            if (withField != 0)
                gc.Width = withField;



            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        private void ObtenerOrdenesServicio()
        {
            
            _lstordenservicio = eCom.ObtenerOrdenesServicio(Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue),
                txtdocumento.Text, txtcliente.Text, Global.vUserBaseDatos);
            gccabecera.DataSource = _lstordenservicio;
           
        }

        private void ObtenerOrdenesServicioLinea(string ndocu)
        {

            _lstordenservicioLinea = eCom.ObtenerOrdenServicioLinea(ndocu, Global.vUserBaseDatos);
            gcdetalle.DataSource = _lstordenservicioLinea;

        }
        private void ObtenerOrdenesServicioApiRest()
        {
            Procedimientos_GeneralesBL objPG = new Procedimientos_GeneralesBL();
            string ruta = "http://services.grupoiap.com.pe/api/Cliente/PostObtenerCliente/";

            dynamic pedidoJson = objPG.ObtenerDataApiRest(ruta, "", "");
        }

        
       
       
      
        #endregion


        public frm_OrdenServicio()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicio_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                ObtenerOrdenesServicio();

                List<Cliente> lst = new List<Cliente>();
                lst = eCom.ObtenerClientesOS(Global.vUserBaseDatos);
                lecliente.Properties.DataSource = lst;
                lecliente.Properties.ValueMember = "CodCli";
                lecliente.Properties.DisplayMember = "Nombre";

                mnuestados.DropDownItems[0].Click += new EventHandler(Submenu_SiguienteEstado_Click);
                mnuestados.DropDownItems[2].Click += new EventHandler(Submenu_SiguienteEstado_Click);
                mnuestados.DropDownItems[3].Click += new EventHandler(Submenu_SiguienteEstado_Click);
                mnuestados.DropDownItems[4].Click += new EventHandler(Submenu_SiguienteEstado_Click);
                mnuestados.DropDownItems[5].Click += new EventHandler(Submenu_SiguienteEstado_Click);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void Submenu_SiguienteEstado_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;

                if (gvwcabecera.RowCount == 0) return;
                Int32 IdPedido = Convert.ToInt32(gvwcabecera.GetFocusedRowCellValue("IdPedidoAndroid").ToString() == string.Empty ? "0" :
                    gvwcabecera.GetFocusedRowCellValue("IdPedidoAndroid").ToString());
                BL.Comercial blComercial = new BL.Comercial();
                Int32 flag_Estado = 0;
                //asignar flag numero
                ToolStripItem item = (ToolStripItem)sender;
                
                if(item.Name == "smnusiguienteestado")
                {
                    blComercial.Actualizar_FlagEstadoPedidos(IdPedido, "", Global.vUserBaseDatos, Global.vUserBaseDatosAndroid);
                }
                else
                {
                    switch (item.Name)
                    {
                        case "smnuemitido":
                            {
                                flag_Estado = 0;
                                break;
                            }
                        case "smnuprocesado":
                            {
                                flag_Estado = 1;
                                break;
                            }
                        case "smnudespachado":
                            {
                                flag_Estado = 2;
                                break;
                            }
                        case "smnuentregado":
                            {
                                flag_Estado = 3;
                                break;
                            }

                    }

                    blComercial.Actualizar_FlagEstadoPedidosManual(IdPedido, "", flag_Estado, Global.vUserBaseDatos, Global.vUserBaseDatosAndroid);
                }
                ObtenerOrdenesServicio();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerOrdenesServicio();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void gvwcabecera_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;

                if (gvwcabecera.RowCount == 0) return;
                if (e.Column.FieldName != "FlgCheck") return;

                bool flg = Convert.ToBoolean(gvwcabecera.GetRowCellValue(e.RowHandle, "FlgCheck"));
                gvwcabecera.SetRowCellValue(e.RowHandle, "FlgCheck", !flg);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (gvwcabecera.RowCount == 0 && e.ClickedItem.Name != "mnudescargar")
                    return;

                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gccabecera.MainView;
                if (x.RowCount <= 0 && e.ClickedItem.Name != "mnudescargar") return;

                gccabecera.ContextMenuStrip.Visible = false;
                
                switch (e.ClickedItem.Name)
                {

                    case "mnuasignar":
                        {
                            panelcliente.Visible = true;
                            //List<OrdenServicio> lst = new List<OrdenServicio>();
                            //lst = _lstordenservicio.Where(y => y.FlgCheck == true).ToList();
                        }
                        break;
                    case "mnudescargar":
                        {
                            DescargarPedidosAndroid();
                        }
                        break;
                    case "mnuestados":
                        {

                        }
                        break;
                    
                }
                ObtenerOrdenesServicio();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panelcliente.Visible = false;
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrdenServicio> lst = new List<OrdenServicio>();
                lst = _lstordenservicio.Where(y => y.FlgCheck == true).ToList();
                lst.ForEach(x => x.codcli = lecliente.EditValue.ToString());
                eCom.ActualizarClienteOS(lst, Global.vUserBaseDatos);
                panelcliente.Visible = false;
                MessageBox.Show("Se realizo los cambios correctamente", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerOrdenesServicio();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void DescargarPedidosAndroid()
        {
            try
            {
                BL.Comercial objComercial = new BL.Comercial();
                if (MessageBox.Show("Desea descargar y registrar los pedidos de clientes?", "Utilitario ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("<<<<Descargando y Registrando>>>>"))
                    {
                        objComercial.DescargarRegistrarPedidosAndroid(Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue),
                            Global.vUserBaseDatos, Global.vUserBaseDatosAndroid);
                        ObtenerOrdenesServicio();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void gvwcabecera_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gvwcabecera.RowCount > 0)
                {
                    string cdocu, ndocu;
                    
                    ndocu = gvwcabecera.GetFocusedRowCellValue("ndocu").ToString();
                    ObtenerOrdenesServicioLinea(ndocu);
                }
                else
                {
                    gcdetalle.DataSource = null;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void gvwcabecera_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
        }

        private void gvwcabecera_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (cellsStyles.Contains(e.Column.FieldName))
            //{
            //    e.Appearance.BackColor = Color.LightYellow;
            //    e.Appearance.BackColor2 = Color.LightYellow;


            //}
            //else
            //{
            if(e.Column.FieldName== "EstadoPedido")
            {
                if (e.CellValue.ToString() == "Emitido")
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.ForeColor = Color.MidnightBlue;
                }
                    
                if (e.CellValue.ToString() == "Procesado")
                {
                    e.Appearance.BackColor = Color.LightYellow;
                    e.Appearance.ForeColor = Color.MidnightBlue;
                }
                    
                if (e.CellValue.ToString() == "Despachado")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.ForeColor = Color.MidnightBlue;
                }
                    

            }

            //}
            //GridView view = sender as GridView;
            //if (view == null) return;
            //if (e.RowHandle != view.FocusedRowHandle &&  ((e.RowHandle % 2 == 0 && e.Column.VisibleIndex % 2 == 1) ||
            //   (e.Column.VisibleIndex % 2 == 0 && e.RowHandle % 2 == 1)))
            //    e.Appearance.BackColor = Color.NavajoWhite;
            
        }
    }
}
