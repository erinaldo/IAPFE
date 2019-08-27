using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAP.BE;
namespace IAP.Win.Comercial.PlantillasOS
{
    public partial class frm_plantilla1 : Form
    {
        public string _NroDocumento;
        public string _NombreEncargado;
        public string _CodOperario;
        public string _TipoPlantilla;
        public string _Codi;
        public string _NroLinea;
        public Boolean _EstadoBoton = false;
        public string _PLANTILLA;

        public OrdenServicioPlantillaParametros _objParametrosOS = new OrdenServicioPlantillaParametros();
        public frm_plantilla1()
        {
            InitializeComponent();
        }

        private void frm_plantilla1_Load(object sender, EventArgs e)
        {
            _objParametrosOS.ndocu = _NroDocumento;
            _objParametrosOS.cod_operario = _CodOperario;
            _objParametrosOS.codi = _Codi;
            _objParametrosOS.item = _NroLinea;
            
            btnguardar.Enabled = _EstadoBoton;
            CargarPlantilla_ParametrosOS();
            CargarPlantillas();
        }
        private void CargarPlantillas()
        {
           if(_PLANTILLA=="PLANTILLA1")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.Plantilla1;
                txtp1.Location = new Point(12, 192);
                txtp1.Visible = true;
            }
        }
        private void CargarPlantilla_ParametrosOS()
        {
            BL.Comercial objCom = new BL.Comercial();
            _objParametrosOS = objCom.Obtener_PlantillaParametros_OS(_NroDocumento, _CodOperario, _Codi, Convert.ToInt32(_NroLinea), Global.vUserBaseDatos);

            txtp1.Text = _objParametrosOS.p1.ToString();
            txtp2.Text = _objParametrosOS.p2.ToString();
            txtp3.Text = _objParametrosOS.p3.ToString();
            txtp4.Text = _objParametrosOS.p4.ToString();
            txtp5.Text = _objParametrosOS.p5.ToString();
            txtp6.Text = _objParametrosOS.p6.ToString();
            txtp7.Text = _objParametrosOS.p7.ToString();
            txtp8.Text = _objParametrosOS.p8.ToString();
            txtp9.Text = _objParametrosOS.p9.ToString();
            txtp10.Text = _objParametrosOS.p10.ToString();
            txtp11.Text = _objParametrosOS.p11.ToString();
            txtp12.Text = _objParametrosOS.p12.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea guardar los datos?", "Utilitario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BL.Comercial objCom = new BL.Comercial();
                    _objParametrosOS.ndocu = _NroDocumento;
                    _objParametrosOS.cod_operario = _CodOperario;
                    _objParametrosOS.codi = _Codi;
                    _objParametrosOS.item = _NroLinea;
                    _objParametrosOS.p1 = Convert.ToDouble(txtp1.Text.Trim() == string.Empty ? "0" : txtp1.Text.Trim());
                    _objParametrosOS.p2 = Convert.ToDouble(txtp2.Text.Trim() == string.Empty ? "0" : txtp2.Text.Trim());
                    _objParametrosOS.p3 = Convert.ToDouble(txtp3.Text.Trim() == string.Empty ? "0" : txtp3.Text.Trim());
                    _objParametrosOS.p4 = Convert.ToDouble(txtp4.Text.Trim() == string.Empty ? "0" : txtp4.Text.Trim());
                    _objParametrosOS.p5 = Convert.ToDouble(txtp5.Text.Trim() == string.Empty ? "0" : txtp5.Text.Trim());
                    _objParametrosOS.p6 = Convert.ToDouble(txtp6.Text.Trim() == string.Empty ? "0" : txtp6.Text.Trim());
                    _objParametrosOS.p7 = Convert.ToDouble(txtp7.Text.Trim() == string.Empty ? "0" : txtp7.Text.Trim());
                    _objParametrosOS.p8 = Convert.ToDouble(txtp8.Text.Trim() == string.Empty ? "0" : txtp8.Text.Trim());
                    _objParametrosOS.p9 = Convert.ToDouble(txtp9.Text.Trim() == string.Empty ? "0" : txtp9.Text.Trim());
                    _objParametrosOS.p10 = Convert.ToDouble(txtp10.Text.Trim() == string.Empty ? "0" : txtp10.Text.Trim());
                    _objParametrosOS.p11 = Convert.ToDouble(txtp11.Text.Trim() == string.Empty ? "0" : txtp11.Text.Trim());
                    _objParametrosOS.p12 = Convert.ToDouble(txtp12.Text.Trim() == string.Empty ? "0" : txtp12.Text.Trim());

                    objCom.Registrar_PlantillaParametros_OS(_objParametrosOS, Global.vUserBaseDatos);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
