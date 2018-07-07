using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BL
{
    public class Android
    {
        public static void Actualizar_usuario(string coduser, string nombre, string apellidos, string sexo, string usuario, string clave,
            string ruccli, string nomcli, string dircli, string db)
        {
            try
            {
                DL.Android.Actualizar_usuario(coduser,nombre,apellidos,sexo,usuario,clave,ruccli,nomcli,dircli,db);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static void Insertar_usuario(string coduser, string nombre, string apellidos, string sexo, string usuario, string clave,
        string ruccli, string nomcli, string dircli, string db)
        {
            try
            {
                DL.Android.Insertar_usuario(coduser, nombre, apellidos, sexo, usuario, clave, ruccli, nomcli, dircli, db);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
