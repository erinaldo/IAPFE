using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace IAP.DL
{
    public class Tablas_Maestras
    {
        public static DataSet Listado_Vendedores(string db)
        {
            try
            {
                DataSet ds_ = new DataSet();
                string strSql = @"  SELECT codven,nomven FROM tbl01ven";
                ds_= SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.Text, strSql);
                ds_.Tables[0].TableName = "VEN";
                return ds_;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static DataSet Listado_Familia(string db)
        {
            try
            {
                DataSet ds_ = new DataSet();
                string strSql = @"  SELECT RTRIM(codfam) codfam,RTRIM(nomfam) nomfam FROM tbl01fam ";
                ds_ = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.Text, strSql);
                ds_.Tables[0].TableName = "FAM";
                return ds_;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static DataSet Listado_SubFamilia(string familia, string db)
        {
            try
            {
                DataSet ds_sf = new DataSet();
                string strSql = @"SP_VS_LISTADO_SUBFAMILIA";
                List<SqlParameter> arParam = new List<SqlParameter>();
                arParam.Add(new SqlParameter("@FAMILIA", familia));
                ds_sf = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParam.ToArray());
                ds_sf.Tables[0].TableName = "sf";
                return ds_sf;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public static DataSet Listado_Grupos(string subfamilia,string db)
        {
            try
            {
                DataSet ds_sf = new DataSet();
                string strSql = @"sp_listadoGrupos";
                List<SqlParameter> arParam = new List<SqlParameter>();
                arParam.Add(new SqlParameter("@subfamilia", subfamilia));
                ds_sf = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParam.ToArray());
                ds_sf.Tables[0].TableName = "gp";
                return ds_sf;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }
}
