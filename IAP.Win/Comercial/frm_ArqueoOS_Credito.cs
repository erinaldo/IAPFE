using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace IAP.Win.Comercial
{
    public partial class frm_ArqueoOS_Credito : Form
    {
        public DataSet _DsPendientes= new DataSet();
        public string _Cliente;
        public frm_ArqueoOS_Credito()
        {
            InitializeComponent();
        }

        private void frm_ArqueoOS_Credito_Load(object sender, EventArgs e)
        {
            this.Text = "Documentos Pendientes: " + _Cliente.Trim().ToUpper();
            gcEstadoCuenta.DataSource = _DsPendientes.Tables[0];
            gvwEstadoCuenta.Columns["Total"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Total", "Importe = {0:n2}");
            gvwEstadoCuenta.Columns["Saldo"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Saldo", "Saldo = {0:n2}");
            gvwEstadoCuenta.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Total",gvwEstadoCuenta.Columns["Total"], "Importe = {0:n2}");
            gvwEstadoCuenta.GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Saldo", gvwEstadoCuenta.Columns["Saldo"], "Saldo = {0:n2}");

        }

        private void gvwEstadoCuenta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gView = (GridView)sender;
            if (!gView.IsValidRowHandle(e.RowHandle)) return;
            int parent = gView.GetParentRowHandle(e.RowHandle);
            if (gView.IsGroupRow(parent))
            {
                for (int i = 0; i < gView.GetChildRowCount(parent); i++)
                    if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
                    {
                        e.Appearance.BackColor = i % 2 == 0 ? Color.White : Color.Silver;
                        e.Appearance.ForeColor = Color.DarkBlue;
                    }

            }
            else {
                e.Appearance.ForeColor = Color.DarkBlue;
                e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.White : Color.Silver;
                    }
            
        }
    }
}
