using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace IAP.DL
{
    public class Android
    {
        public static void Actualizar_usuario(string coduser,string nombre,string apellidos,string sexo,string usuario,string clave,
            string ruccli,string nomcli,string dircli, string db)
        {
            string strSql = "sp_actualizar_usuario";
            /*
                @coduser int,
                @nombre varchar(25),
                @apellidos varchar(100),
                @sexo char(1),
                @usuario varchar(50),
                @clave varchar(500),
                @ruccli varchar(15),
                @nomcli varchar(150),
                @dircli varchar(300)
             */
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@coduser", coduser));
            arParams.Add(new SqlParameter("@nombre", nombre));
            arParams.Add(new SqlParameter("@apellidos", apellidos));
            arParams.Add(new SqlParameter("@sexo", sexo));
            arParams.Add(new SqlParameter("@usuario", usuario));
            arParams.Add(new SqlParameter("@clave", clave));
            arParams.Add(new SqlParameter("@ruccli", ruccli));
            arParams.Add(new SqlParameter("@nomcli", nomcli));
            arParams.Add(new SqlParameter("@dircli", dircli));

            Convert.ToInt32(SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray()));
        }

        public static void Insertar_usuario(string coduser, string nombre, string apellidos, string sexo, string usuario, string clave,
        string ruccli, string nomcli, string dircli, string db)
        {
            string strSql = "sp_insertar_usuario";
            /*
                @coduser int,
                @nombre varchar(25),
                @apellidos varchar(100),
                @sexo char(1),
                @usuario varchar(50),
                @clave varchar(500),
                @ruccli varchar(15),
                @nomcli varchar(150),
                @dircli varchar(300)
             */
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@coduser", coduser));
            arParams.Add(new SqlParameter("@nombre", nombre));
            arParams.Add(new SqlParameter("@apellidos", apellidos));
            arParams.Add(new SqlParameter("@sexo", sexo));
            arParams.Add(new SqlParameter("@usuario", usuario));
            arParams.Add(new SqlParameter("@clave", clave));
            arParams.Add(new SqlParameter("@ruccli", ruccli));
            arParams.Add(new SqlParameter("@nomcli", nomcli));
            arParams.Add(new SqlParameter("@dircli", dircli));

            Convert.ToInt32(SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray()));
        }
    }
}
