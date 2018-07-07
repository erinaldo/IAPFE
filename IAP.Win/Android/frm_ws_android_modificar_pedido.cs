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
using DevExpress.Utils;
namespace IAP.Win
{
    public partial class frm_ws_android_modificar_pedido : Form
    {
        //List<cls_pedido_linea> lst_pedido_linea = new List<cls_pedido_linea>();
        public cls_pedido pedido = new cls_pedido();
        public DataTable dt_pedido_linea;
        ServicioAndroid.cls_pedido envio_pedido = new ServicioAndroid.cls_pedido();
        DataTable dt_envio_pedido_linea = new DataTable("tabla");

        


        public frm_ws_android_modificar_pedido()
        {
            InitializeComponent();
        }
        private void frm_ws_android_modificar_pedido_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
            gcdetallepedido.DataSource = dt_pedido_linea;
            gvw_detallepedido.OptionsView.ColumnAutoWidth = false;
            gvw_detallepedido.BestFitColumns();
            //gvw_detallepedido.OptionsBehavior.Editable = false;

            txtdocumento.Text = pedido.Documento;
            txtfecha.Text =  pedido.Fecha;
            txtrucdni.Text = pedido.Cliente;
            txtcliente.Text = pedido.Nombre_Cliente;
            txtdireccion.Text = pedido.Direccion_Cliente;
            txtsubtotal.Text = pedido.SubTotal.ToString();
            txtigv.Text = pedido.Igv.ToString();
            txttotal.Text = pedido.Total.ToString();
            cmbcondicion.Text = pedido.Condicion_Pago;
            cmbestado.Text = pedido.Estado;
            gvw_detallepedido.Columns["LINEA"].OptionsColumn.AllowEdit = false;
            gvw_detallepedido.Columns["ARTICULO"].OptionsColumn.AllowEdit = false;
            gvw_detallepedido.Columns["ARTICULO_DESCRIPCION"].OptionsColumn.AllowEdit = false;
            gvw_detallepedido.Columns["UNIDAD_MEDIDA"].OptionsColumn.AllowEdit = false;
            gvw_detallepedido.Columns["CANTIDAD_PEDIDA"].OptionsColumn.AllowEdit = false;
            
        }
        private void btn_recalcular_Click(object sender, EventArgs e)
        {
            Double precio_u=0;
            for (int i = 0; i < gvw_detallepedido.DataRowCount; ++i)
            {
                DataRow row = gvw_detallepedido.GetDataRow(i);


                        precio_u = precio_u +  (Convert.ToDouble(row["CANTIDAD_PEDIDA"].ToString())*Convert.ToDouble(row["PRECIO_UNITARIO"].ToString()));
                        
            }
            txttotal.Text = Math.Round(precio_u,2).ToString();
            txtigv.Text = Math.Round((precio_u * 0.18),2).ToString();
            txtsubtotal.Text = Math.Round((precio_u - (precio_u * 0.18)),2).ToString();
            btnguardar.Enabled = true;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            llenar_clase_pedido();
            int respuesta;
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();

            //ServicioAndroid.pedido envio_pedido = new ServicioAndroid.pedido();
            //envio_pedido =
            //DataTable dt = new DataTable();
            using (WaitDialogForm waitDialog = new WaitDialogForm("Guardando documento, no cierre ninguna ventana", "Espere por favor..."))
            {
                respuesta = ws.actualizar_pedidos_pc(envio_pedido, dt_envio_pedido_linea); //(pedido, lst_pedido_linea);
            }
            if (respuesta == 1)
            {
                MessageBox.Show("Se actualizó correctamente el pedido", "Servicios Internet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se actualizó correctamente el pedido, verifique su conexión de Internet o intente nuevamente", "Servicios Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void llenar_clase_pedido()
        {
            envio_pedido.Documento = txtdocumento.Text;
            envio_pedido.Condicion_Pago = cmbcondicion.Text;
            envio_pedido.Estado = cmbestado.Text;
            envio_pedido.Fecha = Convert.ToDateTime(txtfecha.Text);
            envio_pedido.Cliente = txtrucdni.Text;
            envio_pedido.Nombre_Cliente = txtcliente.Text;
            envio_pedido.Direccion_Cliente = txtdireccion.Text;
            envio_pedido.Total = Convert.ToDouble(txttotal.Text);
            envio_pedido.SubTotal = Convert.ToDouble(txtsubtotal.Text);
            envio_pedido.Igv = Convert.ToDouble(txtigv.Text);
            envio_pedido.Fecha_Entrega = dtpfechaentrega.Text;
            envio_pedido.Estado_Cliente = "Emitido";
            /*LLENADO DE LINEA DE PEDIDOS*/
            //cls_pedido_linea pedido_linea = new cls_pedido_linea();
            dt_envio_pedido_linea.Columns.Add("pedido",typeof(string));
            dt_envio_pedido_linea.Columns.Add("linea", typeof(int));
            dt_envio_pedido_linea.Columns.Add("precio_unitario", typeof(double));


            //dt_envio_pedido_linea = gcdetallepedido.DataMember;

            for (int i = 0; i < gvw_detallepedido.DataRowCount; i++)
            {
                DataRow row = gvw_detallepedido.GetDataRow(i);
                /*
                pedido_linea.Linea = Convert.ToInt32(row["LINEA"].ToString());
                pedido_linea.Documento1 = txtdocumento.Text;
                pedido_linea.Articulo = row["ARTICULO"].ToString();
                pedido_linea.Articulo_Descripcion = row["ARTICULO_DESCRIPCION"].ToString();
                pedido_linea.Unidad_Medida = row["UNIDAD_MEDIDA"].ToString();
                pedido_linea.Cantidad_Pedida = Convert.ToInt32(row["CANTIDAD_PEDIDA"].ToString());
                pedido_linea.Precio_Unitario = Convert.ToDouble(row["PRECIO_UNITARIO"].ToString());
                */
                dt_envio_pedido_linea.Rows.Add(txtdocumento.Text, Convert.ToInt32(row["LINEA"].ToString()), Convert.ToDouble(row["PRECIO_UNITARIO"].ToString()));
                //lst_pedido_linea.Add(pedido_linea);
                //pedido_linea = new cls_pedido_linea();
 
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
