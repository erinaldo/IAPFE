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
//using IAP.BL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
namespace IAP.Win
{
    public partial class frm_ws_android_aprobar_pedidos : Form
    {
        cls_pedido pedido = new cls_pedido();
        cls_pedido_linea pedido_linea = new cls_pedido_linea();
        DataTable dt_linea_global;
        DataTable dt_envio_articulos,dt_envio_articulos_excel;

        int cantidad_marcados=0;
        
        public frm_ws_android_aprobar_pedidos()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = new DataTable();
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
            using (WaitDialogForm waitDialog = new WaitDialogForm("Cargando pedidos desde el Servidor", "Espere por favor..."))
            {
                dt = ws.consultar_pedidos_pc_cabecera(dtp_fechai.Text, dtp_fechaf.Text,txt_ruc.Text,txt_cliente.Text);
                gcpedido_cab.DataSource = dt;
                gvw_pedido_cab.OptionsView.ColumnAutoWidth = false;
                gvw_pedido_cab.BestFitColumns();
                gvw_pedido_cab.OptionsBehavior.Editable = false;
            }

        }

        private void gvw_pedido_cab_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvw_pedido_cab.RowCount <= 0)
            {
                //MessageBox.Show("No existe informacion a procesar");
                return;
            }
            else
            {

                try
                {
                    
                    pedido.Documento = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "DOCUMENTO").ToString();
                    pedido.Condicion_Pago = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "CONDICION_PAGO").ToString();
                    pedido.Estado = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "ESTADO").ToString();
                    pedido.Fecha = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "FECHA").ToString();
                    pedido.Cliente = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "CLIENTE").ToString();
                    pedido.Nombre_Cliente = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "NOMBRE_CLIENTE").ToString();
                    pedido.Direccion_Cliente = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "DIRECCION_CLIENTE").ToString();
                    pedido.Total = Convert.ToDouble(gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "TOTAL").ToString());
                    pedido.SubTotal = Convert.ToDouble(gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "SUBTOTAL").ToString());
                    pedido.Igv = Convert.ToDouble(gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "IGV").ToString());
                    pedido.Fecha_Entrega = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "FECHA_ENTREGA").ToString();
                    pedido.Estado_Cliente = gvw_pedido_cab.GetRowCellValue(gvw_pedido_cab.FocusedRowHandle, "ESTADO_CLIENTE").ToString();

                    Mostrar_pedido_linea(pedido.Documento);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Mostrar_pedido_linea(string documento)
        {
            gvw_pedido_det.Columns.Clear();
            dt_linea_global.Clear();

            DataTable dt;
            dt = new DataTable();
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();

            dt = ws.consultar_pedidos_pc_detalle(documento);
            dt_linea_global = dt;
            gcpedido_det.DataSource = dt;
            gvw_pedido_det.OptionsView.ColumnAutoWidth = false;
            gvw_pedido_det.BestFitColumns();
            gvw_pedido_det.OptionsBehavior.Editable = false;
            
        }

        private void gvw_pedido_cab_DoubleClick(object sender, EventArgs e)
        {
            frm_ws_android_modificar_pedido frm = new frm_ws_android_modificar_pedido();
            frm.dt_pedido_linea = dt_linea_global;
            frm.pedido = pedido;
            frm.ShowDialog();
        }

        private void frm_ws_android_aprobar_pedidos_Load(object sender, EventArgs e)
        {
            dt_linea_global = new DataTable();
            this.groupControl1.LookAndFeel.UseWindowsXPTheme = true;
        }

        private void gvw_pedido_cab_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView view = sender as GridView;

                // Some condition
                //if ((string)view.GetRowCellValue(e.RowHandle, view.Columns["ESTADO"]).Equals("NORMAL"))
                if ((string)view.GetRowCellValue(e.RowHandle, view.Columns["ESTADO"]) == "Emitido")
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.ForeColor = Color.DarkBlue;
                    
                }
                if ((string)view.GetRowCellValue(e.RowHandle, view.Columns["ESTADO"]) == "Cancelado")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;

                }
                if ((string)view.GetRowCellValue(e.RowHandle, view.Columns["ESTADO"]) == "Aprobado")
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;

                }
            }

        }

        private void gvw_pedido_cab_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        private void btnobtener_lista_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = new DataTable();
            string familia,articulo;
            familia = txtfamilia.Text.Trim();
            articulo = txtarticulo.Text.Trim();
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
            
            
            using (WaitDialogForm waitDialog = new WaitDialogForm("Cargando lista de articulos", "Espere por favor..."))
            {
                dt = ws.ConsultaArticulos_pc(familia,articulo);
                dt.Columns.Add("OK");
                gc_lista.DataSource = dt;
                Configura_gridview();
                gvw_lista.OptionsView.ColumnAutoWidth = false;
                gvw_lista.BestFitColumns();
                //gvw_lista.OptionsBehavior.Editable = false;
            }
        }
        private void Configura_gridview()
        {
            gvw_lista.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(gvw_lista_CustomRowCellEdit);
            RepositoryItemCheckEdit repositoryCheckEdit1 = gc_lista.RepositoryItems.Add("CheckEdit") as RepositoryItemCheckEdit;
            repositoryCheckEdit1.Name = "CheckGenerar";
            repositoryCheckEdit1.ValueChecked = "True";
            repositoryCheckEdit1.ValueUnchecked = "False";
            gvw_lista.Columns["OK"].ColumnEdit = repositoryCheckEdit1;

        }

        private void gvw_lista_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
                if (e.Column.FieldName == "OK")
                {
                    e.RepositoryItem = (sender as GridView).GridControl.RepositoryItems["CheckGenerar"];
                }
        }

        private void btn_cargar_lista_Click(object sender, EventArgs e)
        {
            LLenar_tabla_articulos_ws();
            if (cantidad_marcados == 0)
            {
                MessageBox.Show("No ha marcado ningun registro, tiene que marca al menos un registro para actualizar", "Servicios Android", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
            int resultado;
            resultado = ws.Actualizar_lista_articulos_pc(dt_envio_articulos);

            if (resultado == 1)
            {
                MessageBox.Show("Se actualizó correctamente los articulos seleccionados", "Servicios Android", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la tarea, verifique su conexión a internet o vuelva a intentarlo", "Servicios Android", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LLenar_tabla_articulos_ws()
        {
            dt_envio_articulos = new DataTable("tabla");
            dt_envio_articulos.Columns.Add("bodega", typeof(string));
            dt_envio_articulos.Columns.Add("articulo", typeof(string));
            dt_envio_articulos.Columns.Add("nombre_articulo", typeof(string));
            dt_envio_articulos.Columns.Add("cantidad", typeof(int));
            dt_envio_articulos.Columns.Add("precio", typeof(double));
            for (int i = 0; i < gvw_lista.DataRowCount; ++i)
            {
                DataRow row = gvw_lista.GetDataRow(i);

                if (row["OK"].ToString() == "True")
                {
                    cantidad_marcados = cantidad_marcados + 1;
                    dt_envio_articulos.Rows.Add(row["BODEGA"].ToString(),row["ARTICULO"].ToString(),row["NOMBRE_ARTICULO"].ToString(),Convert.ToInt32(row["CANTIDAD"].ToString()),Convert.ToDouble(row["PRECIO"].ToString()));

                }
            }
        }

        private void btn_cargar_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel 2000-2003(*.xls)|*.xls|Excel 2007-2013(*.xlsx)|*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path;
                path = ofd.FileName;
                DataSet dsexcel = new DataSet();
                dsexcel = BL.Procedimientos_GeneralesBL.CargaExcel(path, "lista");
                if (dsexcel.Tables.Count > 0)
                {
                    gvw_lista.Columns.Clear();
                    gc_lista.DataSource = dsexcel.Tables[0];

                }
            }
            else
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gvw_lista.DataRowCount == 0)
            {
                MessageBox.Show("No existe ningun registro para enviar a la BD", "Servicios Android", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {

                    ServicioAndroid.ServicioClientesSoapClient ws = new ServicioAndroid.ServicioClientesSoapClient();
                    int respuesta;
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Registrando articulos en el Servidor", "Espere por favor..."))
                    {
                        Cargar_dt_articulos_excel();
                        respuesta = ws.Insertar_articulos_pc(dt_envio_articulos_excel);
                        if (respuesta==0)
                        {
                            MessageBox.Show("Se registró correctamente la lista de articulos", "Servicios Android", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Errores de carga",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        private void Cargar_dt_articulos_excel()
        {
            dt_envio_articulos_excel = new DataTable("tabla");
            dt_envio_articulos_excel.Columns.Add("nombre_bodega", typeof(string));
            dt_envio_articulos_excel.Columns.Add("bodega", typeof(string));
            dt_envio_articulos_excel.Columns.Add("nombre_articulo", typeof(string));
            dt_envio_articulos_excel.Columns.Add("articulo", typeof(string));
            dt_envio_articulos_excel.Columns.Add("cantidad", typeof(int));
            dt_envio_articulos_excel.Columns.Add("precio", typeof(double));// 5
            dt_envio_articulos_excel.Columns.Add("familia_nombre", typeof(string));
            dt_envio_articulos_excel.Columns.Add("familia", typeof(string));
            dt_envio_articulos_excel.Columns.Add("subfamilia_nombre", typeof(string));
            dt_envio_articulos_excel.Columns.Add("subfamilia", typeof(string));
            dt_envio_articulos_excel.Columns.Add("grupo_nombre", typeof(string));
            dt_envio_articulos_excel.Columns.Add("grupo", typeof(string));

            for (int i = 0; i < gvw_lista.DataRowCount; ++i)
            {
                DataRow row = gvw_lista.GetDataRow(i);
                //cantidad_marcados = cantidad_marcados + 1;
                dt_envio_articulos_excel.Rows.Add(row[0].ToString().Trim(), row[1].ToString().Trim(), row[2].ToString().Trim(), row[3].ToString().Trim(), Convert.ToInt32(row[4].ToString().Trim()),
                    Convert.ToDouble(row[5].ToString()), row[6].ToString().Trim(), row[7].ToString().Trim(), row[8].ToString().Trim(), row[9].ToString().Trim(), row[10].ToString().Trim(), row[11].ToString().Trim());
            }
        }
    }
}
