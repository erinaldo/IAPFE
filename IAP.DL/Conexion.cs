using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IAP.DL
{
    public class ConexionDC
    {
        //public static string Conectar()
        //{
        //    string strcadena = "Data Source=192.168.2.11;initial catalog=PRUEBA;user id=sa;password=EXQ*1410_$";
        //    return strcadena;
        //}
        public static string IpServidor = "localhost";
        public static string CadenaConexion_tran = "Data Source=" + IpServidor + ";Initial Catalog=bdNava01;user ID=sa;Password=sa";

        public static string ConectarBD(string base_datos)
        {
            string CadenaConexion = null;
            
            if (base_datos.ToUpper() == "BDNAVA01")
            {
                CadenaConexion = "Data Source=" + IpServidor + ";Initial Catalog=bdNava01;user ID=sa;Password=sa";
            }
            else if (base_datos.ToUpper() == "BDNAVA02")
            {
                CadenaConexion = "Data Source=" + IpServidor + ";Initial Catalog=bdNava02;user ID=sa;Password=sa";
            }
            else if (base_datos == "Android")
            {
                CadenaConexion = "Data Source = SQL5014.myASP.NET; Initial Catalog = DB_9F4565_ANDROID; User Id = DB_9F4565_ANDROID_admin; Password = Slipnotxx1408;";
            }
            //BD DE ANDROID EN HOSTING MYASP
            

            //else if (base_datos == "TEST_APSSA")
            //{
            //    CadenaConexion = "Data Source=192.168.2.11;Initial Catalog=TEST_APSSA;Persist Security Info=True;user ID=prometeo;Password=prometeo";
            //}
            return CadenaConexion;
        }
    }
}