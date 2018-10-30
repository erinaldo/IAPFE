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

namespace IAP.Win.Comercial
{
    public partial class frm_OrdenServicio : Form
    {
        List<OrdenServicio> _lstordenservicio = new List<OrdenServicio>();
        BL.Comercial eCom = new BL.Comercial();

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
            CreateGridColumn(gvwcabecera, "Fecha", "fecha", 2, FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwcabecera, "Tipo", "cdocu", 3, FormatType.None, "x", false, 60);
            CreateGridColumn(gvwcabecera, "NroDocumento", "ndocu", 4, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Codigo Cliente", "codcli", 5, FormatType.None, "x", false, 40);
            CreateGridColumn(gvwcabecera, "Nombre cliente", "nomcli", 6, FormatType.None, "x", true, 100);
            CreateGridColumn(gvwcabecera, "Ruc", "ruccli", 7, FormatType.None, "x", true, 100);
            
            CreateGridColumn(gvwcabecera, "Tipo Cambio", "tcam", 15, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total Neto", "tota", 16, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total IGV", "toti", 17, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "Total", "totn", 18, DevExpress.Utils.FormatType.Numeric, "d2", true, 80);
            CreateGridColumn(gvwcabecera, "flagEstado", "flag", 19, DevExpress.Utils.FormatType.Numeric, "d", true, 80);
            CreateGridColumn(gvwcabecera, "Estado", "flagnombre", 20, DevExpress.Utils.FormatType.Numeric, "d", true, 80);
            

            gvwcabecera.EndUpdate();

            


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

            

            if (withField != 0)
                gc.Width = withField;



            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        private void ObtenerOrdenesServicio()
        {
            //List<OrdenServicio> lst = new List<OrdenServicio>();
            _lstordenservicio = eCom.ObtenerOrdenesServicio(Convert.ToDateTime(dtfechainicial.EditValue), Convert.ToDateTime(dtfechafinal.EditValue),
                txtdocumento.Text, txtcliente.Text, Global.vUserBaseDatos);
            gccabecera.DataSource = _lstordenservicio;

            //List<TipoDocumento> ls = BL.Comercial.ObtenerTipoDocumento(Global.vUserBaseDatos);
            //cbotipodocumento.Properties.DisplayMember = "Nomdocu";
            //cbotipodocumento.Properties.ValueMember = "Cdocu";
            //cbotipodocumento.Properties.DataSource = ls;

            //cbotipodocumento.CheckAll();
        }

        
       
       
      
        #endregion


        public frm_OrdenServicio()
        {
            InitializeComponent();
        }

        private void frm_OrdenServicio_Load(object sender, EventArgs e)
        {
            try
            {
                OnFormatGrid();
                
                dtfechainicial.EditValue = DateTime.Now;
                dtfechafinal.EditValue = DateTime.Now;
                ObtenerOrdenesServicio();

                List<Cliente> lst = new List<Cliente>();
                lst = eCom.ObtenerClientesOS(Global.vUserBaseDatos);
                lecliente.Properties.DataSource = lst;
                lecliente.Properties.ValueMember = "CodCli";
                lecliente.Properties.DisplayMember = "Nombre";
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerOrdenesServicio();

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

                    case "mnuasignar":
                        {
                            panelcliente.Visible = true;
                            //List<OrdenServicio> lst = new List<OrdenServicio>();
                            //lst = _lstordenservicio.Where(y => y.FlgCheck == true).ToList();
                        }
                        break;
                    
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            panelcliente.Visible = false;
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrdenServicio> lst = new List<OrdenServicio>();
                lst = _lstordenservicio.Where(y => y.FlgCheck == true).ToList();
                lst.ForEach(x => x.codcli = lecliente.EditValue.ToString());
                eCom.ActualizarClienteOS(lst, Global.vUserBaseDatos);
                panelcliente.Visible = false;
                MessageBox.Show("Se realizo los cambios correctamente", "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenerOrdenesServicio();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Utilitario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
    }
}
