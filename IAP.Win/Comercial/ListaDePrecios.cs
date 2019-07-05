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

using DevExpress.XtraGrid;
using IAP.Win.Clases;
using System.IO;

namespace IAP.Win
{
    public partial class ListaDePrecios : Form
    {
        List<listaprecio> _LSTLISTADEPRECIOS = new List<listaprecio>();

        public ListaDePrecios()
        {
            InitializeComponent();
        }

        private void ListaDePrecios_Activated(object sender, EventArgs e)
        {
            
        }

        #region procedimientos
        private void OnFormatGrid()
        {

            gvwlista.Columns.Clear();
            gvwlista.OptionsView.ColumnAutoWidth = false;
            gvwlista.OptionsBehavior.ReadOnly = false;
            gvwlista.OptionsBehavior.Editable = true;
            gvwlista.OptionsView.ColumnAutoWidth = false;
            gvwlista.OptionsView.ShowGroupPanel = false;

            gvwlista.OptionsCustomization.AllowQuickHideColumns = false;
            //gvwlista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gvwlista.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwlista.OptionsMenu.EnableColumnMenu = false;   // menu contextual de columnas
            //gvwlista.OptionsView.ColumnAutoWidth = true;

            CreateGridColumn(gvwlista, "", "FlgCheck", 1, DevExpress.Utils.FormatType.None, "x", true, 25);
            CreateGridColumn(gvwlista, "CodigoSistema", "Codi", 2, DevExpress.Utils.FormatType.None, "x", false, 100);
            CreateGridColumn(gvwlista, "CodigoEmpresa", "Codf", 3, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwlista, "Marca", "Marca", 4, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwlista, "Descripcion", "Descripcion", 5, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwlista, "U.Medida", "Umedida", 6, DevExpress.Utils.FormatType.None, "x", true, 70);
            CreateGridColumn(gvwlista, "Stock", "Stockdisponible", 7, DevExpress.Utils.FormatType.Numeric, "f2", true, 70);
            CreateGridColumn(gvwlista, "U.CostoCompraSoles", "Ultcostocomprasoles", 8, DevExpress.Utils.FormatType.Numeric, "f2", Global.UserAdministrador == true ? true : false, 100);
            CreateGridColumn(gvwlista, "U.CostoCompraDolar", "Ultcostocompradolar", 9, DevExpress.Utils.FormatType.Numeric, "f2", Global.UserAdministrador == true ? true : false, 100);
            CreateGridColumn(gvwlista, "PrecioVenta S/", "Precioventasoles", 10, DevExpress.Utils.FormatType.Numeric, "f2", true, 100);
            CreateGridColumn(gvwlista, "Precioventa $", "Precioventadolar", 11, DevExpress.Utils.FormatType.Numeric, "f2", true, 100);
            CreateGridColumn(gvwlista, "Moneda", "Moneda", 12, DevExpress.Utils.FormatType.None, "x", true, 70);
            CreateGridColumn(gvwlista, "%Incremento", "Valorventaingreso", 13, DevExpress.Utils.FormatType.Numeric, "f2", Global.UserAdministrador == true ? true : false, 120);
            CreateGridColumn(gvwlista, "Fecha Incremento", "Fechavalorventa", 14, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, 100);
            CreateGridColumn(gvwlista, "Tipo de Cambio", "Tcventa", 15, DevExpress.Utils.FormatType.Numeric, "f4", false, 120);
            CreateGridColumn(gvwlista, "Fecha TipoCambio", "Fechatc", 16, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", false, 100);


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

            if (field == "Valorventaingreso" && grilla.Name == "gvwlista")
            {
                gc.OptionsColumn.AllowEdit = true;
                DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
                textEdit.Mask.MaskType = MaskType.Numeric;
                textEdit.Mask.EditMask = "f2";
                gc.ColumnEdit = textEdit;
            }

            if (field == "Ultcostocomprasoles" || field == "Ultcostocompradolar" && grilla.Name == "gvwlista")
            {
                gc.MinWidth = 150;
            }

            if (field == "Umedida" || field == "Moneda" || field == "Stock" && grilla.Name == "gvwlista")
            {
                gc.MinWidth = 70;
            }

            if (field == "Descripcion" && grilla.Name == "gvwlista")
            {
                gc.MinWidth = 190;
            }

            if (field == "FlgCheck" && grilla.Name == "gvwlista")
            {
                gc.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            }

            if (withField != 0)
                gc.Width = withField;
            else
                gc.Visible = false;

            gc.DisplayFormat.FormatType = formatType;
            if (formatType == DevExpress.Utils.FormatType.Custom)
                gc.DisplayFormat.Format = new BaseFormatter();
            gc.DisplayFormat.FormatString = formatString;
        }

        private void Habilitarbotones()
        {
            btnguardar.Enabled = Global.UserAdministrador == true ? true : false;
            btnincrementomasivo.Enabled = Global.UserAdministrador == true ? true : false;
           
        }
        private void LLenar_Familia()
        {
            DataSet ds_fam = new DataSet();
            ds_fam = BL.Tablas_Maestras.Familias(Global.vUserBaseDatos);
            this.cmbfamilia.Properties.DisplayMember = "nomfam";
            this.cmbfamilia.Properties.ValueMember = "codfam";
            this.cmbfamilia.Properties.DataSource = ds_fam.Tables[0];
        }
        private void Llenar_SubFamilia(string familias)
        {
            DataSet ds_Sfam = new DataSet();
            ds_Sfam = BL.Tablas_Maestras.SubFamilias(familias, Global.vUserBaseDatos);
            this.cmbsubfamilia.Properties.DisplayMember = "nomsub";
            this.cmbsubfamilia.Properties.ValueMember = "codsub";
            this.cmbsubfamilia.Properties.DataSource = ds_Sfam.Tables[0];
        }
        private void Llenar_Grupos(string subfamilias)
        {
            DataSet ds_gru = new DataSet();
            ds_gru = BL.Tablas_Maestras.Listado_Grupos(subfamilias, Global.vUserBaseDatos);
            this.cmbgrupo.Properties.DisplayMember = "nomgru";
            this.cmbgrupo.Properties.ValueMember = "codgru";
            this.cmbgrupo.Properties.DataSource = ds_gru.Tables[0];
        }

        private void BuscarArticulos()
        {
            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Cargando Información>>>>"))
            {
                _LSTLISTADEPRECIOS = BL.Comercial.ObtenerListadePrecios(cmbfamilia.EditValue == null ? string.Empty : cmbfamilia.EditValue.ToString(),
                    cmbsubfamilia.EditValue == null ? string.Empty : cmbsubfamilia.EditValue.ToString(),
                    cmbgrupo.EditValue == null ? string.Empty : cmbgrupo.EditValue.ToString(), "S",
                    chkcostomayorcero.Checked == true ? 1 : 0,
                    chkstockmayorcero.Checked == true ? 1 : 0,
                    txtcodf.Text.Trim(),txtbusqueda.Text.Trim(),
                    Global.vUserBaseDatos);
                if (_LSTLISTADEPRECIOS.Count() > 0)
                {
                    txttc.Text = _LSTLISTADEPRECIOS.Select(x => x.Tcventa.ToString()).First();
                    txtfechatc.Text = Convert.ToDateTime(_LSTLISTADEPRECIOS.Select(x => x.Fechatc.ToString()).First()).ToShortDateString();
                }

                gclista.DataSource = _LSTLISTADEPRECIOS;
            }

        }
        #endregion

        private void cmbfamilia_EditValueChanged(object sender, EventArgs e)
        {
            cmbgrupo.DeselectAll();
            cmbsubfamilia.DeselectAll();
            Llenar_SubFamilia(cmbfamilia.EditValue.ToString());
        }

        private void btnobtenercostos_Click(object sender, EventArgs e)
        {
            BuscarArticulos();

        }
        

        private void gvwlista_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.AppStarting;

                if (gvwlista.RowCount == 0) return;
                if (e.Column.FieldName != "FlgCheck") return;

                bool flg = Convert.ToBoolean(gvwlista.GetRowCellValue(e.RowHandle, "FlgCheck"));
                gvwlista.SetRowCellValue(e.RowHandle, "FlgCheck", !flg);
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

        private void cmbsubfamilia_EditValueChanged(object sender, EventArgs e)
        {
            cmbgrupo.DeselectAll();
            Llenar_Grupos(cmbsubfamilia.EditValue.ToString());
        }

        private void menu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.AppStarting;
                var x = gclista.MainView;
                if (x.RowCount <= 0) return;
                gclista.ContextMenuStrip.Visible = false;

                
                switch (e.ClickedItem.Name)
                {

                    case "Marcatodo":
                        {

                            _LSTLISTADEPRECIOS.ForEach(y => y.FlgCheck = true);
                            gclista.RefreshDataSource();
                        }
                        break;
                    case "Limpiatodo":
                        {
                            _LSTLISTADEPRECIOS.ForEach(y => y.FlgCheck = false);
                            gclista.RefreshDataSource();
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

        private void gvwlista_ShownEditor(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.BaseEdit editor = gvwlista.ActiveEditor;
            editor.BackColor = Color.LightYellow;
        }

        private void gvwlista_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Valorventaingreso")
            {
                e.Appearance.BackColor = SystemColors.Info;
                e.Appearance.BackColor2 = SystemColors.Info;
            }
            else if (e.Column.FieldName == "Precioventasoles")
            {
                e.Appearance.BackColor = Color.LightBlue;
                e.Appearance.BackColor2 = Color.LightBlue;
            }
            else if (e.Column.FieldName == "Precioventadolar")
            {
                e.Appearance.BackColor = Color.MediumSpringGreen;
                e.Appearance.BackColor2 = Color.MediumSpringGreen;
            }
            else
            {
                e.Appearance.BackColor = Color.Transparent;
                e.Appearance.BackColor2 = Color.Transparent;
            }
        }

        private void gvwlista_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            string codi = gvwlista.GetFocusedRowCellValue("Codi").ToString();
            double vv = Convert.ToDouble(gvwlista.GetFocusedRowCellValue("Valorventaingreso"));
            if (vv > 0)
            {
                _LSTLISTADEPRECIOS.Where(x => x.Codi==codi).ToList().ForEach(y => y.FlgCheck = true);
            }
            //else
            //{
            //    if (rbtnincrementop.Checked && Convert.ToBoolean(gvwlista.GetFocusedRowCellValue("FlgCheck")))
            //        _LSTLISTADEPRECIOS.Where(x => x.Codi == codi).ToList().ForEach(y => y.FlgCheck = true);
            //    else
            //        _LSTLISTADEPRECIOS.Where(x => x.Codi == codi).ToList().ForEach(y => y.FlgCheck = false);
                
            //}
            gclista.RefreshDataSource();
        }

        private void btnincrementomasivo_Click(object sender, EventArgs e)
        {
            //if (rbtnincrementom.Checked)
            {
                if (Convert.ToDouble(txtincremento.Text.Trim()==string.Empty ? "0" : txtincremento.Text) <= 0)
                    return;

                if (MessageBox.Show("Desea agregar precio, a todos los articulos de esta vista?", "Sistema Administrativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   


                    //_LSTLISTADEPRECIOS.ForEach(x => x.FlgCheck = true);
                    //gclista.RefreshDataSource();
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Guardando Información>>>>"))
                    {


                        //List<listaprecio> lista = _LSTLISTADEPRECIOS.Where(x => x.FlgCheck == true && x.Stockdisponible>0 && x.Ultcostocompradolar>0 && x.Ultcostocomprasoles>0).ToList();
                        List<listaprecio> lista = _LSTLISTADEPRECIOS.Where(x => x.FlgCheck == true && x.Ultcostocompradolar > 0 && x.Ultcostocomprasoles > 0).ToList();
                        lista.ForEach(x => x.Valorventaingreso = Convert.ToDouble(txtincremento.Text));
                        
                        BL.Comercial.RegistrarListaPrecios(lista, Global.vUserBaseDatos);
                    }
                    MessageBox.Show("Se registro correctamente la lista", "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarArticulos();
                }
            }
            //else
            //{
            //    if (MessageBox.Show("Desea incrementar el " + txtincremento.Text + " % , a todos los articulos seleccionados?", "Sistema Administrativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        foreach (listaprecio lst in _LSTLISTADEPRECIOS)
            //        {
            //            if(lst.FlgCheck)
            //            {
            //                if (lst.Moneda == "S")
            //                    lst.Valorventaingreso = lst.Ultcostocomprasoles * (1 + Convert.ToDouble(txtincremento.Text) / 100);
            //                else
            //                    lst.Valorventaingreso = lst.Ultcostocompradolar * (1 + Convert.ToDouble(txtincremento.Text) / 100);
            //                lst.FlgCheck = true;
            //                gclista.RefreshDataSource();
            //            }
                        
            //        }
            //    }
            //}

        }

        private void txtcodf_EditValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbgrupo.Properties.Items.Count; i++)
                cmbgrupo.Properties.Items[i].CheckState = CheckState.Unchecked;
            for (int i = 0; i < cmbsubfamilia.Properties.Items.Count; i++)
                cmbsubfamilia.Properties.Items[i].CheckState = CheckState.Unchecked;
            for (int i = 0; i < cmbfamilia.Properties.Items.Count; i++)
                cmbfamilia.Properties.Items[i].CheckState = CheckState.Unchecked;
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(_LSTLISTADEPRECIOS.Where(x=> x.FlgCheck==true).Count()==0)
            {
                MessageBox.Show("Debe seleccionar e ingresar almenos un articulo con su precio", "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Desea registrar los precios de los items seleccionados?,solo se registraran los articulos con valor venta mayor a cero", "Sistema Administrativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Guardando Información>>>>"))
                    {
                        List<listaprecio> lista = _LSTLISTADEPRECIOS.Where(x => x.FlgCheck == true && x.Valorventaingreso>0).ToList();
                        BL.Comercial.RegistrarListaPrecios(lista, Global.vUserBaseDatos);
                    }
                    MessageBox.Show("Se registro correctamente la lista", "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarArticulos();
                }
            }
        }

        private void txtbusqueda_EditValueChanged(object sender, EventArgs e)
        {
            //if(_LSTLISTADEPRECIOS.Count()>0)
            //{
            //    gclista.DataSource=
            //    _LSTLISTADEPRECIOS.Where(x => x.Descripcion.ToUpper().Contains(txtbusqueda.Text.ToUpper())).ToList();
            //}
        }

        private void gvwlista_KeyDown(object sender, KeyEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (GridView)sender;
            if( view.FocusedColumn.FieldName == "FlgCheck" && e.KeyCode==Keys.Enter)
            {
                if(Convert.ToBoolean(view.GetFocusedRowCellValue("FlgCheck")))
                    view.SetFocusedRowCellValue("FlgCheck", false);
                else
                    view.SetFocusedRowCellValue("FlgCheck", true);
            }
                

        }

        private void ListaDePrecios_Load(object sender, EventArgs e)
        {
            try
            {
                LLenar_Familia();
                OnFormatGrid();
                Habilitarbotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BuscarArticulos();
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if(_LSTLISTADEPRECIOS.Any())
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Xls 2007 (*.xls)|*.txt|Xls 2010 (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        // Code to write the stream goes here.
                        myStream.Close();
                        gclista.ExportToXlsx(saveFileDialog1.FileName);
                        
                    }
                }
            }
        }
    }
}
