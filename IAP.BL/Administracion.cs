using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAP.DL;
using System.Data;
using System.Security.Cryptography;
namespace IAP.BL
{
    public class Administracion
    {
        public static string clave = "cadenadecifrado";

        public static void Generar_Backup(string directorio, string bd)
        {
            try
            {
                DL.Administracion.Generar_Backup(directorio, bd);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


        public static void Script_sql_BL(string Consulta_Archivo, string bd)
        {
            try
            {
                DL.Administracion.Script_sql(Consulta_Archivo, bd);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static bool Borrar_Documento(string numero_BL, string tipo_docu_BL, string tipo_eliminacion_BL, string db_BL)
        {
            try
            {
                return DL.Administracion.Borrar_Documento(numero_BL, tipo_docu_BL, tipo_eliminacion_BL, db_BL);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public static void borrar_arqueo(string num_planilla, string bd)
        {
            try
            {
                DL.Administracion.Borrar_Arqueo(num_planilla, bd);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static DataTable Verificar_Doc_Eliminado_BL(string ndocu, string cdocu,string tipo_operacion_bl, string bd)
        {
            try
            {
                return DL.Administracion.Verificar_doc_eliminado(cdocu, ndocu,tipo_operacion_bl, bd);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public static string cifrar(string cadena)
        {

            byte[] llave; //Arreglo donde guardaremos la llave para el cifrado 3DES.

            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena); //Arreglo donde guardaremos la cadena descifrada.

            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();

            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos la cadena cifrada.
            tripledes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }
        public static string descifrar(string cadena)
        {

            byte[] llave;

            byte[] arreglo = Convert.FromBase64String(cadena); // Arreglo donde guardaremos la cadena descovertida.

            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();

            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();

            string cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado); // Obtenemos la cadena
            return cadena_descifrada; // Devolvemos la cadena
        }

    }
}
