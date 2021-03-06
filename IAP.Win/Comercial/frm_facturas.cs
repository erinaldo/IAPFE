﻿using System;
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

namespace IAP.Win
{
    public partial class frm_facturas : Form
    {
        BL.BFacturacionElectronica Bfe = new BL.BFacturacionElectronica();
        List<Documentov> lstcabcecera = new List<Documentov>();
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit ieEstadoFe = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit linkPdf = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit linkPdfAnulado = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();

        private string[] cellsStyles = new string[] { "Serie", "Numero", "Enlace", "AceptadaPorSunat", "SunatDescription", "SunatNote", "SunatResponseCode", "SunatSoapError", "EnlaceDelPdf", "EnlaceDelPdfAnulado", "EnlaceDelCdr", "EnlaceDelXml", "Tipo_de_comprobante", "Motivo_Anulacion" };

        bool visibleNubefact;
        bool visibleTelesoluciones;

        public frm_facturas()
        {
            InitializeComponent();
        }
        private void MensajeError(Exception err)
        {
            MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;
                using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando>>>>"))
                {
                    CargarDocumentosv();
                }
                    
            }
            catch (Exception err)
            {
                MensajeError(err);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

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
            CreateGridColumn(gvwcabecera, "Fecha", "Fecha", 2, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "Cdocu", 3, FormatType.None, "x", true, 60);
            CreateGridColumn(gvwcabecera, "NroDocumento", "Ndocu", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "Drefe", 5, FormatType.None, "x", true, 40);
            CreateGridColumn(gvwcabecera, "CRefe", "Crefe", 6, FormatType.None, "x", true, 60);
            CreateGridColumn(gvwcabecera, "Nro Ref", "Nrefe", 7, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Nombre Cliente", "Cli.Nombre", 8, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Ruc", "Cli.Ruc", 9, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "CodCdv", "CondicionV.Codcdv", 10, FormatType.None, "x", false, 100);
            CreateGridColumn(gvwcabecera, "CondicionVenta", "CondicionV.Nomcdv", 11, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Flag", "Flag", 12, FormatType.None, "x", false, 100);
            CreateGridColumn(gvwcabecera, "Estado", "Estado", 13, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Moneda", "Mone", 14, FormatType.None, "x", true, 50);
            CreateGridColumn(gvwcabecera, "Tipo Cambio", "Tcam", 15, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total Neto", "Tota", 16, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total IGV", "Toti", 17, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total", "Totn", 18, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Flg_Fe", "Flg_Fe", 19, DevExpress.Utils.FormatType.Numeric, "d", true, 80);
            CreateGridColumn(gvwcabecera, "EstadoFE", "EstadoFe", 20, DevExpress.Utils.FormatType.Numeric, "d", true, 80);

            
            if(Global.vDatosProveedor.IdEmpresa=="1")//NUBEFACT
            {
                visibleNubefact = true;
                visibleTelesoluciones = false;
            }
            else//2 telesoluciones
            {
                visibleNubefact = false;
                visibleTelesoluciones = true;
            }
            CreateGridColumn(gvwcabecera, "Serie", "Serie", 21, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "Numero", "Numero", 22, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "Enlace", "Enlace", 23, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "AceptadaPorSunat", "AceptadaPorSunat", 24, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "SunatDescription", "SunatDescription", 25, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "SunatNote", "SunatNote", 26, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "SunatResponseCode", "SunatResponseCode", 27, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "SunatSoapError", "SunatSoapError", 28, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "EnlaceDelPdf", "EnlaceDelPdf", 29, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "EnlaceDelPdfAnulado", "EnlaceDelPdfAnulado", 30, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "EnlaceDelCdr", "EnlaceDelCdr", 31, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "EnlaceDelXml", "EnlaceDelXml", 32, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "Tipo_de_comprobante", "Tipo_de_comprobante", 33, FormatType.None, "x", visibleNubefact, 100);
            CreateGridColumn(gvwcabecera, "Motivo_Anulacion", "Motivo_Anulacion", 34, FormatType.None, "x", visibleNubefact, 100);
            
            CreateGridColumn(gvwcabecera, "TeleSol_Serie", "TeleSol_Serie", 35, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "TeleSol_Numero", "TeleSol_Numero", 36, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "TeleSol_FechaEmitido", "TeleSol_FechaEmitido", 37, FormatType.DateTime, "d/M/yyyy", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "TeleSol_Baja", "TeleSol_Baja", 38, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Hash", "TeleSol_DigestValue_Hash", 39, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Firma", "TeleSol_SignatureValue_Firma", 40, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "IdConstancia", "TeleSol_IdConstancia", 41, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "IdRespuesta", "TeleSol_IdRespuesta", 42, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "CodigoRespuestaSunat", "TeleSol_CodigoRespuestaSunat", 43, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "TeleSol_NotaAsociada", "TeleSol_NotaAsociada", 44, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "Nota Sunat", "TeleSol_Descripcion", 45, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "IdFactura", "TeleSol_IdFactura", 46, FormatType.None, "x", visibleTelesoluciones, 100);
            CreateGridColumn(gvwcabecera, "TeleIdComunicacionBaja", "TeleSol_IdComunicacionBaja", 47, FormatType.None, "x", visibleTelesoluciones, 100);
            


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


            CreateGridColumn(gvwdetalle, "Codigo", "Product.Codi", 1, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwdetalle, "CodigoUsuario", "Product.Codf", 2, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Marca", "Product.Marc", 3, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Descripcion", "Product.Descr", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Unidad Medida", "Product.Umed", 5, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwdetalle, "Cantidad", "Cant", 6, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwdetalle, "Precio Unit", "Preu", 7, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwdetalle, "Total", "Total", 8, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);


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

            if (field == "EnlaceDelPdf" && gv.Name == "gvwcabecera")
            {
                gc.OptionsColumn.AllowEdit = true;
                linkPdf.NullText = " ";
                //ieEstadoFe.Images=
                gc.ColumnEdit = linkPdf;
            }
            if (field == "EnlaceDelPdfAnulado" && gv.Name == "gvwcabecera")
            {
                gc.OptionsColumn.AllowEdit = true;
                linkPdfAnulado.NullText = " ";
                //ieEstadoFe.Images=
                gc.ColumnEdit = linkPdfAnulado;
            }
            if (withField != 0)
                gc.Width = withField;



            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        private void ObtenerTipoDocumento()
        {
            List<TipoDocumento> ls = BL.Comercial.ObtenerTipoDocumento(Global.vUserBaseDatos);
            cbotipodocumento.Properties.DisplayMember = "Nomdocu";
            cbotipodocumento.Properties.ValueMember = "Cdocu";
            cbotipodocumento.Properties.DataSource = ls;

            cbotipodocumento.CheckAll();
        }

        private void CargarDocumentosv()
        {
            Int32 enviadosunat = Convert.ToInt32(rbtnenviado.EditValue.ToString());
            Int32 anulado = Convert.ToBoolean(chkanulados.EditValue)== true ? 1 : 0;
            string cdocu=cbotipodocumento.Properties.GetCheckedItems().ToString().Replace(" ", "");
            lstcabcecera = Bfe.ObtenerDocumentosFBNC(cdocu, Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue),
                txtcliente.Text.Trim(), txtdocumento.Text.Trim(),enviadosunat,anulado,Global.vUserBaseDatos);

            //lstcabcecera.ForEach(z => z.Flg_Fe = 1);
            gccabecera.DataSource = lstcabcecera;

            if(!lstcabcecera.Any())
            {
                gcdetalle.DataSource = null;
            }
        }

        private void CargarDocumentosvDetalle(string cdocu,string ndocu)
        {
            List<DocumentovDet> lst = new List<DocumentovDet>();
            lst = Bfe.ObtenerDocumentosDetalleFBNC(cdocu, ndocu,Global.vUserBaseDatos);
            gcdetalle.DataSource = lst;
         
        }
        private Boolean ValidarSunatEnviardocumentosFBN(List<Documentov> lista)
        {
            if(lista.Where(x=> x.Flag.Trim()=="*").Count()>0)
            {
                MessageBox.Show("No esta permitido enviar documentos anulados, verifique su seleccion de documentos", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(lista.Where(x=>x.Flg_Fe==1).Count()>0) //verificacion de documentos enviados a sunat
            {
                MessageBox.Show("Tiene seleccionado documentos ya enviados a Sunat, verifique su seleccion de documentos", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private Boolean ValidarSunatAnulardocumentosFBN(List<Documentov> lista)
        {
            if (lista.Where(x => x.Flag.Trim() != "*").Count() > 0)
            {
                MessageBox.Show("No esta permitido anular documentos en Sunat que no esten anulados en el sistema.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (lista.Where(x => x.Flg_Fe != 1).Count() > 0)
            {
                MessageBox.Show("No esta permitido anular documentos en Sunat que no hayan sido previamente notificados.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if(lista.Count()>1)
            {
                MessageBox.Show("Solo puede anular un documento a la vez.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void SunatEnviardocumentosFBN()
        {
            
            if(MessageBox.Show("Desea enviar los documentos a Sunat?","Utilitario",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck).Select(x => new Documentov(x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe)).OrderBy(x => x.Cdocu+x.Ndocu).ToList();
                if (ValidarSunatEnviardocumentosFBN(lst))
                {
                    //NUBEFACT
                    if(Global.vDatosProveedor.IdEmpresa=="1") 
                    {
                        Bfe.SunatEnviarDocumentosFBN_V2(lst, Global.vDatosProveedor.Ruta, Global.vDatosProveedor.Token, Global.vUserBaseDatos);
                    }
                    else //TELESOLUCIONES
                    {
                        //string ruta="https://demoapi.facturaonline.pe/factura";
                        string telsol_serie="";
                        string telsol_numero="";
                        
                        try
                        {
                            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Enviando Documentos>>>>"))
                            {
                                Bfe.TelesolucionesEnviarFactura(lst, string.Empty, Global.vToken, Global.vUserBaseDatos, ref telsol_serie, ref telsol_numero, Global.vApiTELE_EmisionFactura, Global.vApiTELE_EmisionBoleta,
                                Global.vApiTELE_ConstanciaFactura, Global.vApiTELE_ConstanciaBoleta, Global.vTelemovilAK, Global.vTelemovilSK);
                            }
                                
                            //if (telsol_serie != "")
                            //{
                            //    MostrarPDF_Telesoluciones(telsol_serie, telsol_numero);
                            //}
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            if(lst.Count==1)
                            {
                                if (telsol_serie != "")
                                {
                                    MostrarPDF_Telesoluciones(telsol_serie, telsol_numero);
                                    MessageBox.Show("Se envio los documentos seleccionados", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se logro enviar el documento seleccionado.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            
                        }
                        
                        
                    }
                   
                    
                    
                    lstcabcecera.ForEach(x => x.FlgCheck = false);
                    gccabecera.RefreshDataSource();
                }           
            }
        }

        private void ObtenerConstanciaTelesoluciones()
        {
            if (MessageBox.Show("Desea actualizar la constancia de las facturas seleccionadas ?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck == true && x.Flg_Fe == 1 && x.TeleSol_IdFactura.Trim() != string.Empty && x.TeleSol_IdComunicacionBaja.Trim() == string.Empty && x.TeleSol_IdConstancia==string.Empty).Select(x => new Documentov(x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe, x.TeleSol_IdFactura,x.TeleSol_Serie,x.TeleSol_Numero)).OrderBy(x => x.Cdocu + x.Ndocu).ToList();


                Bfe.TelesolucionesObtenerConstancia(lst, string.Empty, Global.vToken, Global.vUserBaseDatos,Global.vApiTELE_ConstanciaFactura,Global.vApiTELE_ConstanciaBoleta, Global.vTelemovilAK, Global.vTelemovilSK);


                MessageBox.Show("Se actualizo correctamente", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstcabcecera.ForEach(x => x.FlgCheck = false);
                gccabecera.RefreshDataSource();
            }
                
            
            
        }

        private void SunatAnulardocumentosFBN()
        {
            if (MessageBox.Show("Desea anular los documentos seleccionados?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck).
                    Select(x => 
                    new Documentov(
                        x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe,x.Tipo_de_comprobante,x.Motivo_Anulacion,x.Serie,x.Numero,
                        (x.TeleSol_FechaEmitido),x.TeleSol_Numero,x.TeleSol_Serie)).ToList();
                if (ValidarSunatAnulardocumentosFBN(lst))
                {
                    if (Global.vDatosProveedor.IdEmpresa == "1") //NUBEFACT
                    {
                        Bfe.SunatAnularDocumentosFBN(lst.First(), Global.vDatosProveedor.Ruta, Global.vDatosProveedor.Token, Global.vUserBaseDatos);
                    }
                    else //TELESOLUCIONES
                    {
                        List<DocumentovDet> lstdetalle = new List<DocumentovDet>();
                        lstdetalle = Bfe.ObtenerDocumentosDetalleFBNC(lst.Select(x => x.Cdocu).First(), lst.Select(x => x.Ndocu).First(), Global.vUserBaseDatos);
                        using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Anulando>>>>"))
                        {

                            Bfe.TelesolucionesAnularDocumento(lst.First(), lstdetalle, Global.vDatosProveedor.Ruta, Global.vDatosProveedor.Token, Global.vUserBaseDatos, Global.vApiTELE_AnularDocumento, Global.vTelemovilAK, Global.vTelemovilSK);
                        }
                    }

                    
                    MessageBox.Show("Se anulo los documentos seleccionados", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstcabcecera.ForEach(x => x.FlgCheck = false);
                    gccabecera.RefreshDataSource();
                }
            }
        }


        private void ConsultarDocumentoSunat()
        {
            List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck).Select(x => new Documentov(x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe,x.Tipo_de_comprobante,x.Motivo_Anulacion,x.Serie,x.Numero)).ToList();
            if(lst.Count()>1)
            {
                MessageBox.Show("Solo se puede consultar 1 documento.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                SunatRespuestaFBN eRes = Bfe.SunatConsultarDocumentosFBN(lst.First(), Global.vRuta, Global.vToken, Global.vUserBaseDatos);
                if(eRes.aceptada_por_sunat)
                {
                    string cdocu = lst.Select(x => x.Cdocu).First();
                    string ndocu = lst.Select(x => x.Ndocu).First();
                    Bfe.GuardarRespuestaSunat_Consulta(cdocu, ndocu, eRes, Global.vUserBaseDatos);
                }
                
                frm_ConsultaEstadoFe form = new frm_ConsultaEstadoFe(eRes);
                form.ShowDialog();
            }
        }

        private void EnviarEmail()
        {
            //List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck).Select(x => new Documentov(x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe, x.Tipo_de_comprobante, x.Motivo_Anulacion, x.Serie, x.Numero)).ToList();
            if ((gvwcabecera.GetFocusedRowCellValue("Flg_Fe").ToString().Trim() != "1"))
            {
                MessageBox.Show("Solo se puede enviar el correo de documentos emitidos electronicamente", "ERP Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string _serie=string.Empty;
            string _numero = string.Empty;

            string _cdocu= gvwcabecera.GetFocusedRowCellValue("Cdocu").ToString().Trim();
            string _ndocu= gvwcabecera.GetFocusedRowCellValue("Ndocu").ToString().Trim();
            string _ruccli= gvwcabecera.GetFocusedRowCellValue("Cli.Ruc").ToString().Trim();
            string _nomcli= gvwcabecera.GetFocusedRowCellValue("Cli.Nombre").ToString().Trim();
            if(visibleNubefact)
            {
                
                _serie = gvwcabecera.GetFocusedRowCellValue("Serie").ToString().Trim();
                _numero = gvwcabecera.GetFocusedRowCellValue("Numero").ToString().Trim();
            }
            if(visibleTelesoluciones)
            {
                _serie=gvwcabecera.GetFocusedRowCellValue("TeleSol_Serie").ToString().Trim();
                _numero = gvwcabecera.GetFocusedRowCellValue("TeleSol_Numero").ToString().Trim();
            }
            
             
            string _moneda = gvwcabecera.GetFocusedRowCellValue("Mone").ToString().Trim();
            double _total=Convert.ToDouble(gvwcabecera.GetFocusedRowCellValue("Totn").ToString().Trim());
            DateTime _fechadocumento= Convert.ToDateTime(gvwcabecera.GetFocusedRowCellValue("Fecha").ToString().Trim());

            frm_EnvioEmail form = new frm_EnvioEmail();
            form._cdocu = _cdocu;
            form._ndocu = _ndocu;
            form._ruccli = _ruccli;
            form._nomcli = _nomcli;
            form._serie = _serie;
            form._numero = _numero;
            form._moneda = _moneda;
            form._total = _total;
            form._fechadocumento = _fechadocumento;
            form.ShowDialog();
            
        }
        private void VerArchivoJson()
        {
            List<Documentov> lst = lstcabcecera.Where(x => x.FlgCheck).Select(x => new Documentov(x.Cdocu, x.Ndocu, x.Flag, x.Flg_Fe, x.Tipo_de_comprobante, x.Motivo_Anulacion, x.Serie, x.Numero)).ToList();
            if (lst.Count() > 1)
            {
                MessageBox.Show("Solo se puede consultar 1 documento.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string archivo;
                if (Global.vDatosProveedor.IdEmpresa == "1")
                {
                    archivo= Bfe.VerArchivoJson(lst, Global.vUserBaseDatos);
                }
                else
                {
                    archivo = "";
                }
                 
                frm_VisorArchivos frm = new frm_VisorArchivos(archivo);
                frm.ShowDialog();
            }
        }
        #endregion

        private void frm_facturas_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                ObtenerTipoDocumento();
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                this.rbtnenviado.SelectedIndex = 0;
                //                menu.Items.Add()
                AgregarTemas();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "OPPFILM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            
        }
        private void AgregarTemas()
        {
            ToolStripMenuItem item, submenu;
            submenu = new ToolStripMenuItem();
            submenu.Text = "Temas";

            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                //comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
                item = new ToolStripMenuItem();
                item.Text = cnt.SkinName.ToString();
                submenu.DropDownItems.Add(item);
            }
            
            
            menu.Items.Add(submenu);
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
                    CargarDocumentosvDetalle(cdocu, ndocu);
                }
                else
                {
                    gcdetalle.DataSource = null;
                }
            }
            catch (Exception err)
            {
                MensajeError(err);
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

                    case "mnumarcartodo":
                        {

                            lstcabcecera.ForEach(y => y.FlgCheck = true);
                            gccabecera.RefreshDataSource();
                        }
                        break;
                    case "mnulimpiartodo":
                        {
                            lstcabcecera.ForEach(y => y.FlgCheck = false);
                            gccabecera.RefreshDataSource();
                        }
                        break;
                    case "mnuenviardocumentos":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro para poder enviar a Sunat", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            SunatEnviardocumentosFBN();
                            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando>>>>"))
                            {
                                CargarDocumentosv();
                            }
                                
                            break;
                        }
                    case "mnuconstancia":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro para poder enviar a Sunat", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            ObtenerConstanciaTelesoluciones();
                            CargarDocumentosv();
                            break;
                        }


                    case "mnuverpdf":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            //NUBEFACT
                            if (Global.vDatosProveedor.IdEmpresa == "1")
                            {
                                string pdf = gvwcabecera.GetFocusedRowCellValue("EnlaceDelPdf").ToString().Trim();
                                if (pdf == string.Empty)
                                {
                                    MessageBox.Show("El documento no tiene registrado la Url del Pdf", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                    break;
                                }
                                frm_FacturasVisorPdf form = new frm_FacturasVisorPdf(pdf,null,"NUBEFACT");
                                form.ShowDialog();
                                
                            }
                            else //TELESOLUCIONES
                            {


                                //string idFactura = gvwcabecera.GetFocusedRowCellValue("TeleSol_Serie").ToString().Trim() +
                                //    gvwcabecera.GetFocusedRowCellValue("TeleSol_Numero").ToString().Trim();
                                //string tipodocumento = gvwcabecera.GetFocusedRowCellValue("TeleSol_Serie").ToString().Trim();
                                //if(idFactura.Trim()==string.Empty)
                                //{
                                //    MessageBox.Show("El documento no ha sido registrado en sunat.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //    return;
                                //}
                                //System.IO.MemoryStream ms= Bfe.ObtenerPdfTelesoluciones(tipodocumento.Substring(0,1).Trim(),idFactura);
                                //frm_FacturasVisorPdf form = new frm_FacturasVisorPdf(string.Empty, ms,"TELESOLUCIONES");
                                //form.ShowDialog();
                                
                                MostrarPDF_Telesoluciones(gvwcabecera.GetFocusedRowCellValue("TeleSol_Serie").ToString().Trim(),
                                    gvwcabecera.GetFocusedRowCellValue("TeleSol_Numero").ToString().Trim());
                            }

                            break;

                        }
                    case "mnuanulardocumento":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro para poder enviar a Sunat", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            SunatAnulardocumentosFBN();
                            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Consultando>>>>"))
                            {
                                CargarDocumentosv();
                            }
                            break;
                            
                        }
                    case "mnuverpdfanulado":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            string pdf = gvwcabecera.GetFocusedRowCellValue("EnlaceDelPdfAnulado").ToString().Trim();
                            if (pdf == string.Empty)
                            {
                                MessageBox.Show("El documento no tiene registrado la Url del Pdf Anulado", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                break;
                            }
                            frm_FacturasVisorPdf form = new frm_FacturasVisorPdf(pdf,null,"NUBEFACT");
                            form.ShowDialog();
                            break;
                        }
                    case "mnuconsultardoc":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            ConsultarDocumentoSunat();
                            break;
                        }
                    case "mnuverjson":
                        {
                            if (lstcabcecera.Where(y => y.FlgCheck).Count() <= 0)
                            {
                                MessageBox.Show("Debe seleccionar como minimo un registro", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            VerArchivoJson();
                            break;
                        }
                    case "mnuemail":
                        {
                            if (Global.vDatosProveedor.IdEmpresa == "1")
                            {
                                MessageBox.Show("Opcion no disponible para Grupo IAP", "utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                EnviarEmail();
                            }
                                


                            break;
                        }
                    default:
                        {
                            //defaultLookAndFeel1.LookAndFeel.SkinName = e.ClickedItem.Name;
                            break;
                        }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Utilitario",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
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

        private void gvwcabecera_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (cellsStyles.Contains(e.Column.FieldName))
            {
                e.Appearance.BackColor = Color.LightYellow;
                e.Appearance.BackColor2 = Color.LightYellow;
                
                
            }
            else
            {
                e.Appearance.BackColor = Color.Transparent;
                e.Appearance.BackColor2 = Color.Transparent;
            }

            if ((new string[] { "EnlaceDelPdf", "EnlaceDelPdfAnulado" }).Contains(e.Column.FieldName))
            {
                e.Appearance.ForeColor = Color.Red;
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarPDF_Telesoluciones(string serie,string numero)
        {
            //string idFactura = gvwcabecera.GetFocusedRowCellValue("TeleSol_Serie").ToString().Trim() +
            //                        gvwcabecera.GetFocusedRowCellValue("TeleSol_Numero").ToString().Trim();
            string idFactura = serie + numero;
            string tipodocumento = serie;
            if (idFactura.Trim() == string.Empty)
            {
                MessageBox.Show("El documento no ha sido registrado en sunat.", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            System.IO.MemoryStream ms = Bfe.ObtenerPdfTelesoluciones(tipodocumento.Substring(0, 1).Trim(), idFactura,Global.vApiTELE_PdfFactura,Global.vApiTELE_PdfBoleta, Global.vTelemovilAK, Global.vTelemovilSK);
            frm_FacturasVisorPdf form = new frm_FacturasVisorPdf(string.Empty, ms, "TELESOLUCIONES");
            form.ShowDialog();
        }
       
    }
}
