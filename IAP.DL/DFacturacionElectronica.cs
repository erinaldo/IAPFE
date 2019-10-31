using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using IAP.BE;
using System.Data.Common;

namespace IAP.DL
{
    public class DFacturacionElectronica
    {

        public DFacturacionElectronica()
        {

        }

        public ProveedorFE ObtenerProveedorFE(int idempresa,string dbEmpresa)
        {
            
            Database db = DatabaseFactory.CreateDatabase("Master");
            
            DbCommand cmd;
            
            cmd = db.GetStoredProcCommand("USP_DATOSPROVEEDOR_FE",idempresa, dbEmpresa);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            ProveedorFE ep = new ProveedorFE();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ep.Usuario = row["Usuario"].ToString();
                ep.Clave = row["Clave"].ToString();
                ep.Ruta = row["Ruta"].ToString();
                ep.Token= row["Token"].ToString();
                ep.Ruc= row["Ruc"].ToString();
            }
            return ep;
        }
        public List<ProveedorFE> ObtenerDatosProveedorFE(string dbEmpresa)
        {
            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_ObtenerDatosProveedorFE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<ProveedorFE> ls = new List<ProveedorFE>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new ProveedorFE(
                        Convert.ToString(row["Empresa"]),
                        Convert.ToString(row["Ruc"]),
                        Convert.ToString(row["Link"]),
                        Convert.ToString(row["Usuario"]),
                        Convert.ToString(row["Clave"]),
                        Convert.ToString(row["Ruta"]),
                        Convert.ToString(row["Token"])));
            }
            return ls;
        }

        public List<Documentov> ObtenerDocumentosFBNC(string cdocu, DateTime fechai, DateTime fechaf, string cliente, string documento, Int32 enviadosunat, int anulado, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_ObtenerDocumentosFBNC", cdocu, fechai, fechaf, cliente, documento, enviadosunat, anulado);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<Documentov> ls = new List<Documentov>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new Documentov(
                    Convert.ToDateTime(row["fecha"]),
                    Convert.ToString(row["cdocu"]),
                    Convert.ToString(row["ndocu"]),
                    Convert.ToString(row["drefe"]),
                    Convert.ToString(row["crefe"]),
                    Convert.ToString(row["nrefe"]),
                    new Cliente(Convert.ToString(row["ruccli"]), Convert.ToString(row["nomcli"])),
                    new CondicionVenta(Convert.ToString(row["codcdv"]), Convert.ToString(row["nomcdv"])),
                    Convert.ToString(row["flag"]),
                    Convert.ToString(row["estado"]),
                    Convert.ToString(row["mone"]),
                    Convert.ToDouble(row["tcam"]),
                    Convert.ToDouble(row["tota"]),
                    Convert.ToDouble(row["toti"]),
                    Convert.ToDouble(row["totn"]),
                    Convert.ToInt32(row["flg_fe"]),
                    Convert.ToString(row["EstadoFe"]),

                    Convert.ToString(row["serie"]),
                    Convert.ToString(row["numero"]),
                    Convert.ToString(row["enlace"]),
                    Convert.ToBoolean(row["aceptada_por_sunat"]),
                    Convert.ToString(row["sunat_description"]),
                    Convert.ToString(row["sunat_note"]),
                    Convert.ToString(row["sunat_responsecode"]),
                    Convert.ToString(row["sunat_soap_error"]),
                    Convert.ToString(row["enlace_del_pdf"]),
                    Convert.ToString(row["enlace_del_xml"]),
                    Convert.ToString(row["enlace_del_cdr"]),
                    Convert.ToString(row["tipo_de_comprobante"]),
                    Convert.ToString(row["motanu"]),
                    Convert.ToString(row["enlace_del_pdf_anulado"]),
                    row["TeleSol_Serie"].ToString(),
                    row["TeleSol_Numero"].ToString(),
                    row["TeleSol_FechaEmitido"]==DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["TeleSol_FechaEmitido"]),
                    row["TeleSol_Emitido"].ToString(),
                    row["TeleSol_Baja"].ToString(),
                    row["TeleSol_DigestValue_Hash"].ToString(),
                    row["TeleSol_SignatureValue_Firma"].ToString(),
                    row["TeleSol_IdConstancia"].ToString(),
                    row["TeleSol_IdRespuesta"].ToString(),
                    row["TeleSol_CodigoRespuestaSunat"].ToString(), row["TeleSol_NotaAsociada"].ToString(), row["TeleSol_Descripcion"].ToString(),
                    row["TeleSol_IdFactura"].ToString(),
                    row["TeleSol_IdComunicacionBaja"].ToString()
                    ));
            }
            return ls;
        }

        public List<DocumentovDet> ObtenerDocumentosDetalleFBNC(string cdocu, string ndocu, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_ObtenerDocumentosDetalleFBNC", cdocu, ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<DocumentovDet> ls = new List<DocumentovDet>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new DocumentovDet(
                    new Producto(
                        Convert.ToString(row["codi"]),
                        Convert.ToString(row["codf"]),
                        Convert.ToString(row["marc"]),
                        Convert.ToString(row["descr"]),
                        Convert.ToString(row["umed"])),
                    Convert.ToDouble(row["cant"]),
                    Convert.ToDouble(row["preu"]),
                    Convert.ToDouble(row["total"])));
            }
            return ls;
        }


        public SunatDocumentoFBN SunatEnviarDocumentosFBN_ObtenerDatos(Documentov lst, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_SunatEnviarDocumentosFBN_ObtenerDatos", lst.Cdocu, lst.Ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            SunatDocumentoFBN e = new SunatDocumentoFBN();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                e.cdocu = lst.Cdocu;
                e.ndocu = lst.Ndocu;
                e.operacion = Convert.ToString(row["operacion"]).Trim();
                e.tipo_de_comprobante = Convert.ToInt32(row["tipo_de_comprobante"]);
                e.serie = Convert.ToString(row["serie"]).Trim();
                e.numero = Convert.ToInt32(row["numero"]);
                e.sunat_transaction = Convert.ToInt32(row["sunat_transaction"]);
                e.cliente_tipo_de_documento = Convert.ToInt32(row["cliente_tipo_de_documento"]);
                e.cliente_numero_de_documento = Convert.ToString(row["cliente_numero_de_documento"]).Trim();
                e.cliente_denominacion = Convert.ToString(row["cliente_denominacion"]).Trim();
                e.cliente_direccion = Convert.ToString(row["cliente_direccion"]).Trim();
                e.cliente_email = Convert.ToString(row["cliente_email"]).Trim();
                e.cliente_email_1 = Convert.ToString(row["Cliente_email_1"]).Trim();
                e.cliente_email_2 = Convert.ToString(row["Cliente_email_2"]).Trim();
                e.fecha_de_emision = Convert.ToDateTime(row["fecha_de_emision"]);
                e.fecha_de_vencimiento = Convert.ToDateTime(row["Fecha_de_vencimiento"]);
                e.moneda = Convert.ToInt32(row["Moneda"]);
                e.tipo_de_cambio = Convert.ToDouble(row["Tipo_de_cambio"]);
                e.porcentaje_de_igv = Convert.ToDouble(row["Porcentaje_de_igv"]);
                e.descuento_global = Convert.ToDouble(row["Descuento_global"]);
                e.total_descuento = Convert.ToDouble(row["Total_descuento"]);
                e.total_anticipo = Convert.ToDouble(row["Total_anticipo"]);
                e.total_gravada = Convert.ToDouble(row["Total_gravada"]);
                e.total_inafecta = Convert.ToDouble(row["Total_inafecta"]);
                e.total_exonerada = Convert.ToDouble(row["Total_exonerada"]);
                e.total_igv = Convert.ToDouble(row["Total_igv"]);
                e.total_gratuita = Convert.ToDouble(row["Total_gratuita"]);
                e.total_otros_cargos = Convert.ToDouble(row["Total_otros_cargos"]);
                e.total = Convert.ToDouble(row["Total"]);
                e.percepcion_tipo = Convert.ToString(row["Percepcion_tipo"]);
                e.percepcion_base_imponible = Convert.ToDouble(row["Percepcion_base_imponible"]);
                e.total_percepcion = Convert.ToDouble(row["Total_percepcion"]);
                e.total_incluido_percepcion = Convert.ToDouble(row["Total_incluido_percepcion"]);
                e.detraccion = Convert.ToString(row["Detraccion"]);
                e.observaciones = Convert.ToString(row["Observaciones"]);
                e.documento_que_se_modifica_tipo = Convert.ToInt32(row["Documento_que_se_modifica_tipo"]) == 0 ? (dynamic)null : Convert.ToInt32((row["Documento_que_se_modifica_tipo"]));
                e.documento_que_se_modifica_serie = Convert.ToString(row["Documento_que_se_modifica_serie"]).Trim();
                e.documento_que_se_modifica_numero = row["Documento_que_se_modifica_numero"] == DBNull.Value ? (dynamic)null : Convert.ToInt32(row["Documento_que_se_modifica_numero"]);
                e.tipo_de_nota_de_credito = row["Tipo_de_nota_de_credito"] == DBNull.Value ? (dynamic)null : Convert.ToInt32(row["Tipo_de_nota_de_credito"]);
                e.tipo_de_nota_de_debito = Convert.ToString(row["Tipo_de_nota_de_debito"]).Trim();
                e.enviar_automaticamente_a_la_sunat = Convert.ToBoolean(row["Enviar_automaticamente_a_la_sunat"]);
                e.enviar_automaticamente_al_cliente = Convert.ToBoolean(row["Enviar_automaticamente_al_cliente"]);
                e.codigo_unico = Convert.ToString(row["Codigo_unico"]).Trim();
                e.condiciones_de_pago = Convert.ToString(row["Condiciones_de_pago"]).Trim();
                e.medio_de_pago = Convert.ToString(row["Medio_de_pago"]).Trim();
                e.placa_vehiculo = Convert.ToString(row["Placa_vehiculo"]).Trim();
                e.orden_compra_servicio = Convert.ToString(row["Orden_compra_servicio"]).Trim();
                e.tabla_personalizada_codigo = Convert.ToString(row["Tabla_personalizada_codigo"]).Trim();
                e.formato_de_pdf = Convert.ToString(row["Formato_de_pdf"]).Trim();

            }

            cmd = db.GetStoredProcCommand("usp_SunatEnviarDocumentosFBN_ObtenerDatosDetalle", lst.Cdocu, lst.Ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds2 = db.ExecuteDataSet(cmd);
            List<SunatDocumentoDetalleFBN> detalle = new List<SunatDocumentoDetalleFBN>();
            SunatDocumentoDetalleFBN eDet;
            foreach (DataRow row in ds2.Tables[0].Rows)
            {

                eDet = new SunatDocumentoDetalleFBN();
                eDet.unidad_de_medida = Convert.ToString(row["Unidad_de_medida"]);
                eDet.codigo = Convert.ToString(row["Codigo"]);
                eDet.descripcion = Convert.ToString(row["descripcion"]);
                eDet.cantidad = Convert.ToDouble(row["Cantidad"]);
                eDet.valor_unitario = Convert.ToDouble(row["Valor_unitario"]);
                eDet.precio_unitario = Convert.ToDouble(row["Precio_unitario"]);
                eDet.descuento = Convert.ToDouble(row["Descuento"]);
                eDet.subtotal = Convert.ToDouble(row["Subtotal"]);
                eDet.tipo_de_igv = Convert.ToInt32(row["Tipo_de_igv"]);
                eDet.igv = Convert.ToDouble(row["Igv"]);
                eDet.total = Convert.ToDouble(row["Total"]);
                eDet.anticipo_regularizacion = Convert.ToBoolean(row["Anticipo_regularizacion"]);
                eDet.anticipo_documento_serie = Convert.ToString(row["Codigo"]);
                eDet.anticipo_documento_numero = Convert.ToString(row["Anticipo_documento_numero"]);
                detalle.Add(eDet);

            }
            e.items = detalle;


            return e;

        }

        public SunatDocumentoFBN_V2 SunatEnviarDocumentosFBN_ObtenerDatos_V2(Documentov lst, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_SunatEnviarDocumentosFBN_ObtenerDatos", lst.Cdocu, lst.Ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            SunatDocumentoFBN_V2 e = new SunatDocumentoFBN_V2();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                e.operacion = Convert.ToString(row["operacion"]).Trim();
                e.tipo_de_comprobante = Convert.ToInt32(row["tipo_de_comprobante"]);
                e.serie = Convert.ToString(row["serie"]).Trim();
                e.numero = Convert.ToInt32(row["numero"]);
                e.sunat_transaction = Convert.ToInt32(row["sunat_transaction"]);
                e.cliente_tipo_de_documento = Convert.ToInt32(row["cliente_tipo_de_documento"]);
                e.cliente_numero_de_documento = Convert.ToString(row["cliente_numero_de_documento"]).Trim();
                e.cliente_denominacion = Convert.ToString(row["cliente_denominacion"]).Trim();
                e.cliente_direccion = Convert.ToString(row["cliente_direccion"]).Trim();
                e.cliente_email = Convert.ToString(row["cliente_email"]).Trim();
                e.cliente_email_1 = Convert.ToString(row["Cliente_email_1"]).Trim();
                e.cliente_email_2 = Convert.ToString(row["Cliente_email_2"]).Trim();
                e.fecha_de_emision = Convert.ToDateTime(row["fecha_de_emision"]);
                e.fecha_de_vencimiento = Convert.ToDateTime(row["Fecha_de_vencimiento"]);
                e.moneda = Convert.ToInt32(row["Moneda"]);
                e.tipo_de_cambio = Convert.ToDouble(row["Tipo_de_cambio"]);
                e.porcentaje_de_igv = Convert.ToDouble(row["Porcentaje_de_igv"]);
                e.descuento_global = Convert.ToDouble(row["Descuento_global"]);
                e.total_descuento = Convert.ToDouble(row["Total_descuento"]);
                e.total_anticipo = Convert.ToDouble(row["Total_anticipo"]);
                e.total_gravada = Convert.ToDouble(row["Total_gravada"]);
                e.total_inafecta = Convert.ToDouble(row["Total_inafecta"]);
                e.total_exonerada = Convert.ToDouble(row["Total_exonerada"]);
                e.total_igv = Convert.ToDouble(row["Total_igv"]);
                e.total_gratuita = Convert.ToDouble(row["Total_gratuita"]);
                e.total_otros_cargos = Convert.ToDouble(row["Total_otros_cargos"]);
                e.total = Convert.ToDouble(row["Total"]);
                e.percepcion_tipo = Convert.ToString(row["Percepcion_tipo"]);
                e.percepcion_base_imponible = Convert.ToDouble(row["Percepcion_base_imponible"]);
                e.total_percepcion = Convert.ToDouble(row["Total_percepcion"]);
                e.total_incluido_percepcion = Convert.ToDouble(row["Total_incluido_percepcion"]);
                e.detraccion = Convert.ToString(row["Detraccion"]);
                e.observaciones = Convert.ToString(row["Observaciones"]);
                e.documento_que_se_modifica_tipo = Convert.ToInt32(row["Documento_que_se_modifica_tipo"]) == 0 ? (dynamic)string.Empty : Convert.ToInt32((row["Documento_que_se_modifica_tipo"]));
                e.documento_que_se_modifica_serie = Convert.ToString(row["Documento_que_se_modifica_serie"]).Trim();
                e.documento_que_se_modifica_numero = Convert.ToInt32(row["Documento_que_se_modifica_numero"]) == 0 ? (dynamic)string.Empty : Convert.ToInt32(row["Documento_que_se_modifica_numero"]);
                e.tipo_de_nota_de_credito = Convert.ToInt32(row["Tipo_de_nota_de_credito"]) == 0 ? (dynamic)string.Empty : Convert.ToInt32(row["Tipo_de_nota_de_credito"]);
                e.tipo_de_nota_de_debito = Convert.ToString(row["Tipo_de_nota_de_debito"]).Trim();
                e.enviar_automaticamente_a_la_sunat = Convert.ToBoolean(row["Enviar_automaticamente_a_la_sunat"]);
                e.enviar_automaticamente_al_cliente = Convert.ToBoolean(row["Enviar_automaticamente_al_cliente"]);
                e.codigo_unico = Convert.ToString(row["Codigo_unico"]).Trim();
                e.condiciones_de_pago = Convert.ToString(row["Condiciones_de_pago"]).Trim();
                e.medio_de_pago = Convert.ToString(row["Medio_de_pago"]).Trim();
                e.placa_vehiculo = Convert.ToString(row["Placa_vehiculo"]).Trim();
                e.orden_compra_servicio = Convert.ToString(row["Orden_compra_servicio"]).Trim();
                e.tabla_personalizada_codigo = Convert.ToString(row["Tabla_personalizada_codigo"]).Trim();
                e.formato_de_pdf = Convert.ToString(row["Formato_de_pdf"]).Trim();

            }

            cmd = db.GetStoredProcCommand("usp_SunatEnviarDocumentosFBN_ObtenerDatosDetalle", lst.Cdocu, lst.Ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds2 = db.ExecuteDataSet(cmd);
            List<SunatDocumentoDetalleFBN> detalle = new List<SunatDocumentoDetalleFBN>();
            SunatDocumentoDetalleFBN eDet;
            foreach (DataRow row in ds2.Tables[0].Rows)
            {

                eDet = new SunatDocumentoDetalleFBN();
                eDet.unidad_de_medida = Convert.ToString(row["Unidad_de_medida"]);
                eDet.codigo = Convert.ToString(row["Codigo"]);
                eDet.descripcion = Convert.ToString(row["descripcion"]);
                eDet.cantidad = Convert.ToDouble(row["Cantidad"]);
                eDet.valor_unitario = Convert.ToDouble(row["Valor_unitario"]);
                eDet.precio_unitario = Convert.ToDouble(row["Precio_unitario"]);
                eDet.descuento = Convert.ToDouble(row["Descuento"]);
                eDet.subtotal = Convert.ToDouble(row["Subtotal"]);
                eDet.tipo_de_igv = Convert.ToInt32(row["Tipo_de_igv"]);
                eDet.igv = Convert.ToDouble(row["Igv"]);
                eDet.total = Convert.ToDouble(row["Total"]);
                eDet.anticipo_regularizacion = Convert.ToBoolean(row["Anticipo_regularizacion"]);
                eDet.anticipo_documento_serie = Convert.ToString(row["Codigo"]);
                eDet.anticipo_documento_numero = Convert.ToString(row["Anticipo_documento_numero"]);
                detalle.Add(eDet);

            }
            e.items = detalle;


            return e;

        }


        public void GuardarRespuestaSunat(SunatRespuestaFBN e, string cdocu, string ndocu, int flg_fe, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("usp_SunatGuardarRespuestaSunat", cdocu, ndocu, flg_fe, e.tipo_de_comprobante, e.serie, e.numero, e.enlace, e.aceptada_por_sunat, e.sunat_description,
                e.sunat_note, e.sunat_responsecode, e.sunat_soap_error, e.pdf_zip_base64, e.xml_zip_base64, e.cdr_zip_base64, e.cadena_para_codigo_qr, e.codigo_hash,
                e.enlace_del_pdf,
                e.enlace_del_xml, e.enlace_del_cdr, e.errors, e.fe_codigo);
        }

        //public dynamic SunatEnviarDocumentosTelesolucionesFactura(Documentov lst, string dbconexion)
        //{
        //    Database db = DatabaseFactory.CreateDatabase(dbconexion);
        //    /* PRUEBA*/
        //    DbCommand cmd2;
        //    cmd2 = db.GetStoredProcCommand("usp_SunatTelesoluciones_EnviarFacturaDetalle", lst.Cdocu, lst.Ndocu);
        //    cmd2.CommandType = CommandType.StoredProcedure;
        //    cmd2.CommandTimeout = 0;

        //    DataSet ds2 = db.ExecuteDataSet(cmd2);
        //    //var item = (dynamic)null;

        //    //foreach (DataRow row2 in ds2.Tables[0].Rows)
        //    //{
        //    //    item.Add(new 
        //    //    {
        //    //        cantidad = Convert.ToDouble(row2["cantidad"]),
        //    //        descripcion = row2["descripcion"].ToString().Trim(),
        //    //        valorVenta = Convert.ToDouble(row2["valorVenta"]),
        //    //        valorUnitario = Convert.ToDouble(row2["valorUnitario"]),
        //    //        precioVentaUnitario = Convert.ToDouble(row2["precioVentaUnitario"]),
        //    //        tipoPrecioVentaUnitario = row2["tipoPrecioVentaUnitario"].ToString(),
        //    //        montoAfectacionIgv = Convert.ToDouble(row2["montoAfectacionIgv"]),
        //    //        tipoAfectacionIgv = row2["tipoAfectacionIgv"].ToString(),
        //    //        codigoProducto = row2["codigoProducto"].ToString().Trim(),
        //    //        descuento = Convert.ToDouble(row2["descuento"])
        //    //    });
        //    //}

        //    var item= (from DataRow row2 in ds2.Tables[0].Rows
        //     select new
        //     {
        //         cantidad = Convert.ToDouble(row2["cantidad"]),
        //         descripcion = row2["descripcion"].ToString().Trim(),
        //         valorVenta = Convert.ToDouble(row2["valorVenta"]),
        //         valorUnitario = Convert.ToDouble(row2["valorUnitario"]),
        //         precioVentaUnitario = Convert.ToDouble(row2["precioVentaUnitario"]),
        //         tipoPrecioVentaUnitario = row2["tipoPrecioVentaUnitario"].ToString(),
        //         montoAfectacionIgv = Convert.ToDouble(row2["montoAfectacionIgv"]),
        //         tipoAfectacionIgv = row2["tipoAfectacionIgv"].ToString(),
        //         codigoProducto = row2["codigoProducto"].ToString().Trim(),
        //         descuento = Convert.ToDouble(row2["descuento"])
        //     }).ToList();


        //    DbCommand cmd;
        //    cmd = db.GetStoredProcCommand("usp_SunatTelesoluciones_EnviarFactura", lst.Cdocu, lst.Ndocu);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandTimeout = 0;

        //    DataSet ds = db.ExecuteDataSet(cmd);

            
        //    //List<TelesolucionesGuiaRelacionada> lstguias = new List<TelesolucionesGuiaRelacionada>();
        //    var tf = (dynamic)null;
        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
        //        tf = new 
        //        {
        //            serie = row["serie"].ToString(),
        //            numero = Convert.ToInt32(row["numero"]),
        //            totalVentaGravada = Convert.ToDouble(row["totalVentaGravada"]),
        //            totalVentaInafecta = Convert.ToDouble(row["totalVentaInafecta"]),
        //            totalVentaExonerada = Convert.ToDouble(row["totalVentaExonerada"]),
        //            sumatoriaIgv = Convert.ToDouble(row["sumatoriaIgv"]),
        //            sumatoriaIsc = Convert.ToDouble(row["sumatoriaIsc"]),
        //            totalVenta = Convert.ToDouble(row["total"]),
        //            tipoMoneda = row["tipoMoneda"].ToString(),
        //            descuentoGlobal = Convert.ToDouble(row["descuentoGlobal"]),
        //            porcentajeDescuentoGlobal = Convert.ToDouble(row["porcentajeDescuentoGlobal"]),
        //            totalDescuento = Convert.ToDouble(row["totalDescuento"]),
        //            importePercepcion = Convert.ToDouble(row["importePercepcion"]),
        //            porcentajePercepcion = Convert.ToDouble(row["porcentajePercepcion"]),
        //            docRelacionada = new { numero = row["docRelacionadaNdocu"].ToString() },
        //            //guiasRelacionada = new List<TelesolucionesGuiaRelacionada>{ numero = row["guiasRelacionada"].ToString() },
        //            receptor = new { tipo = row["receptorTipo"].ToString(), nro = row["receptorNumero"].ToString(), razonSocial = row["ReceptorRazonSocial"].ToString().Trim() },
        //            items= item
                    
        //        };

        //        //lstguias.Add(new TelesolucionesGuiaRelacionada { tipo = row["guiasRelacionadaTipo"].ToString(), serie = row["guiasRelacionadaSerie"].ToString(), numero = row["guiasRelacionadaNro"].ToString().Trim() });
        //        //tf.guiasRelacionada = lstguias;

               
                
        //    }
        //    return tf;
        //}

        public TelesolucionesFactura SunatEnviarDocumentosTelesolucionesFactura(Documentov lst, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            /* PRUEBA*/
            
             
            
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_SunatTelesoluciones_EnviarFactura", lst.Cdocu, lst.Ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            TelesolucionesFactura tf = new TelesolucionesFactura();
            //dynamic tf= new TelesolucionesFactura();
            List<TelesolucionesGuiaRelacionada> lstguias = new List<TelesolucionesGuiaRelacionada>();
            //List<TelesolucionesDocRelacionada> lstdocrelacionada = new List<TelesolucionesDocRelacionada>();
            //var tf = (dynamic)null;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                tf = new TelesolucionesFactura
                {
                    tipoOperacion = "0101",
                    serie = row["serie"].ToString(),
                    numero = Convert.ToInt32(row["numero"]),
                    montoTotalImpuestos= Convert.ToDouble(row["sumatoriaIgv"]),
                    importeTotal= Convert.ToDouble(row["total"]),
                    totalVentaGravada = Convert.ToDouble(row["totalVentaGravada"]),
                    sumatoriaIgv= Convert.ToDouble(row["sumatoriaIgv"]),
                    receptor= new TelesolucionesRecceptor { tipo= Convert.ToString(row["receptorTipo"]),nro= Convert.ToString(row["receptorNumero"]) },
                    //guiasRelacionada = new TelesolucionesGuiaRelacionada
                    //    {
                    //        tipo = "guiasRelacionadaTipo",
                    //        numero = row["guiasRelacionadaSerie"].ToString() +"-"+ row["guiasRelacionadaNro"].ToString()
                    //    },
                    fechaEmision=Convert.ToDateTime(row["fechaEmision"]).ToString("yyyy-MM-dd"),
                    tipoMoneda= row["tipoMoneda"].ToString(),
                    adicional = new TelesolucionesAdicionalCab
                    {
                        fechaVencimiento = Convert.ToDateTime(row["fechaVencimiento"]).ToString("yyyy-MM-dd"),
                        codigoSunatEstablecimiento = "0000",
                        ordenCompra = row["OrdenCompra"].ToString().Trim()==string.Empty ? null : row["OrdenCompra"].ToString().Trim()
                    }


                    ////////totalVentaInafecta = Convert.ToDouble(row["totalVentaInafecta"]),
                    ////////totalVentaExonerada = Convert.ToDouble(row["totalVentaExonerada"]),
                    ////////sumatoriaIgv = Convert.ToDouble(row["sumatoriaIgv"]),
                    ////////sumatoriaIsc = Convert.ToDouble(row["sumatoriaIsc"]),
                    ////////totalVenta = Convert.ToDouble(row["total"]),
                    ////////tipoMoneda = row["tipoMoneda"].ToString(),
                    ////////descuentoGlobal = Convert.ToDouble(row["descuentoGlobal"]),
                    ////////porcentajeDescuentoGlobal = Convert.ToDouble(row["porcentajeDescuentoGlobal"]),
                    ////////totalDescuento = Convert.ToDouble(row["totalDescuento"]),
                    ////////importePercepcion = Convert.ToDouble(row["importePercepcion"]),
                    ////////porcentajePercepcion = Convert.ToDouble(row["porcentajePercepcion"]),
                    //docRelacionada = new List<TelesolucionesDocRelacionada>(new TelesolucionesDocRelacionada { numero = row["docRelacionadaNdocu"].ToString() }),

                    //////////receptor = new TelesolucionesRecceptor { tipo = row["receptorTipo"].ToString(), nro = row["receptorNumero"].ToString(), razonSocial = row["ReceptorRazonSocial"].ToString().Trim() },

                };

                //if (row["OrdenCompra"].ToString().Trim()==string.Empty)
                //{
                //    tf.adicional =
                //    new TelesolucionesAdicionalCab
                //    {
                //        fechaVencimiento = Convert.ToDateTime(row["fechaVencimiento"]).ToString("yyyy-MM-dd"),
                //        codigoSunatEstablecimiento = "0000"
                //    };
                //}
                //else
                //{
                //    tf.adicional =
                //   new TelesolucionesAdicionalCab
                //   {
                //       fechaVencimiento = Convert.ToDateTime(row["fechaVencimiento"]).ToString("yyyy-MM-dd"),
                //       codigoSunatEstablecimiento = "0000",
                //       ordenCompra= row["OrdenCompra"].ToString()
                //   };
                //}

                lstguias.Add(new TelesolucionesGuiaRelacionada
                {
                    tipo = row["guiasRelacionadaTipo"].ToString(),
                    //serie = row["guiasRelacionadaSerie"].ToString(),
                    numero = row["guiasRelacionadaSerie"].ToString() + "-" + row["guiasRelacionadaNro"].ToString().Trim()
                });
                tf.guiasRelacionada = lstguias;
                //lstdocrelacionada.Add(new TelesolucionesDocRelacionada { numero = row["docRelacionadaNdocu"].ToString(),tipo = row["docRelacionadaCdocu"].ToString() });
                //////tf.docRelacionada = lstdocrelacionada;

                DbCommand cmd2;
                cmd2 = db.GetStoredProcCommand("usp_SunatTelesoluciones_EnviarFacturaDetalle", lst.Cdocu, lst.Ndocu);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandTimeout = 0;

                DataSet ds2 = db.ExecuteDataSet(cmd2);
                List<TelesolucionesItems> item = new List<TelesolucionesItems>();

                foreach (DataRow row2 in ds2.Tables[0].Rows)
                {
                    item.Add(new TelesolucionesItems
                    {
                        unidadMedidaCantidad = row2["unidad_de_medida"].ToString(),
                        cantidad = Convert.ToDouble(row2["cantidad"]),
                        descripcion = row2["descripcion"].ToString().Trim(),
                        valorUnitario = Convert.ToDouble(row2["valorUnitario"]),
                        precioVentaUnitario = Convert.ToDouble(row2["precioVentaUnitario"]),
                        tipoPrecioVentaUnitario = row2["tipoPrecioVentaUnitario"].ToString(),
                        montoTotalImpuestosItem= Convert.ToDouble(row2["montoAfectacionIgv"]),
                        //baseAfectacionIgv= Convert.ToDouble(row2["valorUnitario"]),
                        baseAfectacionIgv = Convert.ToDouble(row2["valorVenta"]),
                        montoAfectacionIgv = Convert.ToDouble(row2["montoAfectacionIgv"]),
                        porcentajeImpuesto= Convert.ToDouble(row2["porcentajeImpuesto"]),
                        tipoAfectacionIgv = row2["tipoAfectacionIgv"].ToString(),
                        codigoTributo= row2["codigoTributo"].ToString(),
                        valorVenta = Convert.ToDouble(row2["valorVenta"]),
                        codigoProducto = row2["codigoProducto"].ToString().Trim(),
                        codigoProductoSunat = row2["codigoProductoSunat"].ToString().Trim(),
                        
                        adicional= new TelesolucionesAdicionalDet
                        {
                            descuentoItem= Convert.ToDouble(row2["descuento"])==0 ? null : new TelesolucionesdescuentoItem
                            {
                                codigoMotivoDescuento= row2["codigoMotivoDescuento"].ToString().Trim(),
                                factorNumericoDescuento= Convert.ToDouble(row2["factorNumericoDescuento"]),
                                montoDescuento= Convert.ToDouble(row2["descuento"]),
                                montoBaseDescuento= Convert.ToDouble(row2["valorUnitario"])
                            }
                        }



                        //descuento = Convert.ToDouble(row2["descuento"])
                    });
                }
                tf.items = item;
            }
            
            return tf;

        }

        public void GuardarRespuestaSunatTelesoluciones(TelesolucionesRespuestaFactura e,TelesolucionesConstanciaRespuesta eC, int flg_fe, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("usp_SunatGuardarRespuestaSunatTelesoluciones", flg_fe,
                e.serie,e.numero,e.fechaEmision,e.emitido,e.baja,e.digestValue,e.signatureValue,eC.idConstancia,eC.idRespuesta,eC.codigo,
                eC.notas,eC.descripcion,e.idDocumento);
        }

        public void GuardarRespuestaAnulacionSunatTelesoluciones(string serie,string numero,TelesolucionesBajaDocumentoRespuesta e, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("usp_SunatGuardarRespuestaAnulacionSunatTelesoluciones", 
                serie, numero, e.fechaEmision, e.idComunicacionBaja, e.ticketConstancia, e.digestValue, e.signatureValue);
        }

        public void GuardarConstanciaSunatTelesoluciones(string cdocu,string ndocu, TelesolucionesConstanciaRespuesta eC, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("usp_SunatGuardarConstanciaSunatTelesoluciones", cdocu,ndocu,
                 eC.idConstancia, eC.idRespuesta, eC.codigo,
                eC.notas, eC.descripcion);
        }


        public Cliente ObtenerEmailCliente(string ruccli,string dbEmpresa)
        {
            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_EmailCliente",ruccli);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<Cliente> ls = new List<Cliente>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new Cliente
                {
                    Email = row["Email"].ToString(),
                    Nombre = row["nomcli"].ToString()

                }
                        );
            }

            return ls.First();
        }

        public List<EnvioEmailFE> ObtenerDocumentosPendientes_EnvioFE(string dbEmpresa)
        {
            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_ObtenerDocumentosPendientes_EnvioFE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<EnvioEmailFE> ls = new List<EnvioEmailFE>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new EnvioEmailFE
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    Cdocu = row["cdocu"].ToString(),
                    Ndocu = row["ndocu"].ToString(),
                    Correo = row["email"].ToString(),
                    Nomcli = row["nomcli"].ToString(),
                    Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                    Totn = Convert.ToDouble(row["totn"]),
                    Moneda = row["mone"].ToString(),
                    SerieFE = row["SerieFE"].ToString(),
                    NumeroFE = row["NumeroFE"].ToString()
                }
                        );
            }

            return ls;
        }


    }
}
