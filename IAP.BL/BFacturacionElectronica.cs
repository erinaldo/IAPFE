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
        DL.DFacturacionElectronica Dfe = new DL.DFacturacionElectronica();

        public BFacturacionElectronica() { }

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


            


            //string json = JsonConvert.SerializeObject(eAnulacion, Formatting.Indented);
            //byte[] bytes = Encoding.Default.GetBytes(json);
            //string json_en_utf_8 = Encoding.UTF8.GetString(bytes);

            ////enviar a nubefact
            //string json_de_respuesta = SendJson(ruta, json_en_utf_8, token); //falta la ruta y el token
            //dynamic r = JsonConvert.DeserializeObject<SunatRespuestaFBN>(json_de_respuesta);
            //string r2 = JsonConvert.SerializeObject(r, Formatting.Indented);
            //dynamic json_r_in = JsonConvert.DeserializeObject<SunatRespuestaFBN>(r2);

            //dynamic leer_respuesta = EnviarNubeFact(eAnulacion, ruta, token);
            //dynamic leer_respuesta = JsonConvert.DeserializeObject<SunatRespuestaFBN>(json_de_respuesta);

            flg_fe = 0;
            //eRespuesta = new SunatRespuestaFBN();
            //errorsunat = leer_respuesta.errors == null ? string.Empty : Convert.ToString(leer_respuesta.errors);


            eRespuesta = EnviarNubeFact(eAnulacion, ruta, token);

            if (eRespuesta.errors == "N")
            {
                //eRespuesta.tipo_de_comprobante = leer_respuesta.tipo_de_comprobante;
                //eRespuesta.serie = leer_respuesta.serie;
                //eRespuesta.numero = leer_respuesta.numero;
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


    }
}
