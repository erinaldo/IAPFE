using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAP.BE;

namespace IAP.Win
{
    public class Global
    {
        public static string vUserBaseDatos = "bdNava01";
        public static string vUserBaseDatosAndroid = "Android";
        public static string vUserServer = string.Empty;
        public static string vIpServidor = "";

        public static Boolean UserAdministrador = false;
        public static string login_conforme="";

        /*CREDENCIALES DE USUARIO Y PASSWORD*/
        public static string vUserAdministrador = "administrador";
        public static string vUserPassAdministrador = "admin14$";

        public static string vUserCliente = "cliente";
        public static string vUserPassCliente = "cliente";

        //CLAVE DE IAP
        //public static string vRuta = "https://www.nubefact.com/api/v1/9c5d5d5f-5287-4412-91bd-632b7e8e89c0";
        //public static string vToken = "0edb742bde374b32a446d1e27b0a8cf53eea338fa3eb49eca536a82b41bb5341";

        //CLAVE DE GRUPOIAP
        public static string vRuta = "https://api.nubefact.com/api/v1/baad9aca-bf90-44d7-b83e-875b10d52ccd";
        public static string vToken = "303479832dd7424c9cf93530300c7e94c6abf0a5dff949d98838b651de90e618";

        //CALVE DEMO
        //public static string vRuta = "https://demo.nubefact.com/api/v1/03989d1a-6c8c-4b71-b1cd-7d37001deaa0";
        //public static string vToken = "d0a80b88cde446d092025465bdb4673e103a0d881ca6479ebbab10664dbc5677";

        public static ProveedorFE vDatosProveedor = new ProveedorFE();

        public static string vTelemovilAK = string.Empty;
        public static string vTelemovilSK = string.Empty;
    }
}
