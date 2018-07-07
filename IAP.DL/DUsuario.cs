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
    public class DUsuario
    {
        public Boolean ObtenerUsuario(string correo,string contrasena, string dbEmpresa)
        {
            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("ObtenerUsuario",correo,contrasena);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            return Convert.ToBoolean(db.ExecuteScalar(cmd));
        }
        public List<Usuario> ObtenerUsuariosIntranet(int id, string nombres,int esLista,string dbEmpresa)
        {

            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("ObtenerUsuarioIntranet",id,nombres,esLista);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<Usuario> ls = new List<Usuario>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new Usuario(
                        Convert.ToInt32(row["Id"]),
                        Convert.ToString(row["Nombres"]),
                        Convert.ToString(row["Apellidos"]),
                        Convert.ToString(row["RazonSocial"]),
                        Convert.ToString(row["Correo"]),
                        Convert.ToString(row["Contrasena"]),
                        Convert.ToDateTime(row["FechaRegistro"])));
            }
            return ls;
        }
        public Boolean RegistrarUsuarioIntranet(Usuario eu,string dbEmpresa)
        {
            Database db = DatabaseFactory.CreateDatabase(dbEmpresa);
            db.ExecuteNonQuery("RegistrarUsuarioIntranet", eu.Id, eu.Nombres, eu.Apellidos, eu.RazonSocial, eu.Correo, eu.Contrasena);
            return true;
        }
    }
}
