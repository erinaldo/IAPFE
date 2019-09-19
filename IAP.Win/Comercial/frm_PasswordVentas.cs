using DevExpress.Utils;
using IAP.Win.Clases;
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
using IAP.BL;
namespace IAP.Win.Comercial
{
    public partial class frm_PasswordVentas : Form
    {
        List<ClaveVenta> _LSTCLAVE_VENTAS = new List<ClaveVenta>();

        public frm_PasswordVentas()
        {
            InitializeComponent();
        }

        private void frm_PasswordVentas_Activated(object sender, EventArgs e)
        {
            //using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Cargando Información>>>>"))
            //{
          
            //}
        }
        private void frm_PasswordVentas_Load(object sender, EventArgs e)
        {
            OnFormatGrid();
            this.btnguardar.Enabled = false;
            CargarGrilla();
        }

        #region Procedimientos
        private void OnFormatGrid()
        {

            gvwpassword.Columns.Clear();
            gvwpassword.OptionsView.ColumnAutoWidth = false;
            gvwpassword.OptionsBehavior.ReadOnly = false;
            gvwpassword.OptionsBehavior.Editable = true;
            gvwpassword.OptionsView.ColumnAutoWidth = false;
            gvwpassword.OptionsView.ShowGroupPanel = false;

            gvwpassword.OptionsCustomization.AllowQuickHideColumns = false;
            //gvwlista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gvwpassword.OptionsSelection.EnableAppearanceFocusedCell = false;
            gvwpassword.OptionsMenu.EnableColumnMenu = false;   // menu contextual de columnas
            //gvwlista.OptionsView.ColumnAutoWidth = true;

            CreateGridColumn(gvwpassword, "Fecha", "Fecha", 1, DevExpress.Utils.FormatType.DateTime,"dd.MM.yyyy", true, 100);
            CreateGridColumn(gvwpassword, "Clave", "Clave", 2, DevExpress.Utils.FormatType.None, "x", true, 100);
            CreateGridColumn(gvwpassword, "Activo", "Activo", 3, DevExpress.Utils.FormatType.None, "x", true, 100);
            

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

        private void LimpiarControles()
        {
            btnguardar.Enabled = true;
            this.txtfecha.Text = DateTime.Now.ToShortDateString();
            txtclave.Text = string.Empty;
            txtclave.Focus();
        }

        private void CargarGrilla()
        {
            _LSTCLAVE_VENTAS = BL.Comercial.ObtenerClaveVenta(Global.vUserBaseDatos, Global.vUsuarioBD, Global.vPasswordBD, Global.vIpServidor);
            gcpassword.DataSource = _LSTCLAVE_VENTAS;
        }
        #endregion

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtclave.Text.Trim()==string.Empty)
                {
                    MessageBox.Show("El campo clave esta vacio, debe ingresar una clave valida", "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Desea registrar la nueva clave", "Sistema Administrativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Guardando Información>>>>"))
                    {
                        BL.Comercial.RegistrarClaveVenta(txtclave.Text.Trim().ToUpper(), Global.vUserBaseDatos, Global.vUsuarioBD, Global.vPasswordBD, Global.vIpServidor);
                    }
                    MessageBox.Show("Se registro la clave correctamente", "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla();
                }
                btnguardar.Enabled = false;
                txtclave.Text = string.Empty;
                txtfecha.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
