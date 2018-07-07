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

namespace IAP.Win.Comercial
{
    public partial class frm_ConsultaEstadoFe : Form
    {
        private SunatRespuestaFBN _eRes = new SunatRespuestaFBN();
        public frm_ConsultaEstadoFe(SunatRespuestaFBN e)
        {
            _eRes = e;
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ConsultaEstadoFe_Load(object sender, EventArgs e)
        {
            txtaceptado.Text = _eRes.aceptada_por_sunat== null ? string.Empty : _eRes.aceptada_por_sunat.ToString();
            txtdescripcion.Text = _eRes.sunat_description==null ? string.Empty : _eRes.sunat_description.ToString();
            txtenlace.Text = _eRes.enlace==null ? string.Empty : _eRes.enlace.ToString();
            txtnumero.Text = _eRes.numero==null ? string.Empty : _eRes.numero.ToString();
            //txtnumeroticket.Text=_eRes.
            txttipodoc.Text = _eRes.tipo_de_comprobante.ToString();
            
        }
    }
}
