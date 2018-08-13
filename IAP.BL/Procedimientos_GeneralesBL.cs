using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.IO;
using IAP.DL;
using System.Text;
using Newtonsoft.Json;

namespace IAP.BL
{
    public class Procedimientos_GeneralesBL
    {
        public static DataSet CargaExcel(string RutaExcelBL, string NombreHojaBL)
        {
            try
            {
                DataSet ds_le = new DataSet();
                ds_le = DL.Procedimientos_GeneralesDL.CargaExcel(RutaExcelBL, NombreHojaBL);
                ds_le.Tables[0].TableName = "listaexcel";
                return ds_le;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public string ObtenerDataApiRest(string ruta, object entidad, string token)
        {
            try
            {
                string json = JsonConvert.SerializeObject(entidad, Formatting.Indented);
                byte[] bytes = Encoding.Default.GetBytes(json);
                string json_en_utf_8 = Encoding.UTF8.GetString(bytes);
                using (var client = new WebClient())
                {
                    /// ESPECIFICAMOS EL TIPO DE DOCUMENTO EN EL ENCABEZADO
                    client.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    /// ASI COMO EL TOKEN UNICO
                    client.Headers[HttpRequestHeader.Authorization] = "Token token=" + token;
                    /// OBTENEMOS LA RESPUESTA
                    string respuesta = client.UploadString(ruta, "POST", json_en_utf_8);
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
