using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAP.Win.Comercial.PlantillasOS
{
    public partial class frm_Contenedor : Form
    {
        public string _NroDocumento;
        public string _NombreEncargado;
        public string _CodOperario;
        public string _FechaInicio;
        public string _FechaFin;
        public string _TipoPlantilla;
        public string _Codi;
        public string _NroLinea;

        public frm_Contenedor()
        {
            InitializeComponent();
            
        }

        private void frm_Contenedor_Load(object sender, EventArgs e)
        {
            try
            {
                txtnroorden.Text = _NroDocumento;
                txtencargado.Text = _NombreEncargado;
                txtfechainicio.Text = _FechaInicio;
                txtfechafin.Text = _FechaFin;

                btniniciar.Enabled = txtfechainicio.Text.Trim() == string.Empty ? true : false;
                btnterminar.Enabled = txtfechainicio.Text.Trim() == string.Empty ? false : true;

                if(txtfechainicio.Text.Trim()!=string.Empty && txtfechafin.Text.Trim()!=string.Empty)
                {
                    btniniciar.Enabled = false;
                    btnterminar.Enabled = false;
                }
                //switch (_TipoPlantilla.ToUpper())
                //{
                //    case "PLANTILLA1":
                //        {
                //            frm_plantilla1 frmPlantilla = new frm_plantilla1();
                //            frmPlantilla._NroDocumento = _NroDocumento;
                //            frmPlantilla._CodOperario = _CodOperario;
                //            frmPlantilla._Codi = _Codi;
                //            frmPlantilla._NroLinea = _NroLinea;
                //            frmPlantilla._EstadoBoton = txtfechainicio.Text.Trim() != string.Empty ? false : true;
                //            frmPlantilla._PLANTILLA = _TipoPlantilla.ToUpper();
                //            AgregarFormularioEnPanel(frmPlantilla, "PLANTILLA1");
                //            break;
                //        }

                //}
                frm_plantilla1 frmPlantilla = new frm_plantilla1();
                frmPlantilla._NroDocumento = _NroDocumento;
                frmPlantilla._CodOperario = _CodOperario;
                frmPlantilla._Codi = _Codi;
                frmPlantilla._NroLinea = _NroLinea;
                frmPlantilla._EstadoBoton = txtfechainicio.Text.Trim() != string.Empty ? false : true;
                frmPlantilla._PLANTILLA = _TipoPlantilla.ToUpper();
                AgregarFormularioEnPanel(frmPlantilla, _TipoPlantilla.ToUpper());
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void AgregarFormularioEnPanel(Form form, string nombreFormulario)
        {
            //if (this.tp2.Controls.Count != 0)
            //    this.tp2.Controls.RemoveAt(0);

            //int numeroTapPage = xtraTabControl1.TabPages.Count() + 1;
            //DevExpress.XtraTab.XtraTabPage tp = new DevExpress.XtraTab.XtraTabPage();
            //tp.Name = "tp" + numeroTapPage.ToString();
            //tp.Text = nombreFormulario;
            //tp.AutoScroll = true;

            DevExpress.XtraEditors.XtraScrollableControl scrol = new DevExpress.XtraEditors.XtraScrollableControl();
            scrol.Dock = DockStyle.Fill;

            //formulario
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel_contenedor.Controls.Add(scrol);
            panel_contenedor.Tag = scrol;
            //scrol.TabIndex = 0;

            //xtraTabControl1.TabPages.Add(tp);
            //tp.Controls.Add(scrol);
            //tp.Tag = scrol;


            //tp.Controls.Add(form);
            //tp.Tag = form;
            scrol.Controls.Add(form);
            scrol.Tag = form;

            form.Show();

            //xtraTabControl1.TabPages.Add(tp);
            //xtraTabControl1.SelectedTabPage = tp;

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Desea registrar el inicio del servicio?","Utilitario",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    BL.Comercial objCom = new BL.Comercial();
                    objCom.Actualizar_Fechas_proceso_OS(_NroDocumento, Convert.ToInt32(_NroLinea), _CodOperario, Global.vUserBaseDatos);
                    txtfechainicio.Text = DateTime.Now.ToString();
                    btniniciar.Enabled = false;
                    btnterminar.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea registrar el fin del servicio?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BL.Comercial objCom = new BL.Comercial();
                    objCom.Actualizar_Fechas_proceso_OS(_NroDocumento, Convert.ToInt32(_NroLinea), _CodOperario, Global.vUserBaseDatos);
                    txtfechafin.Text = DateTime.Now.ToString();
                    btniniciar.Enabled = false;
                    btnterminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
