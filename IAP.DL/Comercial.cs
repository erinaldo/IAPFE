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
using System.IO;

namespace IAP.DL
{
    public class Comercial
    {
        public Comercial()
        {

        }

        public static DataSet DL_CDN(string fechai,string fechaf,string vendedor,string familia,string subfam,string db)
        {
            DataSet ds = new DataSet();
            string strSql = "SP_VS_CDN";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@FECHAI", fechai));
            arParams.Add(new SqlParameter("@FECHAF", fechaf));
            arParams.Add(new SqlParameter("@VENDEDOR",vendedor));
            arParams.Add(new SqlParameter("@FAMILIA", familia));
            arParams.Add(new SqlParameter("@SUBFAM", subfam));
            ds=SqlHelper.ExecuteDataset (ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
            return ds;
        }

        public static void RegistrarListaPrecios(listaprecio l,string db)
        {
            string strSql = "sp_RegistrarListadePrecios";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@CodLis", "01"));
            arParams.Add(new SqlParameter("@Codi",l.Codi));
            arParams.Add(new SqlParameter("@vventa",l.Valorventaingreso));
            arParams.Add(new SqlParameter("@crepus", l.Ultcostocompradolar));
            arParams.Add(new SqlParameter("@creps", l.Ultcostocomprasoles));
            arParams.Add(new SqlParameter("@codf",l.Codf));
            arParams.Add(new SqlParameter("@descr", l.Descripcion));
            arParams.Add(new SqlParameter("@mone", l.Moneda));
            arParams.Add(new SqlParameter("@marca", l.Marca));
            arParams.Add(new SqlParameter("@umed", l.Umedida));
            arParams.Add(new SqlParameter("@tcam", l.Tcventa));
            SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
        }
        public static List<listaprecio> ObtenerListadePrecios(string familia, string subfamilia, string grupo, string moneda,int costomayorcero,int stockmayorcero,string codf ,string descripcion,string db)
        {
            DataSet ds = new DataSet();
            string strSql = "sp_ObtenerListadePrecios";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@familia", familia));
            arParams.Add(new SqlParameter("@subfamilia", subfamilia));
            arParams.Add(new SqlParameter("@grupo", grupo));
            arParams.Add(new SqlParameter("@moneda", moneda));
            arParams.Add(new SqlParameter("@item", codf));
            arParams.Add(new SqlParameter("@costomayorcero", costomayorcero));
            arParams.Add(new SqlParameter("@stockmayorcero", stockmayorcero));
            arParams.Add(new SqlParameter("@Descripcion", descripcion));
            
            ds = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
            List<listaprecio> list = new List<listaprecio>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new listaprecio(

                    row["CodigoSistema"] == DBNull.Value ? string.Empty : Convert.ToString(row["CodigoSistema"]),
                    row["CodigoEmpresa"] == DBNull.Value ? string.Empty : Convert.ToString(row["CodigoEmpresa"]),
                    row["Marca"] == DBNull.Value ? string.Empty : Convert.ToString(row["Marca"]),
                    row["Descripcion"] == DBNull.Value ? string.Empty : Convert.ToString(row["Descripcion"]),
                    row["UnidadMedida"] == DBNull.Value ? string.Empty : Convert.ToString(row["UnidadMedida"]),
                    row["Stockdisponible"] == DBNull.Value ? 0 : Convert.ToDouble(row["Stockdisponible"]),
                    row["UltCostoCompraSoles"] == DBNull.Value ? 0 : Convert.ToDouble(row["UltCostoCompraSoles"]),
                    row["UltCostoCompraDolar"] == DBNull.Value ? 0 : Convert.ToDouble(row["UltCostoCompraDolar"]),
                    row["PrecioVentaSoles"] == DBNull.Value ? 0 : Convert.ToDouble(row["PrecioVentaSoles"]),
                    row["PrecioVentaDolar"] == DBNull.Value ? 0 : Convert.ToDouble(row["PrecioVentaDolar"]),
                    row["ValorVentaIngreso"] == DBNull.Value ? 0 : Convert.ToDouble(row["ValorVentaIngreso"]),
                    row["Fechavalorventa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["Fechavalorventa"]),
                    row["tcventa"] == DBNull.Value ? 0 : Convert.ToDouble(row["tcventa"]),
                    row["fechatc"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["fechatc"]),
                    row["MonedaArticulo"] == DBNull.Value ? string.Empty : Convert.ToString(row["MonedaArticulo"])
                    ));
            }
            return list;
        }

        public static List<ClaveVenta> ObtenerClaveVenta(string db)
        {
            DataSet ds = new DataSet();
            string strSql = "sp_ObtenerClaveVenta";
            ds = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql);
            List<ClaveVenta> list = new List<ClaveVenta>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new ClaveVenta(
                    Convert.ToDateTime(row["fecha"]),
                    row["clave"] == DBNull.Value ? string.Empty : Convert.ToString(row["clave"]),
                    row["flag"] == DBNull.Value ? false : Convert.ToBoolean(row["flag"])
                    ));
            }
            return list;
        }

        public static void RegistrarClaveVenta(string clave,string db)
        {
            DataSet ds = new DataSet();
            string strSql = "sp_RegistrarClaveVenta";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@clave", clave));
            SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db), CommandType.StoredProcedure, strSql, arParams.ToArray());
        }

        public static List<TipoDocumento> ObtenerTipoDocumento(string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_ObtenerTipoDocumento");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            List<TipoDocumento> ls = new List<TipoDocumento>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ls.Add(new TipoDocumento(
                    row["cdocu"] == DBNull.Value ? "" : Convert.ToString(row["cdocu"]),
                    row["nomdoc"] == DBNull.Value ? "" : Convert.ToString(row["nomdoc"])
                    ));
            }
            return ls;
        }

        public static MemoryStream ObtenerXmlDashBoard(string id_xml, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            
            DbCommand cmd = db.GetStoredProcCommand("ObtenerXmlRepositorio", id_xml);
            cmd.CommandTimeout = 10000;
            byte[] byteArray = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + db.ExecuteScalar(cmd).ToString());
            MemoryStream strm = new MemoryStream(byteArray);
            return strm;
        }



    }
}
