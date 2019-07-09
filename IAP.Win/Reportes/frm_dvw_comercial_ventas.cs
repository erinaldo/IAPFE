using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using IAP.BL;
namespace IAP.Win.Reportes
{
    public partial class frm_dvw_comercial_ventas : Form
    {
        BL.Comercial blComercial = new BL.Comercial();
        public frm_dvw_comercial_ventas()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            using (WaitDialogForm waitDialog = new WaitDialogForm("Cargando Tablero", "Espere por favor..."))
            {
                
                dashboardViewer1.LoadDashboard(blComercial.ObtenerXmlDashBoardV2("Comercial_Ventas", Global.vUserBaseDatos));
                dashboardViewer1.BeginUpdateParameters();

                dashboardViewer1.Parameters["Parámetro1"].SelectedValue = Convert.ToDateTime(dtfechaI.EditValue).ToShortDateString();
                dashboardViewer1.Parameters["Parámetro2"].SelectedValue = Convert.ToDateTime(dtfechaF.EditValue).ToShortDateString();
                dashboardViewer1.EndUpdateParameters();
            }
            
            
            
            //dvwcxc.LoadDashboard(BL.Comercial.ObtenerXmlDashBoard("DocumentosCxC", Global.vUserBaseDatos));
        }

        private void dashboardViewer1_CustomParameters(object sender, DevExpress.DashboardCommon.CustomParametersEventArgs e)
        {
            //var custIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "Parámetro1");
            //if (custIDParameter != null)
            //{
            //    custIDParameter.Value = "01/01/2019";
            //}
            //var custIDParameter2 = e.Parameters.FirstOrDefault(p => p.Name == "Parámetro2");
            //if (custIDParameter2 != null)
            //{
            //    custIDParameter2.Value = "01/01/2010";
            //}
        }

        private void frm_dvw_comercial_ventas_Load(object sender, EventArgs e)
        {
            dtfechaI.EditValue = DateTime.Now;
            dtfechaF.EditValue = DateTime.Now;
        }
    }
}
