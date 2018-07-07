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
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using System.IO;
namespace IAP.Win
{
    public partial class frm_cdn : Form
    {
        string familia;
        public frm_cdn()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_cdn_Load(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.Editable = false;
            LLenar_Familia();
            LLenar_Vendedor();
        }
        private void LLenar_Familia()
        {
            DataSet ds_fam = new DataSet();
            ds_fam = BL.Tablas_Maestras.Familias(Global.vUserBaseDatos);
            this.LookUpEdit_Familia.Properties.DataSource = ds_fam.Tables[0];
            this.LookUpEdit_Familia.Properties.DisplayMember = "nomfam";
            this.LookUpEdit_Familia.Properties.ValueMember = "codfam";
            this.LookUpEdit_Familia.EditValue = null;
        }

        private void Llenar_SubFamilia(string familias)
        {
            this.lookUpEdit_SubFam.Properties.Items.Clear();
            this.lookUpEdit_SubFam.Text = string.Empty;

            DataSet ds_Sfam = new DataSet();
            ds_Sfam = BL.Tablas_Maestras.SubFamilias(familias,Global.vUserBaseDatos);
            this.lookUpEdit_SubFam.Properties.DataSource = ds_Sfam.Tables[0];
            this.lookUpEdit_SubFam.Properties.DisplayMember = "nomsub";
            this.lookUpEdit_SubFam.Properties.ValueMember = "codsub";
            this.lookUpEdit_SubFam.EditValue = null;
        }

        private void LLenar_Vendedor()
        {
            DataSet ds_fam = new DataSet();
            ds_fam = BL.Tablas_Maestras.Vendedores(Global.vUserBaseDatos);
            this.lookUpEdit_Vendedor.Properties.DataSource = ds_fam.Tables[0];
            this.lookUpEdit_Vendedor.Properties.DisplayMember = "nomven";
            this.lookUpEdit_Vendedor.Properties.ValueMember = "codven";
            this.lookUpEdit_Vendedor.EditValue = null;
        }

        private void LookUpEdit_Familia_EditValueChanged(object sender, EventArgs e)
        {
            
            if (LookUpEdit_Familia.Text != string.Empty && LookUpEdit_Familia.EditValue != null)
            {
                familia = LookUpEdit_Familia.EditValue.ToString();
                Llenar_SubFamilia(familia);
            }
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Cargando Información>>>>"))
            {
                DataSet ds_cdn = new DataSet();
                ds_cdn = BL.Comercial.BL_CDN(dtpfechai.Text, dtpfechaf.Text, lookUpEdit_Vendedor.EditValue.ToString(), LookUpEdit_Familia.EditValue.ToString(), lookUpEdit_SubFam.EditValue.ToString(), Global.vUserBaseDatos);
                gc_cdn.DataSource = ds_cdn.Tables[0];
                gridView1.OptionsView.ColumnAutoWidth = false;
                gridView1.BestFitColumns();
                //gridView1.Columns[24].AppearanceCell.BackColor = Color.Sienna;
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            exportar_dtg_to_excel();
        }
        public void exportar_dtg_to_excel()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            // saveDialog.FileName = nombre;
            //using (SaveFileDialog saveDialog = new SaveFileDialog())

            //saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = Path.GetExtension(exportFilePath);
                switch (fileExtenstion)
                {
                    case ".xls":
                        gc_cdn.ExportToXls(exportFilePath);
                        break;
                    case ".xlsx":
                        gc_cdn.ExportToXlsx(exportFilePath);
                        break;
                    case ".rtf":
                        gc_cdn.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gc_cdn.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gc_cdn.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gc_cdn.ExportToMht(exportFilePath);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
