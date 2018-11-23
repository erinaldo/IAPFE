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
using System.Net;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Grid;
using IAP.BE;
using IAP.BL;

using DevExpress.XtraGrid;
using IAP.Win.Clases;


namespace IAP.Win.Creditos
{
    public partial class frmLetrasEmitidas : Form
    {
        BCreditos objCreditos = new BCreditos();
        List<LetrasEmitidas> _lstLetrasEmitidas = new List<LetrasEmitidas>();
        public frmLetrasEmitidas()
        {
            InitializeComponent();
        }

        #region Procedimientos

        private void ObtenerLetras()
        {
            
            _lstLetrasEmitidas = objCreditos.Obtener_LetrasElectronicas(
                Convert.ToDateTime(dtfechainicial.EditValue),
                Convert.ToDateTime(dtfechafinal.EditValue),
                txtcliente.Text.Trim(),
                txtnroletra.Text.Trim(),
                Global.vUserBaseDatos);

            gcletras.DataSource = _lstLetrasEmitidas;
        }
        private void OnFormatGrid()
        {
            
            gvwletras.Columns.Clear();
            gvwletras.OptionsView.ColumnAutoWidth = false;
            gvwletras.OptionsBehavior.ReadOnly = false;
            gvwletras.OptionsBehavior.Editable = true;
            gvwletras.OptionsView.ColumnAutoWidth = false;
            gvwletras.OptionsView.ShowGroupPanel = false;

            gvwletras.OptionsCustomization.AllowQuickHideColumns = false;
            //gvwlista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gvwletras.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwletras.OptionsMenu.EnableColumnMenu = false;   // menu contextual de columnas
            //gvwlista.OptionsView.ColumnAutoWidth = true;

            CreateGridColumn(gvwletras, "Fecha", "Fecha", 1, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwletras, "Cdocu", "Cdocu", 2, DevExpress.Utils.FormatType.None, "x", false, 100);
            CreateGridColumn(gvwletras, "Nro.Letra", "Ndocu", 3, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Crefe", "Crefe", 4, DevExpress.Utils.FormatType.None, "x", false, 100);
            CreateGridColumn(gvwletras, "Doc.Referencia", "Nrefe", 5, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Codcli", "Codcli", 6, DevExpress.Utils.FormatType.None, "x", false, 70);
            CreateGridColumn(gvwletras, "Cliente", "Nomcli", 7, DevExpress.Utils.FormatType.None, "x", true, 300);
            CreateGridColumn(gvwletras, "RUC", "Ruccli", 8, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Monto", "Monto", 9, DevExpress.Utils.FormatType.Numeric, "f4", true, 120);
            CreateGridColumn(gvwletras, "Saldo", "Saldo", 10, DevExpress.Utils.FormatType.Numeric, "f4", true, 120);
            CreateGridColumn(gvwletras, "Glosa", "Glosa", 11, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Dias", "Dias", 12, DevExpress.Utils.FormatType.Numeric, "f2", true, 120);
            CreateGridColumn(gvwletras, "Fecha Vencimiento", "Fven", 13, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwletras, "TipoCambio", "Tcam", 14, DevExpress.Utils.FormatType.Numeric, "f4", true, 120);
            CreateGridColumn(gvwletras, "Moneda", "Mone", 15, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "EstadoLetra", "Nomest", 16, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "SubEstado", "Nomsub", 17, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Nombcox", "Nombcox", 18, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Distrito", "Nomdis", 19, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Provincia", "Nompro", 20, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Dirección", "Dircli", 21, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Coddis", "Coddis", 22, DevExpress.Utils.FormatType.None, "x", false, 100);
            CreateGridColumn(gvwletras, "Codpro", "Codpro", 23, DevExpress.Utils.FormatType.None, "x", false, 100);
            CreateGridColumn(gvwletras, "Telefono", "Telcli", 24, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "RUC Aval", "Rucava", 25, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Aval", "Nomava", 26, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Dirección Aval", "Dirava", 27, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwletras, "Telefono Aval", "Telava", 28, DevExpress.Utils.FormatType.None, "x", true, 100);


            //CreateGridColumn(tp3_gvwsalidas, "Kardex", "Kardex", 9, DevExpress.Utils.FormatType.None, "x", true, 60);

        }
        private void CreateGridColumn(DevExpress.XtraGrid.Views.Grid.GridView grilla, string caption, string field, int visibleindex, DevExpress.Utils.FormatType formatType, string formatString, bool visible, int withField = 0)
        {
            DevExpress.XtraGrid.Columns.GridColumn gc = grilla.Columns.Add();
            gc.Caption = caption;
            gc.FieldName = field;
            gc.VisibleIndex = visibleindex;
            gc.Visible = visible;
            gc.AppearanceHeader.Options.UseTextOptions = true;
            gc.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gc.OptionsColumn.AllowEdit = false;

            

            if (withField != 0)
                gc.Width = withField;
            else
                gc.Visible = false;

            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        

        #endregion
        private void frmLetrasEmitidas_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                ObtenerLetras();
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

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                NumLetra objProcedimientosGrales = new NumLetra();
                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gcletras.MainView;
                if (x.RowCount <= 0) return;
                gcletras.ContextMenuStrip.Visible = false;

                List<LetrasEmitidas> lstletra = new List<LetrasEmitidas>();
                string cdocu = gvwletras.GetFocusedRowCellValue("Cdocu").ToString();
                string ndocu = gvwletras.GetFocusedRowCellValue("Ndocu").ToString();

                switch (e.ClickedItem.Name)
                {

                    case "mnuimprimir":
                        {
                            lstletra = _lstLetrasEmitidas.Where(letra => letra.Cdocu == cdocu && letra.Ndocu == ndocu).ToList();
                            lstletra.ForEach(letra => letra.NumerosLetras = objProcedimientosGrales.Convertir(
                                letra.Monto.ToString(), true
                                ));
                            frmVisorLetraEmitida frm = new frmVisorLetraEmitida(lstletra);
                            frm.ShowDialog();
                            
                        }
                        break;
                    
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ObtenerLetras();
        }
    }
}
