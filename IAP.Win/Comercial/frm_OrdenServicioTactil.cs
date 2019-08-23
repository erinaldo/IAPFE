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
    public partial class frm_OrdenServicioTactil : Form
    {
        BindingList<Operario> _lstOperarios = new BindingList<Operario>();
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leOperarios = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
        List<OrdenServicio> _lstordenservicio = new List<OrdenServicio>();
        BindingList<OrdenServicioLinea> _lstordenservicioLinea = new BindingList<OrdenServicioLinea>();
        BL.Comercial eCom = new BL.Comercial();
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit teCodi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();

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
            CreateGridColumn(gvwcabecera, "Ruc", "ruccli", 9, FormatType.None, "x", false, 100);
            
            CreateGridColumn(gvwcabecera, "T Cambio", "tcam", 10, DevExpress.Utils.FormatType.Numeric, "d2", false, 40);
            CreateGridColumn(gvwcabecera, "Total Neto", "tota", 11, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwcabecera, "Total IGV", "toti", 12, DevExpress.Utils.FormatType.Numeric, "d2", false, 80);
            CreateGridColumn(gvwcabecera, "Total", "totn", 13, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "flagEstado", "flag", 14, DevExpress.Utils.FormatType.Numeric, "d", false, 80);
            CreateGridColumn(gvwcabecera, "Estado", "flagnombre", 15, DevExpress.Utils.FormatType.Numeric, "d", true, 80);

            
            CreateGridColumn(gvwcabecera, "Entrega", "DirEnt", 16, DevExpress.Utils.FormatType.Numeric, "d", false, 300);
            CreateGridColumn(gvwcabecera, "CodUsuarioRegistro", "CodUsuarioRegistro", 17, DevExpress.Utils.FormatType.Numeric, "d", false, 80);
            CreateGridColumn(gvwcabecera, "flag_Estadopedido", "flag_Estadopedido", 18, DevExpress.Utils.FormatType.Numeric, "d", false, 80);
            


            gvwcabecera.EndUpdate();

            gvwdetalle.BeginUpdate();

            gvwdetalle.OptionsBehavior.AutoPopulateColumns = false;
            gvwdetalle.OptionsBehavior.ReadOnly = false;
            gvwdetalle.OptionsBehavior.Editable = true;
            gvwdetalle.OptionsView.ColumnAutoWidth = false;

            //Extras
            gvwdetalle.OptionsCustomization.AllowQuickHideColumns = false;
            gvwdetalle.OptionsView.ShowGroupedColumns = true; //Solo se configura en Tipo vista GridView
            gvwdetalle.OptionsBehavior.AllowFixedGroups = DefaultBoolean.True;
            //gvDetalle.OptionsBehavior.AutoExpandAllGroups = true; 
            gvwdetalle.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwdetalle.OptionsView.ShowGroupPanel = false;
            gvwdetalle.OptionsMenu.EnableColumnMenu = false;
            gvwdetalle.OptionsMenu.EnableGroupPanelMenu = false;
            gvwdetalle.OptionsMenu.EnableFooterMenu = false;
            gvwdetalle.OptionsCustomization.AllowFilter = false;
            gvwdetalle.OptionsCustomization.AllowSort = false;
            //Agregar Items Configuracion
            //gvwdetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            //
            gvwdetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            gvwdetalle.OptionsView.ShowFooter = true;

            CreateGridColumn(gvwdetalle, "Codigo", "codf", 1, FormatType.None, "x", true, 150);
            CreateGridColumn(gvwdetalle, "Codi", "codi", 2, FormatType.None, "x", true, 150);
            CreateGridColumn(gvwdetalle, "Descripción", "descr", 3, FormatType.None, "x", true, 200);

            CreateGridColumn(gvwdetalle, "Marca", "marc", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Medida", "umed", 5, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Cantidad", "cant", 6, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "P. Unitario", "preu", 7, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "SubTotal", "tota", 8, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);
            CreateGridColumn(gvwdetalle, "Total", "totn", 9, DevExpress.Utils.FormatType.Numeric, "d3", true, 80);

            CreateGridColumn(gvwdetalle, "Cod_Operario", "Cod_Operario", 10, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "FechaInicioServicio", "FechaInicioServicio", 11, FormatType.DateTime, "dd/MM/yyyy HH:mm", true, 100);
            CreateGridColumn(gvwdetalle, "FechaFinServicio", "FechaFinServicio", 12, FormatType.DateTime, "dd/MM/yyyy HH:mm", true, 100);

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
            if (gv.Name == "gvwdetalle" && field == "Cod_Operario")
            {
                gc.OptionsColumn.AllowEdit = true;
                leOperarios.DisplayMember = "NombreOperario";
                leOperarios.ValueMember = "Cod_Operario";
                leOperarios.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                gc.ColumnEdit = leOperarios;
            }
            //if (field == "codi" && gv.Name == "gvwdetalle")
            //{
            //    gc.OptionsColumn.AllowEdit = true;
            //    gc.AppearanceCell.BackColor = Color.AliceBlue;
                
            //    teCodi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //    teCodi.Mask.EditMask = "###,###,###0.00;";
            //    gc.ColumnEdit = teCodi;
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
            
            _lstordenservicio = eCom.ObtenerOrdenesServicio_Operario(Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue),
                string.Empty, string.Empty,"0", Global.vUserBaseDatos);
            gccabecera.DataSource = _lstordenservicio;
           
        }
        private void ObtenerOperarios()
        {
            _lstOperarios = new BindingList<Operario> (eCom.ObtenerOperarios(Global.vUserBaseDatos));
            leOperarios.DataSource = _lstOperarios;
        }

        private void ObtenerOrdenesServicioLinea(string ndocu)
        {

            _lstordenservicioLinea = new BindingList<OrdenServicioLinea> (eCom.ObtenerOrdenServicioLinea(ndocu, Global.vUserBaseDatos));
            gcdetalle.DataSource = _lstordenservicioLinea;

        }
        private void ObtenerOrdenesServicioApiRest()
        {
            Procedimientos_GeneralesBL objPG = new Procedimientos_GeneralesBL();
            string ruta = "http://services.grupoiap.com.pe/api/Cliente/PostObtenerCliente/";

            dynamic pedidoJson = objPG.ObtenerDataApiRest(ruta, "", "");
        }

        
       
       
      
        #endregion


        public frm_OrdenServicioTactil()
        {
            InitializeComponent();
            leOperarios.EditValueChanged += leOperarios_EditValueChanged;
        }

        private void frm_OrdenServicioTactil_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                _lstordenservicioLinea.AllowEdit = true;
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                ObtenerOrdenesServicio();
                ObtenerOperarios();
                
                
                


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
        private void leOperarios_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //gvCapaDetalle.SetRowCellValue(gvCapaDetalle.FocusedRowHandle, gvCapaDetalle.Columns["CodTecnico"], null);
                //gvCapaDetalle.SetRowCellValue(gvCapaDetalle.FocusedRowHandle, gvCapaDetalle.Columns["Tipo"], null);
                //gvCapaDetalle.SetRowCellValue(gvCapaDetalle.FocusedRowHandle, gvCapaDetalle.Columns["ItemId"], 0);
                
                
                gcdetalle.RefreshDataSource();
            }
            catch (Exception err)
            {
               // MensajeError(err);
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

        private void mnuMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (gvwcabecera.RowCount == 0)
                    return;

                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gccabecera.MainView;
                if (x.RowCount <= 0 ) return;

                gccabecera.ContextMenuStrip.Visible = false;

                switch (e.ClickedItem.Name)
                {

                    case "mnuGuardar":
                        {
                            if(MessageBox.Show("Desea guardar la Orden de Servicio con los operarios asignados?","Utilitario",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                            {
                                GuardarOS();
                            }
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
        private void GuardarOS()
        {
            string ndocu = gvwcabecera.GetFocusedRowCellValue("ndocu").ToString();
            BindingList<OrdenServicioLinea> lst = new BindingList<OrdenServicioLinea>();
            lst = _lstordenservicioLinea;
        }
    }
}
