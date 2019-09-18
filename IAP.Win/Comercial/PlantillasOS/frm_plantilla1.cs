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
using IAP.Win;

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
            if (_PLANTILLA == "PLANTILLA1")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA1; txtp1.Location = new Point(220, 475); txtp1.Visible = true;
                txtp2.Location = new Point(244, 271); txtp2.Visible = true; txtp3.Location = new Point(474, 251); txtp3.Visible = true;
                txtp4.Location = new Point(694, 241); txtp4.Visible = true; txtp5.Location = new Point(716, 215); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA2")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA2; txtp1.Location = new Point(215, 474); txtp1.Visible = true; txtp2.Location = new Point(3, 187); txtp2.Visible = true; txtp3.Location = new Point(113, 134); txtp3.Visible = true; txtp4.Location = new Point(44, 233); txtp4.Visible = true; txtp5.Location = new Point(237, 123); txtp5.Visible = true; txtp6.Location = new Point(240, 187); txtp6.Visible = true; txtp7.Location = new Point(324, 215); txtp7.Visible = true; txtp8.Location = new Point(267, 260); txtp8.Visible = true; txtp9.Location = new Point(578, 279); txtp9.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA3")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA3; txtp1.Location = new Point(212, 467); txtp1.Visible = true; txtp2.Location = new Point(267, 260); txtp2.Visible = true; txtp3.Location = new Point(468, 243); txtp3.Visible = true; txtp4.Location = new Point(693, 209); txtp4.Visible = true; txtp5.Location = new Point(678, 233); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA4")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA4; txtp1.Location = new Point(215, 474); txtp1.Visible = true; txtp2.Location = new Point(265, 271); txtp2.Visible = true; txtp3.Location = new Point(478, 246); txtp3.Visible = true; txtp4.Location = new Point(735, 237); txtp4.Visible = true; txtp5.Location = new Point(703, 262); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA5")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA5; txtp1.Location = new Point(227, 449); txtp1.Visible = true; txtp2.Location = new Point(161, 312); txtp2.Visible = true; txtp3.Location = new Point(204, 121); txtp3.Visible = true; txtp4.Location = new Point(497, 320); txtp4.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA6")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA6; txtp1.Location = new Point(230, 467); txtp1.Visible = true; txtp2.Location = new Point(199, 425); txtp2.Visible = true; txtp3.Location = new Point(177, 293); txtp3.Visible = true; txtp4.Location = new Point(110, 262); txtp4.Visible = true; txtp5.Location = new Point(356, 368); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA7")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA7; txtp1.Location = new Point(215, 465); txtp1.Visible = true; txtp2.Location = new Point(266, 262); txtp2.Visible = true; txtp3.Location = new Point(472, 236); txtp3.Visible = true; txtp4.Location = new Point(695, 212); txtp4.Visible = true; txtp5.Location = new Point(679, 236); txtp5.Visible = true;
            }

            if (_PLANTILLA == "PLANTILLA8")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA8; txtp1.Location = new Point(203, 452); txtp1.Visible = true; txtp2.Location = new Point(163, 276); txtp2.Visible = true; txtp3.Location = new Point(292, 107); txtp3.Visible = true; txtp4.Location = new Point(616, 334); txtp4.Visible = true;
            }

            if (_PLANTILLA == "PLANTILLA9")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA9; txtp1.Location = new Point(215, 470); txtp1.Visible = true; txtp2.Location = new Point(266, 265); txtp2.Visible = true; txtp3.Location = new Point(482, 236); txtp3.Visible = true; txtp4.Location = new Point(695, 216); txtp4.Visible = true; txtp5.Location = new Point(684, 236); txtp5.Visible = true;
            }

            if (_PLANTILLA == "PLANTILLA10")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA10; txtp1.Location = new Point(188, 456); txtp1.Visible = true; txtp2.Location = new Point(377, 316); txtp2.Visible = true; txtp3.Location = new Point(134, 404); txtp3.Visible = true; txtp4.Location = new Point(37, 20); txtp4.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA11")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA11; txtp1.Location = new Point(242, 456); txtp1.Visible = true; txtp2.Location = new Point(84, 440); txtp2.Visible = true; txtp3.Location = new Point(163, 506); txtp3.Visible = true; txtp4.Location = new Point(193, 389); txtp4.Visible = true; txtp5.Location = new Point(124, 351); txtp5.Visible = true; txtp6.Location = new Point(199, 349); txtp6.Visible = true; txtp7.Location = new Point(270, 349); txtp7.Visible = true; txtp8.Location = new Point(337, 348); txtp8.Visible = true; txtp9.Location = new Point(0, 216); txtp9.Visible = true; txtp10.Location = new Point(56, 74); txtp10.Visible = true; txtp11.Location = new Point(22, 144); txtp11.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA12")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA12; txtp1.Location = new Point(242, 476); txtp1.Visible = true; txtp2.Location = new Point(85, 442); txtp2.Visible = true; txtp3.Location = new Point(162, 505); txtp3.Visible = true; txtp4.Location = new Point(191, 389); txtp4.Visible = true; txtp5.Location = new Point(294, 380); txtp5.Visible = true; txtp6.Location = new Point(148, 233); txtp6.Visible = true; txtp7.Location = new Point(169, 162); txtp7.Visible = true; txtp8.Location = new Point(202, 83); txtp8.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA13")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA13; txtp1.Location = new Point(493, 360); txtp1.Visible = true; txtp2.Location = new Point(50, 431); txtp2.Visible = true; txtp3.Location = new Point(173, 499); txtp3.Visible = true; txtp4.Location = new Point(211, 424); txtp4.Visible = true; txtp5.Location = new Point(280, 349); txtp5.Visible = true; txtp6.Location = new Point(358, 418); txtp6.Visible = true; txtp7.Location = new Point(304, 259); txtp7.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA14")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA14; txtp1.Location = new Point(527, 358); txtp1.Visible = true; txtp2.Location = new Point(414, 347); txtp2.Visible = true; txtp3.Location = new Point(176, 381); txtp3.Visible = true; txtp4.Location = new Point(80, 252); txtp4.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA15")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA15; txtp1.Location = new Point(237, 476); txtp1.Visible = true; txtp2.Location = new Point(27, 430); txtp2.Visible = true; txtp3.Location = new Point(146, 500); txtp3.Visible = true; txtp4.Location = new Point(331, 346); txtp4.Visible = true; txtp5.Location = new Point(225, 193); txtp5.Visible = true; txtp6.Location = new Point(134, 255); txtp6.Visible = true; txtp7.Location = new Point(172, 233); txtp7.Visible = true; txtp8.Location = new Point(52, 211); txtp8.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA16")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA16; txtp1.Location = new Point(237, 476); txtp1.Visible = true; txtp2.Location = new Point(147, 497); txtp2.Visible = true; txtp3.Location = new Point(28, 422); txtp3.Visible = true; txtp4.Location = new Point(331, 332); txtp4.Visible = true; txtp5.Location = new Point(227, 193); txtp5.Visible = true; txtp6.Location = new Point(131, 211); txtp6.Visible = true; txtp7.Location = new Point(156, 191); txtp7.Visible = true; txtp8.Location = new Point(52, 167); txtp8.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA17")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA17; txtp1.Location = new Point(237, 476); txtp1.Visible = true; txtp2.Location = new Point(141, 501); txtp2.Visible = true; txtp3.Location = new Point(27, 426); txtp3.Visible = true; txtp4.Location = new Point(225, 414); txtp4.Visible = true; txtp5.Location = new Point(143, 358); txtp5.Visible = true; txtp6.Location = new Point(349, 345); txtp6.Visible = true; txtp7.Location = new Point(247, 205); txtp7.Visible = true; txtp8.Location = new Point(118, 239); txtp8.Visible = true; txtp9.Location = new Point(144, 219); txtp9.Visible = true; txtp10.Location = new Point(43, 194); txtp10.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA18")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA18; txtp1.Location = new Point(162, 475); txtp1.Visible = true; txtp2.Location = new Point(65, 306); txtp2.Visible = true; txtp3.Location = new Point(182, 160); txtp3.Visible = true; txtp4.Location = new Point(380, 236); txtp4.Visible = true; txtp5.Location = new Point(517, 146); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA19")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA19; txtp1.Location = new Point(162, 475); txtp1.Visible = true; txtp2.Location = new Point(373, 280); txtp2.Visible = true; txtp3.Location = new Point(254, 279); txtp3.Visible = true; txtp4.Location = new Point(116, 389); txtp4.Visible = true; txtp5.Location = new Point(80, 241); txtp5.Visible = true; txtp6.Location = new Point(162, 211); txtp6.Visible = true; txtp7.Location = new Point(213, 88); txtp7.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA20")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA20; txtp1.Location = new Point(162, 475); txtp1.Visible = true; txtp2.Location = new Point(476, 362); txtp2.Visible = true; txtp3.Location = new Point(59, 262); txtp3.Visible = true; txtp4.Location = new Point(237, 153); txtp4.Visible = true; txtp5.Location = new Point(329, 319); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA21")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA21; txtp1.Location = new Point(484, 364); txtp1.Visible = true; txtp2.Location = new Point(186, 505); txtp2.Visible = true; txtp3.Location = new Point(251, 439); txtp3.Visible = true; txtp4.Location = new Point(60, 374); txtp4.Visible = true; txtp5.Location = new Point(95, 248); txtp5.Visible = true; txtp6.Location = new Point(282, 249); txtp6.Visible = true; txtp7.Location = new Point(625, 299); txtp7.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA22")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA22; txtp1.Location = new Point(166, 478); txtp1.Visible = true; txtp2.Location = new Point(68, 335); txtp2.Visible = true; txtp3.Location = new Point(240, 269); txtp3.Visible = true; txtp4.Location = new Point(188, 140); txtp4.Visible = true; txtp5.Location = new Point(380, 242); txtp5.Visible = true; txtp6.Location = new Point(510, 144); txtp6.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA23")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA23; txtp1.Location = new Point(510, 364); txtp1.Visible = true; txtp2.Location = new Point(613, 290); txtp2.Visible = true; txtp3.Location = new Point(321, 430); txtp3.Visible = true; txtp4.Location = new Point(174, 508); txtp4.Visible = true; txtp5.Location = new Point(215, 364); txtp5.Visible = true; txtp6.Location = new Point(95, 343); txtp6.Visible = true; txtp7.Location = new Point(98, 244); txtp7.Visible = true; txtp8.Location = new Point(273, 239); txtp8.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA24")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA24; txtp1.Location = new Point(165, 475); txtp1.Visible = true; txtp2.Location = new Point(219, 253); txtp2.Visible = true; txtp3.Location = new Point(90, 291); txtp3.Visible = true; txtp4.Location = new Point(135, 145); txtp4.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA25")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA25; txtp1.Location = new Point(165, 475); txtp1.Visible = true; txtp2.Location = new Point(31, 112); txtp2.Visible = true; txtp3.Location = new Point(451, 233); txtp3.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA26")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA26; txtp1.Location = new Point(497, 364); txtp1.Visible = true; txtp2.Location = new Point(182, 493); txtp2.Visible = true; txtp3.Location = new Point(357, 428); txtp3.Visible = true; txtp4.Location = new Point(84, 364); txtp4.Visible = true; txtp5.Location = new Point(615, 265); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA27")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA27; txtp1.Location = new Point(497, 364); txtp1.Visible = true; txtp2.Location = new Point(190, 497); txtp2.Visible = true; txtp3.Location = new Point(312, 412); txtp3.Visible = true; txtp4.Location = new Point(145, 409); txtp4.Visible = true; txtp5.Location = new Point(208, 364); txtp5.Visible = true; txtp6.Location = new Point(128, 330); txtp6.Visible = true; txtp7.Location = new Point(613, 299); txtp7.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA28")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA28; txtp1.Location = new Point(527, 380); txtp1.Visible = true; txtp2.Location = new Point(185, 504); txtp2.Visible = true; txtp3.Location = new Point(399, 442); txtp3.Visible = true; txtp4.Location = new Point(272, 406); txtp4.Visible = true; txtp5.Location = new Point(53, 380); txtp5.Visible = true; txtp6.Location = new Point(581, 261); txtp6.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA29")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA29; txtp1.Location = new Point(218, 476); txtp1.Visible = true;
                txtp2.Location = new Point(472, 245); txtp2.Visible = true; txtp3.Location = new Point(266, 271); txtp3.Visible = true;
                txtp4.Location = new Point(705, 194);txtp4.Visible = true;
                txtp5.Location = new Point(671, 221); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA30")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA30; txtp1.Location = new Point(218, 476); txtp1.Visible = true; txtp2.Location = new Point(581, 279); txtp2.Visible = true; txtp3.Location = new Point(327, 219); txtp3.Visible = true; txtp4.Location = new Point(271, 262); txtp4.Visible = true; txtp5.Location = new Point(246, 190); txtp5.Visible = true; txtp6.Location = new Point(242, 124); txtp6.Visible = true; txtp7.Location = new Point(116, 136); txtp7.Visible = true; txtp8.Location = new Point(108, 204); txtp8.Visible = true; txtp9.Location = new Point(46, 262); txtp9.Visible = true; txtp10.Location = new Point(12, 162); txtp10.Visible = true; txtp11.Location = new Point(0, 217); txtp11.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA31")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA31; txtp1.Location = new Point(216, 467); txtp1.Visible = true; txtp2.Location = new Point(261, 262); txtp2.Visible = true; txtp3.Location = new Point(466, 244); txtp3.Visible = true; txtp4.Location = new Point(697, 214); txtp4.Visible = true; txtp5.Location = new Point(685, 237); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA32")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA32; txtp1.Location = new Point(216, 473); txtp1.Visible = true; txtp2.Location = new Point(702, 202); txtp2.Visible = true; txtp3.Location = new Point(663, 223); txtp3.Visible = true; txtp4.Location = new Point(467, 249); txtp4.Visible = true; txtp5.Location = new Point(267, 269); txtp5.Visible = true;
            }
            if (_PLANTILLA == "PLANTILLA33")
            {
                pictureEdit1.Image = IAP.Win.Properties.Resources.PLANTILLA33; txtp1.Location = new Point(216, 473); txtp1.Visible = true; txtp2.Location = new Point(443, 154); txtp2.Visible = true; txtp3.Location = new Point(297, 212); txtp3.Visible = true; txtp4.Location = new Point(195, 285); txtp4.Visible = true; txtp5.Location = new Point(248, 117); txtp5.Visible = true; txtp6.Location = new Point(188, 167); txtp6.Visible = true; txtp7.Location = new Point(97, 224); txtp7.Visible = true; txtp8.Location = new Point(95, 120); txtp8.Visible = true; txtp9.Location = new Point(76, 166); txtp9.Visible = true;
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
            txtp13.Text = _objParametrosOS.p13.ToString();
            txtp14.Text = _objParametrosOS.p14.ToString();
            txtp15.Text = _objParametrosOS.p15.ToString();
            txtp16.Text = _objParametrosOS.p16.ToString();
            txtp17.Text = _objParametrosOS.p17.ToString();
            txtp18.Text = _objParametrosOS.p18.ToString();
            txtp19.Text = _objParametrosOS.p19.ToString();
            txtp20.Text = _objParametrosOS.p20.ToString();
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
                    _objParametrosOS.p13 = Convert.ToDouble(txtp13.Text.Trim() == string.Empty ? "0" : txtp13.Text.Trim());
                    _objParametrosOS.p14 = Convert.ToDouble(txtp14.Text.Trim() == string.Empty ? "0" : txtp14.Text.Trim());
                    _objParametrosOS.p15 = Convert.ToDouble(txtp15.Text.Trim() == string.Empty ? "0" : txtp15.Text.Trim());
                    _objParametrosOS.p16 = Convert.ToDouble(txtp16.Text.Trim() == string.Empty ? "0" : txtp16.Text.Trim());
                    _objParametrosOS.p17 = Convert.ToDouble(txtp17.Text.Trim() == string.Empty ? "0" : txtp17.Text.Trim());
                    _objParametrosOS.p18 = Convert.ToDouble(txtp18.Text.Trim() == string.Empty ? "0" : txtp18.Text.Trim());
                    _objParametrosOS.p19 = Convert.ToDouble(txtp19.Text.Trim() == string.Empty ? "0" : txtp19.Text.Trim());
                    _objParametrosOS.p20 = Convert.ToDouble(txtp20.Text.Trim() == string.Empty ? "0" : txtp20.Text.Trim());

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
