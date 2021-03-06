﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using IAP.Win.Comercial;
using IAP.Win.Creditos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
//using IAP.Win.Comercial;
using IAP.Win.Administracion;
using IAP.BL;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using IAP.Win.Reportes;
namespace IAP.Win
{
    
    public partial class FRM_MENU_MAIN : Form
    {
        
        
        public FRM_MENU_MAIN()
        {
            InitializeComponent();
            
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_eliminacion_arqueo frmarq = new frm_eliminacion_arqueo();
            frmarq.Show();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmborrar_documento frmborrar = new frmborrar_documento();
            frmborrar.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Debe tener mucho cuidado al ingresar a este modulo, solo debe ser ejecutado por personas\r\nque sepan sobre las ejecuciones que de los archivos que van ha cargar,los cambios realizados pueden ser irreversibles ó irreparables\r\n Desea Continuar?", "Administración del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                frm_consultas_sql FRMCONSULTA = new frm_consultas_sql();
                FRMCONSULTA.Show();
            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_crear_backup frmbk = new frm_crear_backup();
            frmbk.Show();
        }

        private void FRM_MENU_MAIN_Load(object sender, EventArgs e)
        {
            //if(Environment.GetCommandLineArgs().Length>1)
            //{
            //    String[] parametros = Environment.GetCommandLineArgs();
            //    for (int i = 0; i < parametros.Length; i++)
            //    {
            //        MessageBox.Show("Parámetro :" + parametros[i]);
            //    }
            //}
            BFacturacionElectronica eBL = new BFacturacionElectronica();

            xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            DevExpress.UserSkins.BonusSkins.Register();
            //SkinHelper.InitSkinPopupMenu(SkinLink);

            

            //FRM_MENU_MAIN FRM = new FRM_MENU_MAIN();
            //FRM.Text = "Base de Datos Actual(" + Global.vUserBaseDatos + ")";
            frm_AccesoUsuario FRMACCESOS = new frm_AccesoUsuario();
            
            
            FRMACCESOS.ShowDialog();

            if (Global.login_conforme == "si")
            {
                //this.Text = "EMPRESA ACTUAL ::::::: " + Global.vUserServer;
                //IAP.DL.ConexionDC.IpServidor = Global.vIpServidor;
                Accessos_Usuario(Global.UserAdministrador);

                string IdEmpresaFE = ConfigurationManager.AppSettings.Get("PROVEEDORFE");
                string Empresa= ConfigurationManager.AppSettings.Get("EMPRESA");
                Global.vUserRucEmpresa= ConfigurationManager.AppSettings.Get("RUCEMPRESA");
                //Global.vTelemovilAK= ConfigurationManager.AppSettings.Get("TELEMOVILAK");
                //Global.vTelemovilSK= ConfigurationManager.AppSettings.Get("TELEMOVILSK");

                Global.vApiTELE_EmisionFactura= ConfigurationManager.AppSettings.Get("TELE_EmisionFactura");
                Global.vApiTELE_EmisionBoleta= ConfigurationManager.AppSettings.Get("TELE_EmisionBoleta");
                Global.vApiTELE_ConstanciaFactura= ConfigurationManager.AppSettings.Get("TELE_ConstanciaFactura");
                Global.vApiTELE_ConstanciaBoleta= ConfigurationManager.AppSettings.Get("TELE_ConstanciaBoleta");
                Global.vApiTELE_PdfFactura= ConfigurationManager.AppSettings.Get("TELE_PdfFactura");
                Global.vApiTELE_PdfBoleta= ConfigurationManager.AppSettings.Get("TELE_PdfBoleta");
                Global.vApiTELE_AnularDocumento= ConfigurationManager.AppSettings.Get("TELE_AnularDocumento");
                Global.vApiTELE_EmisionGuiaRemision = ConfigurationManager.AppSettings.Get("TELE_EmisionGuia");
                Global.vApiTELE_ConstanciaGuia = ConfigurationManager.AppSettings.Get("TELE_ConstanciaGuia");



                Global.vUsuarioBD= ConfigurationManager.AppSettings.Get("USUARIOBD");
                Global.vPasswordBD= ConfigurationManager.AppSettings.Get("PASSWORDBD");

                Global.vDatosProveedor = eBL.ObtenerProveedorFE(Convert.ToInt32(IdEmpresaFE == string.Empty ? "0" : IdEmpresaFE), Global.vUserBaseDatos);
                //this.dvw_costos.LoadDashboard(aOppFilm.Create<ISProcProduccion>().ObtenerXmlProcProduccion("CostosConsumo"));
                Global.vDatosProveedor.IdEmpresa = IdEmpresaFE;

                
                Global.vTelemovilAK = Global.vDatosProveedor.Ruta;
                Global.vTelemovilSK = Global.vDatosProveedor.Token;

                /* CREDENCIALES DE PRUEBA */
                //Global.vTelemovilAK = "c73ed3b5f2085ffdd429044b4757b97917c7ea775c0d12eae388e6e9bf19bb17";
                //Global.vTelemovilSK = "7cb2040d868a8ed6d044fef4d6d37bcded6fd47425bab1b1973e6e66e440f3c2";


                Global.vUserRucEmpresa = Global.vDatosProveedor.Ruc;
                Global.vUserNombreEmpresa = Global.vDatosProveedor.Empresa;
                this.Text = "EMPRESA ACTUAL ::::::: " + Global.vUserNombreEmpresa;
                this.Text = this.Text + ":::: RUC : " + Global.vUserRucEmpresa;

                if (Empresa== Global.vUserServer)
                {
                    creditos_letrasemitidas.Enabled = true;
                }
                else
                {
                    creditos_letrasemitidas.Enabled = false;
                }


                
                if(Global.vUserBaseDatos.Trim().ToUpper()=="BDNAVA02")
                {
                    defaultLookAndFeel1.LookAndFeel.SkinName = "Sharp Plus";
                }
                else
                {
                    defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
                }
                
                try
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Cargando", "Espere por favor..."))
                    {
                        //dvwcxc.LoadDashboard(BL.Comercial.ObtenerXmlDashBoard("DocumentosCxC", Global.vUserBaseDatos));
                        //xtraTabControl1.TabPages[0].PageVisible = true;
                        this.WindowState = FormWindowState.Maximized;
                        //geckoWebBrowser1.Navigate("www.google.com");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message.ToString(), "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }

            }
            else
            {
                Application.Exit();
            }
            
            
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            

            frm_cdn form = new frm_cdn();
            string nombreForm = reportes_cdn.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_ws_android_aprobar_pedidos frmws = new frm_ws_android_aprobar_pedidos();
            frmws.ShowDialog();
        }

        private void Accessos_Usuario(Boolean usuario_administrador)
        {
            if (usuario_administrador == false)
            {
                //procesos_elimarqueo.Enabled = false;
                //procesos_eliminarfac.Enabled = false;
                //sistema_backup.Enabled = false;
                sistema_ejecucion_sql.Enabled = false;
                sistema_servicio.Enabled = false;

                android_consulta.Enabled = false;
                android_usuarios.Enabled = false;
                comercial_cambioclave.Enabled = false;
            }
        }

        private void android_usuarios_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_UsuariosAndroid frmuser = new frm_UsuariosAndroid();
            frmuser.ShowDialog();
        }

        private void sistema_servicio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_statusSQL frmstatus = new frm_statusSQL();
            frmstatus.ShowDialog();
        }

        private void procesos_importarasiento_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_importar_asiento frmasiento = new frm_importar_asiento();
            //frmasiento.ShowDialog();
            string nombreform = contabilidad_importarasiento.Caption;
            AgregarFormularioEnTabPage(frmasiento, nombreform);
        }

      

        private void comercial_listaprecio_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ListaDePrecios frmlista = new ListaDePrecios();
            //frmlista.Show();
            string nombreForm = comercial_listaprecio.Caption;
            AgregarFormularioEnTabPage(frmlista, nombreForm);
        }

        private void comercial_eliminararqueo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_eliminacion_arqueo frmarq = new frm_eliminacion_arqueo();
            frmarq.Show();

        }

        private void comercial_eliminardocumento_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmborrar_documento frmborrar = new frmborrar_documento();
            frmborrar.Show();
        }

        private void contabilidad_importarasiento_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            frm_importar_asiento frmasiento = new frm_importar_asiento();
            //frmasiento.ShowDialog();
            string nombreform = contabilidad_importarasiento.Caption;
            AgregarFormularioEnTabPage(frmasiento, nombreform);
        }

        private void comercial_cambioclave_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_PasswordVentas form = new frm_PasswordVentas();
            form.ShowDialog();
        }

        private void comercial_FE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            //xtraTabControl1.TabPages[2].Name = "tp3";

            frm_facturas form = new frm_facturas();
            string nombreForm = comercial_FE.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);

        }


        private void AgregarFormularioEnTabPage(Form form, string nombreFormulario)
        {
            //if (this.tp2.Controls.Count != 0)
            //    this.tp2.Controls.RemoveAt(0);
            
            int numeroTapPage = xtraTabControl1.TabPages.Count() + 1;
            DevExpress.XtraTab.XtraTabPage tp = new DevExpress.XtraTab.XtraTabPage();
            tp.Name = "tp"+numeroTapPage.ToString();
            tp.Text = nombreFormulario;
            //tp.AutoScroll = true;

            DevExpress.XtraEditors.XtraScrollableControl scrol = new DevExpress.XtraEditors.XtraScrollableControl();
            scrol.Dock = DockStyle.Fill;

            //formulario
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            //scrol.TabIndex = 0;

            //xtraTabControl1.TabPages.Add(tp);
            tp.Controls.Add(scrol);
            tp.Tag = scrol;

            
            //tp.Controls.Add(form);
            //tp.Tag = form;
            scrol.Controls.Add(form);
            scrol.Tag = form;

            form.Show();

            xtraTabControl1.TabPages.Add(tp);
            xtraTabControl1.SelectedTabPage = tp;
            
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabPage tp = xtraTabControl1.SelectedTabPage;
            xtraTabControl1.TabPages.Remove(tp);
        }

        private void administracion_cargartxtFac_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_cargartxtFacturas frm = new frm_cargartxtFacturas();
            string nombreform = contabilidad_importarasiento.Caption;
            AgregarFormularioEnTabPage(frm, nombreform);
        }

        private void comercial_OS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_OrdenServicio form = new frm_OrdenServicio();
            string nombreForm = comercial_OS.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void comercial_ImportarCliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SUNAT form = new SUNAT();
            string nombreForm = comercial_ImportarCliente.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            
            StreamReader r;
            string line;
            WebBrowser wb = webBrowser1;
            int X = 0;
            //d = client.OpenRead("http://www.tuweb.com/index.aspx"); // Accede a la pagina que quieres buscar
            r = new StreamReader(wb.DocumentStream); // lee la informacion o contenido de la web
            line = r.ReadToEnd(); // recorre linea x linea la web
            while (line != null) // mientras exista contenido
            {
                // aca realizas tu codigo de verificacion o obtener informacion
                line = r.ReadLine(); // para seguir leendo las otras lineas de la pagina
                X = X + 1;
                if (line.Contains("RUC:"))
                {
                    line = r.ReadLine();
                }
            }
            

            
        }

       

        private void creditos_letrasemitidas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmLetrasEmitidas form = new frmLetrasEmitidas();
            string nombreForm = creditos_letrasemitidas.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void comercial_arqueoOS_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_ArqueoOS form = new frm_ArqueoOS();
            string nombreForm = comercial_arqueoOS.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void reportes_dw_ventas_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_dvw_comercial_ventas form = new frm_dvw_comercial_ventas();
            string nombreForm = reportes_dw_ventas.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void FRM_MENU_MAIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comercial_OSPlanta_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_OrdenServicioTactil form = new frm_OrdenServicioTactil();
            string nombreForm = comercial_OSPlanta.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }

        private void comercial_GuiaE_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_guiasRemision form = new frm_guiasRemision();
            string nombreForm = comercial_GuiaE.Caption;
            AgregarFormularioEnTabPage(form, nombreForm);
        }
    }
}
