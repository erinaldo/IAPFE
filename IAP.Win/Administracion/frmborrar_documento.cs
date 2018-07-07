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
namespace IAP.Win
{

    public partial class frmborrar_documento : Form
    {
        string tipo_operacion = string.Empty;
        string tipo_documento = string.Empty;
        public frmborrar_documento()
        {
            InitializeComponent();
        }

        public void Capturar_Operacion()
        {
            if (cmbtipo.Text.Trim() == "FACTURA")
            {
                tipo_operacion = "F";
                tipo_documento = "01";
            }
            else
            {
                if (cmbtipo.Text.Trim() == "BOLETA")
                {
                    tipo_operacion = "F";
                    tipo_documento = "03";
                }
                else
                {
                    if (cmbtipo.Text.Trim() == "GUIA REMISION")
                    {
                        tipo_operacion = "G";
                        tipo_documento = "09";
                    }
                }

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            Capturar_Operacion();
            
            DialogResult resp;
            resp = MessageBox.Show("PROCESO IRREVERSIBLE, VERIFIQUE EL NUMERO Y TIPO DE DOCUMENTO ANTES DE PROCEDER, TAMBIEN QUE EL DOCUMENTO ESTE ANULADO\r\nDESEA CONTINUAR EL LA ELIMINACIÓN?", "Administración del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    bool result;
                    result=BL.Administracion.Borrar_Documento(this.txtnumero.Text.Trim(), tipo_documento, tipo_operacion, Global.vUserBaseDatos);
                    if (result==false)
                    {
                        MessageBox.Show("No existe el documento", "Administración del Sistema");
                        this.btnborrar.Enabled = false;
                    }
                    else
                    {
                    MessageBox.Show("Se Borró Correctamente El Documento, mueva el correlativo del Sistema", "Administración del sistema");
                    cmbtipo.Text = string.Empty;
                    this.txtnumero.Text = string.Empty;
                    this.btnborrar.Enabled = false;
                    this.lst.Items.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Administración del Sistema");
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lst.Items.Clear();
            Capturar_Operacion();
            string datos=string.Empty;
            DataTable dt;
            //DataRow dr;
            ListViewItem lvw= new ListViewItem();
            dt = BL.Administracion.Verificar_Doc_Eliminado_BL(this.txtnumero.Text.Trim(), tipo_documento, tipo_operacion, Global.vUserBaseDatos);
          
            foreach (DataRow row in dt.Rows)
            {
                datos = row["DOCUMENTO"].ToString();
                //ListViewItem item = new ListViewItem(Convert.ToString(row["DOCUMENTO"]));
                //lst.Items.Add(item);
                lst.Items.Add(datos);
                //LSTVW.Items.Add(item);
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No existe el documento, verifique el numero y el tipo de documento", "Administración del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnborrar.Enabled = false;
            }
            else
            {
                this.btnborrar.Enabled = true;
            }
        }

        private void frmborrar_documento_Load(object sender, EventArgs e)
        {
            this.btnborrar.Enabled = false;
        }
    }
}
