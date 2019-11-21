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
using IAP.Win.Mensajeria;

namespace IAP.Win.Comercial
{
    public partial class frm_guiasRemision : Form
    {
        BL.BFacturacionElectronica Bfe = new BL.BFacturacionElectronica();
        List<GuiaVenta_Sunat> _lstcabecera = new List<GuiaVenta_Sunat>();

        private void OnFormatGrid()
        {


            Boolean visibleTelesoluciones = true;
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
            CreateGridColumn(gvwcabecera, "Fecha", "Fecha", 2, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "Cdocu", 3, FormatType.None, "x", true, 60);
            CreateGridColumn(gvwcabecera, "NroDocumento", "Ndocu", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Cliente", "Nomcli", 5, FormatType.None, "x", true, 40);
            CreateGridColumn(gvwcabecera, "Ruc", "Ruccli", 6, FormatType.None, "x", true, 60);
            CreateGridColumn(gvwcabecera, "Codigo Ref.", "Crefe", 7, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Numero Ref.", "Nrefe", 8, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Motivo Anulacion", "MotAnu", 9, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Total", "Tota", 10, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Total IGV", "Toti", 11, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Total Neto", "Totn", 12, FormatType.None, "x", true, 100);
            
            
            //if (Global.vDatosProveedor.IdEmpresa == "1")//NUBEFACT
            //{
            //    visibleNubefact = true;
            //    visibleTelesoluciones = false;
            //}
            //else//2 telesoluciones
            //{
            //    visibleNubefact = false;
            //    visibleTelesoluciones = true;
            //}

            CreateGridColumn(gvwcabecera, "FlagEnviadoSunat", "Telesoluciones_FlagEnviadoSunat", 14, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "F. Emision Cliente", "Telesoluciones_FechaEmisionCliente", 15, FormatType.DateTime, "d/M/yyyy", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "F. Emision Sunat", "Telesoluciones_FechaEmisionSunat", 16, FormatType.DateTime, "d/M/yyyy", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Codigo Sunat", "Telesoluciones_CodigoComprobanteSunat", 17, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "IdGuiaRemitente", "Telesoluciones_IdGuiaRemitente", 18, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Serie", "Telesoluciones_Serie", 19, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Numero", "Telesoluciones_Numero", 20, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Emitido", "Telesoluciones_Emitido", 21, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Baja", "Telesoluciones_Baja", 22, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "DigestValue", "Telesoluciones_DigestValue", 23, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Firma", "Telesoluciones_SignatureValue", 24, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "IdConstancia", "Telesoluciones_IdConstancia", 25, FormatType.None, "x", visibleTelesoluciones, 100);
            
            



            gvwcabecera.EndUpdate();



            //detalle
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


            CreateGridColumn(gvwdetalle, "Codigo", "Codi", 1, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwdetalle, "CodigoUsuario", "Codf", 2, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Marca", "Marc", 3, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Descripcion", "Descr", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Unidad Medida", "Umed", 5, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Cantidad", "Cantidad", 6, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwdetalle, "Precio Unit", "Preu", 7, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwdetalle, "Total", "Totn", 8, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);


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

        public frm_guiasRemision()
        {
            InitializeComponent();
        }

        private void CargarGuias_Remision()
        {
            
            Int32 enviadosunat = Convert.ToInt32(rbtnenviado.EditValue.ToString());
            Int32 anulado = Convert.ToBoolean(chkanulados.EditValue) == true ? 1 : 0;

            _lstcabecera = Bfe.ObtenerDocumentosGuiasRemision(Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue), enviadosunat, anulado, Global.vUserBaseDatos);
                

            //lstcabcecera.ForEach(z => z.Flg_Fe = 1);
            gccabecera.DataSource = _lstcabecera;

            if (!_lstcabecera.Any())
            
                gcdetalle.DataSource = null;
            
        }

        private void CargarGuiasLinea_Remision(string ndocu)
        {
            List<GuiaVentaLinea_Sunat> lst = new List<GuiaVentaLinea_Sunat>();
            lst = Bfe.ObtenerDocumentosGuiasRemisionLinea(ndocu, Global.vUserBaseDatos);
            gcdetalle.DataSource = lst;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;
                using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando>>>>"))
                {
                    CargarGuias_Remision();
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

        private void frm_guiasRemision_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                this.rbtnenviado.SelectedIndex = 0;
                //                menu.Items.Add()
                

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

        private void gvwcabecera_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {
                if (gvwcabecera.RowCount > 0)
                {
                    string cdocu, ndocu;
                    cdocu = gvwcabecera.GetFocusedRowCellValue("Cdocu").ToString();
                    ndocu = gvwcabecera.GetFocusedRowCellValue("Ndocu").ToString();
                    CargarGuiasLinea_Remision(ndocu);
                }
                else
                {
                    gcdetalle.DataSource = null;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (gvwcabecera.RowCount == 0)
                    return;

                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gccabecera.MainView;
                if (x.RowCount <= 0) return;
                gccabecera.ContextMenuStrip.Visible = false;


                switch (e.ClickedItem.Name)
                {

                    case "mnuMarcarTodo":
                        {

                            _lstcabecera.ForEach(y => y.FlgCheck = true);
                            gccabecera.RefreshDataSource();
                        }
                        break;
                    case "mnuQuitarTodo":
                        {
                            _lstcabecera.ForEach(y => y.FlgCheck = false);
                            gccabecera.RefreshDataSource();
                        }
                        break;
                    case "mnuEnviarGuiar":
                        {
                            if (_lstcabecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro para poder enviar a Sunat", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            SunatEnviarGuiasRemision();
                            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando>>>>"))
                            {
                                CargarGuias_Remision();
                            }

                            break;
                        }
                }
            }
            catch
            {

            }
        }

        private bool ValidarSunatGuias(List<GuiaVenta_Sunat> lista)
        {
            if (lista.Where(x => x.Flag.Trim() == "*").Count() > 0)
            {
                MessageBox.Show("No esta permitido enviar documentos anulados, verifique su seleccion de documentos", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (lista.Where(x => x.Telesoluciones_FlagEnviadoSunat).Count() > 0) //verificacion de documentos enviados a sunat
            {
                MessageBox.Show("Tiene seleccionado documentos ya enviados a Sunat, verifique su seleccion de documentos", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void SunatEnviarGuiasRemision()
        {

            if (MessageBox.Show("Desea enviar los documentos a Sunat?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<GuiaVenta_Sunat> lst = _lstcabecera.Where(x => x.FlgCheck).OrderBy(x => x.Cdocu + x.Ndocu).ToList();
                
                if (ValidarSunatGuias(lst))
                {
                    //NUBEFACT
                    if (Global.vDatosProveedor.IdEmpresa == "1")
                    {
                        MessageBox.Show("El modulo solo esta desarrollado para Perfiles y Aceros LC", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        //Bfe.SunatEnviarDocumentosFBN_V2(lst, Global.vDatosProveedor.Ruta, Global.vDatosProveedor.Token, Global.vUserBaseDatos);
                    }
                    else //TELESOLUCIONES
                    {
                        
                        string telsol_serie = "";
                        string telsol_numero = "";

                        try
                        {
                            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Enviando Documentos>>>>"))
                            {
                                Bfe.TelesolucionesEnviarGuia(lst, string.Empty, Global.vToken, Global.vUserBaseDatos, ref telsol_serie, ref telsol_numero,
                                    Global.vApiTELE_EmisionGuiaRemision, Global.vApiTELE_ConstanciaGuia, Global.vTelemovilAK, Global.vTelemovilSK);
                            }

                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            if (lst.Count == 1)
                            {
                                if (telsol_serie != "")
                                {
                                    //MostrarPDF_Telesoluciones(telsol_serie, telsol_numero);
                                    MessageBox.Show("Se envio los documentos seleccionados", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se logro enviar el documento seleccionado.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }


                    }



                    _lstcabecera.ForEach(x => x.FlgCheck = false);
                    gccabecera.RefreshDataSource();
                }
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
    }
}
