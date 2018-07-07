using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace IAP.DL
{
    public class Administracion
    {
        public static bool Borrar_Documento(string numero, string tipo_docu, string tipo_eliminacion, string db)
        {
            bool result=true;
            if (tipo_eliminacion == "F")
            {
                string strSql = "USP_EliminarDocVenta2016XndocuCodDocu";
                List<SqlParameter> arParams = new List<SqlParameter>();
                arParams.Add(new SqlParameter("@ndocu", numero));
                arParams.Add(new SqlParameter("@cdocu", tipo_docu));
                Convert.ToInt32(SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db),CommandType.StoredProcedure, strSql, arParams.ToArray()));
                //SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
                //return orden_servicio_linea;
            }
            else
            {
                string strSql = "sp_elimina_guideremision";
                List<SqlParameter> arParams = new List<SqlParameter>();
                arParams.Add(new SqlParameter("@ndocu", numero));
                Convert.ToInt32(SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray()));
                //SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
            }
            return result;
        }
        public static DataTable Verificar_doc_eliminado(string cdocu, string ndocu,string tipo_operacion, string db)
        {
            if (tipo_operacion == "F")
            {
                string strSql = @"select LTRIM(RTRIM(nomcli))+' - '+LTRIM(RTRIM(ruccli))+' - '+cdocu+'/'+ndocu  AS DOCUMENTO from mst01fac where ndocu=@ndocu and cdocu=@cdocu;";

                List<SqlParameter> arParam = new List<SqlParameter>();
                arParam.Add(new SqlParameter("@ndocu", ndocu));
                arParam.Add(new SqlParameter("@cdocu", cdocu));
                return SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.Text, strSql, arParam.ToArray()).Tables[0];
            }
            else
            {
                string strSql = @"select LTRIM(RTRIM(nomcli))+' - '+LTRIM(RTRIM(ruccli))+' - '+cdocu+'/'+ndocu  AS DOCUMENTO from mst01gui where ndocu=@ndocu and cdocu=@cdocu;";

                List<SqlParameter> arParam = new List<SqlParameter>();
                arParam.Add(new SqlParameter("@ndocu", ndocu));
                arParam.Add(new SqlParameter("@cdocu", cdocu));
                return SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.Text, strSql, arParam.ToArray()).Tables[0];
            }
        }
        public static void Borrar_Arqueo(string num_planilla,string db)
        {
            string strsql;
            strsql = "delete  from dtl01pli where nplan=@nplan";
            List<SqlParameter> arParam = new List<SqlParameter>();
            arParam.Add(new SqlParameter("@nplan",num_planilla));
            SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db), CommandType.Text, strsql, arParam.ToArray());           
        }
        public static void Script_sql(string archivo_leido, string db)
        {
            
           SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db), CommandType.Text, archivo_leido);
        }
        public static void Generar_Backup(string directorio, string db)
        {
            string strSql = "SP_GENERAR_COPIA_SEGURIDAD";
            //List<SqlParameter> arParams = new List<SqlParameter>();
            //arParams.Add(new SqlParameter("@RUTA", directorio));
            //SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());


            string sqlCommand = strSql;
            string connectionString = ConexionDC.ConectarBD(db);
            //DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(sqlCommand, new SqlConnection(connectionString)))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUTA", directorio);
                /*
                 cmd.Parameters.AddWithValue("@FECHAFIN", Convert.ToDateTime(ffin_dl));
                cmd.Parameters.AddWithValue("@sucursal", sucursal_dl);
                cmd.Parameters.AddWithValue("@tienda", tienda_dl);
                cmd.Parameters.AddWithValue("@familia", familia_dl);
                cmd.Parameters.AddWithValue("@subfam", subfam_dl);
                cmd.Parameters.AddWithValue("@grupo", grupo_dl);
                 */
                cmd.CommandTimeout = 1000;
                cmd.Connection.Open();
                //DataTable table = new DataTable();
                //table.Load(cmd.ExecuteReader());
                cmd.ExecuteReader();
                //ds.Tables.Add(table);
            }
        }
    }
}
