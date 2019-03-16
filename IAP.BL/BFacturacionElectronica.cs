using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAP.BE;
using System.Transactions;
using IAP.DL;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace IAP.BL
{
    public class BFacturacionElectronica
    {
        MemoryStream PDFTelesoluciones = new MemoryStream();
        DL.DFacturacionElectronica Dfe = new DL.DFacturacionElectronica();

        public BFacturacionElectronica() { }

        public ProveedorFE ObtenerProveedorFE(int idempresa, string dbEmpresa)
        {
            return Dfe.ObtenerProveedorFE(idempresa,dbEmpresa);
        }

        public List<ProveedorFE> ObtenerDatosProveedorFE(string dbEmpresa)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                return Dfe.ObtenerDatosProveedorFE(dbEmpresa);
                ts.Complete();
            }
        }

        public List<Documentov> ObtenerDocumentosFBNC(string cdocu, DateTime fechai, DateTime fechaf, string cliente, string documento, Int32 enviadosunat, int anulado, string dbconexion)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                return Dfe.ObtenerDocumentosFBNC(cdocu, fechai, fechaf, cliente, documento,enviadosunat,anulado, dbconexion);
                ts.Complete();
            }
        }

        public List<DocumentovDet> ObtenerDocumentosDetalleFBNC(string cdocu, string ndocu, string dbconexion)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                return Dfe.ObtenerDocumentosDetalleFBNC(cdocu, ndocu, dbconexion);
                ts.Complete();
            }
        }

        public SunatRespuestaFBN SunatConsultarDocumentosFBN(Documentov eFac, string ruta, string token,string dbconexion)
        {
            string errorsunat = string.Empty;
            SunatRespuestaFBN eRespuesta;

            SunatConsultaFBN eConsulta = new SunatConsultaFBN();
            eConsulta.operacion = "consultar_comprobante";
            eConsulta.tipo_de_comprobante = Convert.ToInt32(eFac.Tipo_de_comprobante);
            eConsulta.serie = eFac.Serie;
            eConsulta.numero = Convert.ToInt32(eFac.Numero);

            //dynamic leer_respuesta = EnviarNubeFact(eConsulta, ruta, token);

            eRespuesta = new SunatRespuestaFBN();
            eRespuesta = EnviarNubeFact(eConsulta, ruta, token);
            return eRespuesta;
        }
        public void SunatAnularDocumentosFBN(Documentov eFac,string ruta,string token, string dbconexion)
        {
            int flg_fe = 0;
            string errorsunat = string.Empty;
            SunatRespuestaFBN eRespuesta = new SunatRespuestaFBN();

            SunatGenerarAnulacionFBN eAnulacion = new SunatGenerarAnulacionFBN();
            eAnulacion.operacion = "generar_anulacion";
            eAnulacion.tipo_de_comprobante = Convert.ToInt32(eFac.Tipo_de_comprobante);
            eAnulacion.serie = eFac.Serie.Trim();
            eAnulacion.numero = Convert.ToInt32(eFac.Numero);
            eAnulacion.motivo = eFac.Motivo_Anulacion.Trim();
            eAnulacion.codigo_unico = string.Empty;
            

            flg_fe = 0;
            

            eRespuesta = EnviarNubeFact(eAnulacion, ruta, token);

            if (eRespuesta.errors == "N")
            {
                

                flg_fe = 2;//eRespuesta.aceptada_por_sunat == true ? 2 : 1;

                Dfe.GuardarRespuestaSunat(eRespuesta, eFac.Cdocu, eFac.Ndocu, flg_fe, dbconexion);
            

            }
            else
            {
                errorsunat = "Tipo Documento: " + eFac.Cdocu + "\n" + "Numero Documento: " + eFac.Ndocu + "\n" + "Error Sunat: " + Convert.ToString(eRespuesta.errors);
                throw new Exception(errorsunat);

            }
        }

        


        public void SunatEnviarDocumentosFBN(List<Documentov> lst, string ruta, string token,string dbconexion)
        {
            string errorsunat = string.Empty;
            List<SunatDocumentoFBN> lsunat = new List<SunatDocumentoFBN>();
            SunatRespuestaFBN eRespuesta = new SunatRespuestaFBN();
            int flg_fe = 0;
            //using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            //{
            foreach (Documentov e in lst) //por cada documento
            {

                lsunat.Add(Dfe.SunatEnviarDocumentosFBN_ObtenerDatos(e, dbconexion));
            }
            
            foreach (SunatDocumentoFBN lista in lsunat)
            {
                eRespuesta = new SunatRespuestaFBN();
               

                flg_fe = 0;


                eRespuesta = EnviarNubeFact(lista, ruta, token);
                
                if (eRespuesta.errors == "N")
                {
                    
                    flg_fe = 1;//eRespuesta.aceptada_por_sunat == true ? 1 : 0;

                    Dfe.GuardarRespuestaSunat(eRespuesta, lista.cdocu, lista.ndocu, flg_fe, dbconexion);
                    
                }
                else
                {
                    errorsunat = "Tipo Documento: " + lista.cdocu + "\n"+"Numero Documento: " + lista.ndocu + "\n"+ "Error Sunat: " + Convert.ToString(eRespuesta.errors);
                    throw new Exception(errorsunat);
                    
                }
            }
        }
        public void SunatEnviarDocumentosFBN_V2(List<Documentov> lst, string ruta, string token, string dbconexion)
        {
            string errorsunat = string.Empty;
            SunatDocumentoFBN_V2 Esunat = new SunatDocumentoFBN_V2();
            SunatRespuestaFBN eRespuesta = new SunatRespuestaFBN();
            int flg_fe = 0;
            //using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            //{
            foreach (Documentov e in lst) //por cada documento
            {

                Esunat=Dfe.SunatEnviarDocumentosFBN_ObtenerDatos_V2(e, dbconexion);

                
                eRespuesta = new SunatRespuestaFBN();
                flg_fe = 0;
                eRespuesta = EnviarNubeFact(Esunat, ruta, token);

                if (eRespuesta.errors == "N")
                {

                    flg_fe = 1;//eRespuesta.aceptada_por_sunat == true ? 1 : 0;

                    Dfe.GuardarRespuestaSunat(eRespuesta, e.Cdocu, e.Ndocu, flg_fe, dbconexion);

                }
                else
                {
                    errorsunat = "Tipo Documento: " + e.Cdocu + "\n" + "Numero Documento: " + e.Ndocu + "\n" + "Error Sunat: " + Convert.ToString(eRespuesta.errors);
                    throw new Exception(errorsunat);

                }
                
            }
        }
        public string VerArchivoJson(List<Documentov> lst, string dbconexion)
        {
            string errorsunat = string.Empty;
            SunatDocumentoFBN_V2 Esunat = new SunatDocumentoFBN_V2();
            SunatRespuestaFBN eRespuesta = new SunatRespuestaFBN();
            string archivo=string.Empty;
  
            foreach (Documentov e in lst) //por cada documento
            {

                Esunat = Dfe.SunatEnviarDocumentosFBN_ObtenerDatos_V2(e, dbconexion);


                eRespuesta = new SunatRespuestaFBN();

                
                archivo = GenerarArchivoJson(Esunat);
                break;
            }
            return archivo;

        }

        public void GuardarRespuestaSunat_Consulta(string cdocu,string ndocu,SunatRespuestaFBN res,string dbconexion)
        {
            Dfe.GuardarRespuestaSunat(res, cdocu, ndocu,1, dbconexion);
        }
        //private SunatRespuestaFBN ObtenerRespuestaNubeFact(dynamic leer_respuesta)
        //{
            
        //    return eRespuesta;
        //}
        private string GenerarArchivoJson(Object entidad)
        {
            string json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);
            return json_en_utf_8;
        }
        private SunatRespuestaFBN EnviarNubeFact(Object entidad,string ruta,string token)
        {
            string json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            //enviar a nubefact
            string json_de_respuesta = string.Empty;
           
            json_de_respuesta = SendJson(ruta, json_en_utf_8, token); //falta la ruta y el token
            
         
            
            dynamic r = JsonConvert.DeserializeObject<SunatRespuestaFBN>(json_de_respuesta);
            string r2 = JsonConvert.SerializeObject(r, Formatting.Indented);
            dynamic json_r_in = JsonConvert.DeserializeObject<SunatRespuestaFBN>(r2);

            dynamic leer_respuesta = JsonConvert.DeserializeObject<SunatRespuestaFBN>(json_de_respuesta);
            SunatRespuestaFBN eRespuesta = new SunatRespuestaFBN();
            eRespuesta.tipo_de_comprobante = leer_respuesta.tipo_de_comprobante;
            eRespuesta.serie = leer_respuesta.serie;
            eRespuesta.numero = leer_respuesta.numero;
            eRespuesta.enlace = leer_respuesta.enlace;
            eRespuesta.aceptada_por_sunat = leer_respuesta.aceptada_por_sunat;
            eRespuesta.sunat_description = leer_respuesta.sunat_description;
            eRespuesta.sunat_note = leer_respuesta.sunat_note;
            eRespuesta.sunat_responsecode = leer_respuesta.sunat_responsecode;
            eRespuesta.sunat_soap_error = leer_respuesta.sunat_soap_error;
            eRespuesta.pdf_zip_base64 = leer_respuesta.pdf_zip_base64;
            eRespuesta.xml_zip_base64 = leer_respuesta.xml_zip_base64;
            eRespuesta.cdr_zip_base64 = leer_respuesta.cdr_zip_base64;
            eRespuesta.cadena_para_codigo_qr = leer_respuesta.cadena_para_codigo_qr;
            eRespuesta.codigo_hash = leer_respuesta.codigo_hash;
            eRespuesta.enlace_del_pdf = leer_respuesta.enlace_del_pdf;
            eRespuesta.enlace_del_xml = leer_respuesta.enlace_del_xml;
            eRespuesta.enlace_del_cdr = leer_respuesta.enlace_del_cdr;
            eRespuesta.errors = leer_respuesta.errors;
            eRespuesta.fe_codigo = leer_respuesta.fe_codigo;
            eRespuesta.errors= leer_respuesta.errors == null ? "N" : Convert.ToString(leer_respuesta.errors);
            return eRespuesta;
        }
        string SendJson(string ruta, string json, string token)
        {
            try
            {
                using (var client = new WebClient())
                {
                    /// ESPECIFICAMOS EL TIPO DE DOCUMENTO EN EL ENCABEZADO
                    client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    /// ASI COMO EL TOKEN UNICO
                    client.Headers[HttpRequestHeader.Authorization] = "Token token=" + token;
                    /// OBTENEMOS LA RESPUESTA
                    string respuesta = client.UploadString(ruta, "POST", json);
                    /// Y LA 'RETORNAMOS'
                    return respuesta;
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                //string respuesta = ex.Message.ToString();// .Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                //return respuesta;
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                throw new Exception(respuesta.ToString());
            }
        }


        /* ENVIO DE FACTURA ELECTRONICA TELESOLUCIONES */

        public void TelesolucionesAnularDocumento(Documentov eFac, List<DocumentovDet> lstdetalle, string ruta, string token, string dbconexion)
        {
            int flg_fe = 0;
            ruta = "https://api2.facturaonline.pe/comunicacionbaja";
            string errorsunat = string.Empty;
            TelesolucionesBajaDocumentoRespuesta eRespuesta = new TelesolucionesBajaDocumentoRespuesta();

            TelesolucionesBajaDocumento eAnulacion = new TelesolucionesBajaDocumento();
            string mes = string.Empty;
            string dia = string.Empty;

            mes = (Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Month.ToString().Length == 1 ? "0" + Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Month.ToString() :
                Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Month.ToString());
            dia = (Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Day.ToString().Length == 1 ? "0" + Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Day.ToString() :
                Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Day.ToString());

            eAnulacion.fechaEmisionDocs = Convert.ToDateTime(eFac.TeleSol_FechaEmitido).Year.ToString() +
                "-" + mes + "-" + dia;
            eAnulacion.serie = eFac.TeleSol_Serie;
            eAnulacion.numero = Convert.ToInt32(eFac.TeleSol_Numero);

            List<TelesolucionesBajaItem> lstdet = new List<TelesolucionesBajaItem>();
            foreach(DocumentovDet e in lstdetalle)
            {
                lstdet.Add(new TelesolucionesBajaItem
                {
                    descripcion = e.Product.Descr.Trim(),
                    serie = eFac.TeleSol_Serie,
                    numero = Convert.ToInt32(eFac.TeleSol_Numero),
                    tipoComprobante = eFac.Cdocu //01 FACTURA  03 BOLETA
                });
            }
            eAnulacion.items = lstdet;

            

            flg_fe = 0;


            eRespuesta = EnviarTelesolucionesBaja (eAnulacion, ruta, token);

            if (string.IsNullOrEmpty(eRespuesta.status))
            {
                Dfe.GuardarRespuestaAnulacionSunatTelesoluciones(eAnulacion.serie, eAnulacion.numero.ToString(),eRespuesta, dbconexion);
            }
            else
            {
                throw new Exception(eRespuesta.message.ToString());
            }
           
        }

       
        
        public void TelesolucionesEnviarFactura(List<Documentov> lst, string ruta, string token, string dbconexion,ref string telsol_serie,ref string telsol_numero)
        {
            string errorsunat = string.Empty;
            string tipodocumento;
            List<TelesolucionesFactura> lsunat = new List<TelesolucionesFactura>();
            TelesolucionesRespuestaFactura eRespuestaFactura = new TelesolucionesRespuestaFactura();
            int flg_fe = 0;
            //using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            //{
            foreach (Documentov e in lst) //por cada documento
            {

                lsunat.Add(Dfe.SunatEnviarDocumentosTelesolucionesFactura(e, dbconexion));
            }
            if(!lsunat.Any())
            {
                throw new Exception("Por favor verificar los datos del cliente de la factura seleccionada");
            }

            foreach (TelesolucionesFactura lista in lsunat)
            {
                eRespuestaFactura = new TelesolucionesRespuestaFactura();


                flg_fe = 0;
                tipodocumento = lista.serie.Substring(0, 1);
                ruta = tipodocumento == "F" ? "https://api2.facturaonline.pe/factura" : "https://api2.facturaonline.pe/boleta";
                
                eRespuestaFactura = EnviarTelesoluciones(lista, ruta, token);

                if (eRespuestaFactura.idDocumento != 0)
                {
                    telsol_serie = eRespuestaFactura.serie;
                    telsol_numero = eRespuestaFactura.numero.ToString();
                    flg_fe = 1;//eRespuesta.aceptada_por_sunat == true ? 1 : 0;
                    TelesolucionesConstancia econs = new TelesolucionesConstancia
                    {
                        id = eRespuestaFactura.serie + eRespuestaFactura.numero
                    };

                    TelesolucionesConstanciaRespuesta eConsR = new TelesolucionesConstanciaRespuesta();
                    //if (eConsR.status.ToString().Trim() == string.Empty)
                    //{
                    string rutaConstanacia = tipodocumento == "F" ? "https://api2.facturaonline.pe/factura/" + econs.id + "/constancia" : "https://api2.facturaonline.pe/boleta/" + econs.id + "/constancia";

                    Dfe.GuardarRespuestaSunatTelesoluciones(eRespuestaFactura, eConsR, flg_fe, dbconexion);

                    eConsR = ObtenerConstanciaDocumento(string.Empty, rutaConstanacia, token);
                    //}
                    
                    

                    //falta guardar respuesta

                    Dfe.GuardarRespuestaSunatTelesoluciones(eRespuestaFactura,eConsR, flg_fe, dbconexion);
                    if (!string.IsNullOrEmpty(eConsR.status))
                    {
                        throw new Exception(eConsR.message.ToString());
                    }

                    
                }
                else
                {
                    //errorsunat = "Tipo Documento: " + lista.cdocu + "\n" + "Numero Documento: " + lista.ndocu + "\n" + "Error Sunat: " + Convert.ToString(eRespuesta.errors);
                    throw new Exception(errorsunat);

                }
            }
        }

        private TelesolucionesRespuestaFactura EnviarTelesoluciones(Object entidad, string ruta, string token)
        {
            TelesolucionesFactura lstfacturaTemp = (TelesolucionesFactura)entidad;
            string json = string.Empty;
            JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
            json = JsonConvert.SerializeObject(entidad, settings);
            if (lstfacturaTemp.guiasRelacionada.Where(x=> x.tipo.Trim()==string.Empty).Any())
            {
                var guia = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
                guia.Property("guiasRelacionada").Remove();
                json = JsonConvert.SerializeObject(guia, Formatting.Indented);
            }

            //if (lstfacturaTemp.adicional.ordenCompra.Trim() == string.Empty)
            //{
               
            //    var ordencompra = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json,);

            //    ordencompra.Property("adicional.ordencompra").Remove();
               
            //    json = JsonConvert.SerializeObject(ordencompra, Formatting.Indented);
            //}

            

            //if(lstfacturaTemp.docRelacionada.Where(x=> x.numero.Trim()==string.Empty).Any())
            //{
            //    var docre = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            //    docre.Property("docRelacionada").Remove();
            //    json = JsonConvert.SerializeObject(docre, Formatting.Indented);
            //}

            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            //enviar a nubefact
            string json_de_respuesta = string.Empty;

            json_de_respuesta = TelesolucionesSendJson(ruta, json_en_utf_8, token,"FACTURA"); //falta la ruta y el token



            //dynamic r = JsonConvert.DeserializeObject<TelesolucionesRespuestaFactura>(json_de_respuesta);
            //string r2 = JsonConvert.SerializeObject(r, Formatting.Indented);
            //dynamic json_r_in = JsonConvert.DeserializeObject<TelesolucionesRespuestaFactura>(r2);

            dynamic leer_respuesta = JsonConvert.DeserializeObject<TelesolucionesRespuestaFactura>(json_de_respuesta);
            TelesolucionesRespuestaFactura eRespuesta = new TelesolucionesRespuestaFactura();
            //eRespuesta.tipo_de_comprobante = leer_respuesta.tipo_de_comprobante;
            eRespuesta.fechaEmision = leer_respuesta.fechaEmision;
            eRespuesta.fechaEmitido = leer_respuesta.fechaEmitido;
            eRespuesta.codigoComprobante = leer_respuesta.codigoComprobante;
            eRespuesta.importeLetras = leer_respuesta.importeLetras;
            eRespuesta.tipoMonedaHuman = leer_respuesta.tipoMonedaHuman;
            eRespuesta.tipoMonedaSimbolo = leer_respuesta.tipoMonedaSimbolo;
            eRespuesta.idFactura = Convert.ToInt32(leer_respuesta.idFactura);
            eRespuesta.serie = leer_respuesta.serie;
            eRespuesta.numero = leer_respuesta.numero;
            eRespuesta.emitido = leer_respuesta.emitido;
            eRespuesta.baja = leer_respuesta.baja;
            eRespuesta.digestValue = leer_respuesta.digestValue; //codigo HASH del comprobante
            eRespuesta.signatureValue = leer_respuesta.signatureValue;
            eRespuesta.idBoleta = Convert.ToInt32(leer_respuesta.idBoleta);
            eRespuesta.idDocumento = eRespuesta.idFactura == 0 ? eRespuesta.idBoleta : eRespuesta.idFactura;

            //eRespuesta.enlace = leer_respuesta.enlace;
            //eRespuesta.aceptada_por_sunat = leer_respuesta.aceptada_por_sunat;
            //eRespuesta.sunat_description = leer_respuesta.sunat_description;
            //eRespuesta.sunat_note = leer_respuesta.sunat_note;
            //eRespuesta.sunat_responsecode = leer_respuesta.sunat_responsecode;
            //eRespuesta.sunat_soap_error = leer_respuesta.sunat_soap_error;
            //eRespuesta.pdf_zip_base64 = leer_respuesta.pdf_zip_base64;
            //eRespuesta.xml_zip_base64 = leer_respuesta.xml_zip_base64;
            //eRespuesta.cdr_zip_base64 = leer_respuesta.cdr_zip_base64;
            //eRespuesta.cadena_para_codigo_qr = leer_respuesta.cadena_para_codigo_qr;
            //eRespuesta.codigo_hash = leer_respuesta.codigo_hash;
            //eRespuesta.enlace_del_pdf = leer_respuesta.enlace_del_pdf;
            //eRespuesta.enlace_del_xml = leer_respuesta.enlace_del_xml;
            //eRespuesta.enlace_del_cdr = leer_respuesta.enlace_del_cdr;
            //eRespuesta.errors = leer_respuesta.errors;
            //eRespuesta.fe_codigo = leer_respuesta.fe_codigo;
            //eRespuesta.errors = leer_respuesta.errors == null ? "N" : Convert.ToString(leer_respuesta.errors);
            return eRespuesta;
        }
        private TelesolucionesBajaDocumentoRespuesta EnviarTelesolucionesBaja(Object entidad, string ruta, string token)
        {
            string json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            //enviar a nubefact
            string json_de_respuesta = string.Empty;

            json_de_respuesta = TelesolucionesSendJson(ruta, json_en_utf_8, token,"BAJA"); //falta la ruta y el token

            

            dynamic leer_respuesta = JsonConvert.DeserializeObject<TelesolucionesBajaDocumentoRespuesta>(json_de_respuesta);
            TelesolucionesBajaDocumentoRespuesta eRespuesta = new TelesolucionesBajaDocumentoRespuesta();
            //eRespuesta.tipo_de_comprobante = leer_respuesta.tipo_de_comprobante;
            eRespuesta.fechaEmision = leer_respuesta.fechaEmision;
            eRespuesta.fechaEmitido = leer_respuesta.fechaEmitido;
            
            eRespuesta.numero = leer_respuesta.numero;
            eRespuesta.emitido = leer_respuesta.emitido;
            eRespuesta.ticketConstancia = leer_respuesta.ticketConstancia;
            eRespuesta.emitido = leer_respuesta.emitido;
            eRespuesta.idConstancia = leer_respuesta.idConstancia;
            eRespuesta.digestValue = leer_respuesta.digestValue; //codigo HASH del comprobante
            eRespuesta.signatureValue = leer_respuesta.signatureValue;
            eRespuesta.idConstancia = leer_respuesta.idConstancia;
            eRespuesta.code= leer_respuesta.code;
            eRespuesta.status = leer_respuesta.status;
            eRespuesta.message = leer_respuesta.message;
            eRespuesta.idComunicacionBaja = leer_respuesta.idComunicacionBaja;
            return eRespuesta;
        }

        private TelesolucionesConstanciaRespuesta ObtenerConstanciaDocumento(Object entidad, string ruta, string token)
        {
            string json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
            byte[] bytes = Encoding.Default.GetBytes(json);
            string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            
            string json_de_respuesta = string.Empty;

            json_de_respuesta = TelesolucionesSendJson(ruta, string.Empty, token,"CONSTANCIA"); //falta la ruta y el token



            dynamic leer_respuesta = JsonConvert.DeserializeObject<TelesolucionesConstanciaRespuesta>(json_de_respuesta);
            TelesolucionesConstanciaRespuesta eRespuesta = new TelesolucionesConstanciaRespuesta();
            
            eRespuesta.fechaEmision = leer_respuesta.fechaEmision;
            eRespuesta.idConstancia = leer_respuesta.idConstancia;

            eRespuesta.idRespuesta = leer_respuesta.idRespuesta;
            eRespuesta.serie = leer_respuesta.serie;
            eRespuesta.numero = leer_respuesta.numero;
            eRespuesta.tipo = leer_respuesta.tipo;
            eRespuesta.codigo = leer_respuesta.codigo;
            eRespuesta.notas = leer_respuesta.notas; 
            eRespuesta.descripcion = leer_respuesta.descripcion;
            //ERROR
            eRespuesta.code = leer_respuesta.code;
            eRespuesta.status = leer_respuesta.status;
            eRespuesta.message = leer_respuesta.message;


            return eRespuesta;
        }

        public MemoryStream ObtenerPdfTelesoluciones(string tipodocumento,string idFactura)
        {
            //idFactura = "43107";
            string ruta = tipodocumento=="F" ? ("https://api2.facturaonline.pe/factura/" + idFactura + "/exportar") : ("https://api2.facturaonline.pe/boleta/" + idFactura + "/exportar");
            string RespuestaPDF = TelesolucionesSendJson(ruta, string.Empty, string.Empty,"PDF");
            return PDFTelesoluciones;
        }
        string TelesolucionesSendJson(string ruta, string json, string token,string tipoOperacion)
        {
            try
            {
                string respuesta = "";
                using (var client = new WebClient())
                {
                    //TELESOLUCIONES 
                    //ruta = 
                    DateTime timeStamp = DateTime.Now;
                    DateTime nx = new DateTime(1970, 1, 1);
                    TimeSpan ts = DateTime.UtcNow - nx;
                    Double unixTS = ts.TotalSeconds;

                    //string aK = "c73ed3b5f2085ffdd429044b4757b97917c7ea775c0d12eae388e6e9bf19bb17";
                    //string Ky = "7cb2040d868a8ed6d044fef4d6d37bcded6fd47425bab1b1973e6e66e440f3c2";
                    string aK = "d28a27c097baedcd36c9d83e4f9bb88002db4b1bfc1433da08aedd3c0415be36";
                    string Ky = "6e02181887cc0a63991ea0812e6ff0bfe76df3257ef22ff05b7795bd6b97c6b4";
                    string ToHash = string.Join("|", aK, unixTS);
                    string Hash = xHashString(ToHash, Ky);

                    /// ESPECIFICAMOS EL TIPO DE DOCUMENTO EN EL ENCABEZADO
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    //application/json; charset=utf-8
                    //client.Headers[HttpRequestHeader.Authorization] = "Token token=" + token;
                    client.Headers[HttpRequestHeader.Authorization] = "Fo " + aK + ":" + Hash + ":" + unixTS;

                    
                    /// OBTENEMOS LA RESPUESTA
                   
                    //SI PETICION ES SOBRE UNA CONSTANCIA 
                    if(tipoOperacion=="PDF")
                    {
//                        MemoryStream memory=
                        //client.DownloadFile(ruta, "c:\\data\\psdpsd.pdf");
                        //using (MemoryStream stream = new MemoryStream(client.DownloadData(ruta)))
                        //{
                        //    OpenExcel(stream);
                        //}
                        MemoryStream stream = new MemoryStream(client.DownloadData(ruta));
                        PDFTelesoluciones = stream;
                    }
                    if(tipoOperacion=="FACTURA")
                    {
                        respuesta = client.UploadString(ruta, "POST", json);
                    }
                    if(tipoOperacion=="CONSTANCIA")
                    {
                        respuesta = client.DownloadString(ruta);
                    }
                    if(tipoOperacion=="BAJA")
                    {
                        respuesta = client.UploadString(ruta, "POST", json);
                    }
                    
                    
                    /// Y LA 'RETORNAMOS'
                    return respuesta;
                }
            }
            catch (WebException ex)
            {
                /// EN CASO EXISTA ALGUN ERROR, LO TOMAMOS
                //string respuesta = ex.Message.ToString();// .Response.GetResponseStream()).ReadToEnd();
                /// Y LO 'RETORNAMOS'
                //return respuesta;
                var respuesta = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                throw new Exception(respuesta.ToString());
            }
        }

        


        private string xHashString(string StringToHash,string HachKey)
        {
            System.Text.UTF8Encoding myEncoder = new UTF8Encoding();
            Byte[] Key = myEncoder.GetBytes(HachKey);
            Byte[] Text = myEncoder.GetBytes(StringToHash);
            System.Security.Cryptography.HMACSHA256 myHMACSHA256 = new System.Security.Cryptography.HMACSHA256(Key);
            Byte[] HashCode = myHMACSHA256.ComputeHash(Text);
            String hash = BitConverter.ToString(HashCode).Replace("-", "");
            return hash.ToLower();
        }


        public void TelesolucionesObtenerConstancia(List<Documentov> lst, string ruta, string token, string dbconexion)
        {
            string errorsunat = string.Empty;
            string tipodocumento;
            string iddocumento = string.Empty;
            TelesolucionesRespuestaFactura eRespuestaFactura = new TelesolucionesRespuestaFactura();
            TelesolucionesConstanciaRespuesta eConsR = new TelesolucionesConstanciaRespuesta();
            foreach (Documentov lista in lst)
            {
                eRespuestaFactura = new TelesolucionesRespuestaFactura();
                
                tipodocumento = lista.Cdocu=="01" ? "F" : "B";
                //iddocumento= lista.TeleSol_IdFactura;
                iddocumento = lista.TeleSol_Serie.ToString() + lista.TeleSol_Numero.ToString();


                eConsR = new TelesolucionesConstanciaRespuesta();
             
                string rutaConstanacia = tipodocumento == "F" ? "https://api2.facturaonline.pe/factura/" + iddocumento + "/constancia" : "https://api2.facturaonline.pe/boleta/" + iddocumento + "/constancia";

                //Dfe.GuardarRespuestaSunatTelesoluciones(eRespuestaFactura, eConsR, flg_fe, dbconexion);

                eConsR = ObtenerConstanciaDocumento(string.Empty, rutaConstanacia, token);
               
                Dfe.GuardarConstanciaSunatTelesoluciones(lista.Cdocu,lista.Ndocu, eConsR,dbconexion);
               
                
            }
        }

    }
}
