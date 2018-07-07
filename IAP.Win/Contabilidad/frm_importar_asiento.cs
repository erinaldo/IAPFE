using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.Utils;
using IAP.BL;
namespace IAP.Win
{
    public partial class frm_importar_asiento : Form
    {
        DataTable dt_asiento = new DataTable();
        public frm_importar_asiento()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel 2000-2003(*.xls)|*.xls|Excel 2007-2013(*.xlsx)|*.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path;
                    path = ofd.FileName;
                    DataSet dsexcel = new DataSet();

                    dsexcel = BL.Procedimientos_Generales.CargaExcel(path, "asientos");
                    dt_asiento = dsexcel.Tables[0];
                    if (dsexcel.Tables.Count > 0)
                    {
                        gvwasientos.Columns.Clear();
                        gcasientos.DataSource = dt_asiento; //dsexcel.Tables[0];
                        gvwasientos.OptionsView.ColumnAutoWidth = false;
                        gvwasientos.BestFitColumns();
                        gvwasientos.OptionsBehavior.Editable = false;
                        totalizar_debe_haber();
                    }
                    else
                    {
                        MessageBox.Show("El documento no tiene ningun registro", "Importar Asientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message, "Importar asientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void totalizar_debe_haber()
        {
            double debe=0, haber=0;
            for (int i = 0; i < gvwasientos.DataRowCount; ++i)
            {
                DataRow row = gvwasientos.GetDataRow(i);
                //cantidad_marcados = cantidad_marcados + 1;
                //dt_envio_articulos_excel.Rows.Add(row[0].ToString().Trim(), row[1].ToString().Trim(), row[2].ToString().Trim(), row[3].ToString().Trim(), Convert.ToInt32(row[4].ToString().Trim()),
                //    Convert.ToDouble(row[5].ToString()), row[6].ToString().Trim(), row[7].ToString().Trim(), row[8].ToString().Trim(), row[9].ToString().Trim(), row[10].ToString().Trim(), row[11].ToString().Trim());
                debe = debe + Convert.ToDouble(row[15].ToString());
                haber = haber + Convert.ToDouble(row[16].ToString());

            }
            //txtdebe.Text = Convert.ToString(debe);
            txtdebe.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(debe));
            //textbox1.Text = string.Format(“{0:#,##0.##}”, Convert.ToDouble(textbox1.Text));
            txthaber.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(haber));
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (gvwasientos.DataRowCount == 0)
            {
                MessageBox.Show("No existe ningun registro para enviar a la BD", "Importar Asientos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    //ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
                    string estado;
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Importando asientos a la BD", "Espere por favor..."))
                    {

                        estado=BL.Contabilidad.importar_asientos(this.cmbanno.Text.Trim(), dt_asiento,Global.vUserBaseDatos);
                        
                    }
                    if (estado.Equals("1"))
                    {
                        MessageBox.Show("Se importaron los asientos correctamente.", "Importar asientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtdebe.Text = "0.00";
                        txthaber.Text = "0.00";
                        gvwasientos.Columns.Clear();
                        dt_asiento.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al importar: " + estado + " [Verifique su hoja de calculo]", "Importar asientos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errores de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
