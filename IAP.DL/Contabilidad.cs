using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IAP.DL
{
    public class Contabilidad
    {

        public static string importar_asientos(string anno,DataTable dt_asientos,string db, string usuario, string password, string servidor)
        {
            string compro=string.Empty;
            string co_origen, co_mes;
            DataRow dr= dt_asientos.Rows[1];

            co_origen = dr[4].ToString();
            co_mes = dr[1].ToString();
            compro = ultimo_comprobante(co_origen, co_mes, anno, db,usuario,password,servidor);
            //try
            //{
            //    insertar_asiento(anno, compro, dt_asientos, db);
            //}
            //catch (Exception ex)
            //{
                
            //}
            return insertar_asiento(anno, compro, dt_asientos, db,usuario,password,servidor);

        }
        private static string ultimo_comprobante(string origen, string mes_as, string anno, string db, string usuario, string password, string servidor)
        {
            //select @compro=right('000000'+ltrim(rtrim(convert(char(6),max(compro)+1))),6) from cgm01022012 where origen=@origen and mes_as=@mes
            string SQL = "select ISNULL(right('000000'+ltrim(rtrim(convert(char(6),max(compro)+1))),6),'000001') as compro from cgm0102" + anno + " where origen=@origen and mes_as=@mes";
            string resultado;
            List<SqlParameter> arparametros= new List<SqlParameter>();
            arparametros.Add(new SqlParameter("@origen", origen));
            arparametros.Add(new SqlParameter("@mes", mes_as));
            resultado = SqlHelper.ExecuteScalar(ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.Text, SQL,arparametros.ToArray()).ToString();
            return resultado;
        }
        private static string insertar_asiento(string anno,string compro,DataTable dt,string db, string usuario, string password, string servidor)
        {
            string estado;
            int numero_fila = 0;
            SqlConnection conn = null;
            SqlTransaction trx = null;
            try
            {

             // conn = new SqlConnection(ConexionDC.CadenaConexion_tran);
              conn = new SqlConnection(ConexionDC.ConectarBD(db,usuario,password,servidor));
              conn.Open();
              trx = conn.BeginTransaction();

            //String resultado=string.Empty;
                foreach(DataRow dr in dt.Rows)
                {
                    numero_fila=numero_fila+1;
                    string SQL_INSERTAR = "INSERT INTO  cgm0102" + anno + " (ano_as,mes_as,dia_as,compro,origen,cuenta,ccosto,coddoc,nrodoc,docref,nroref,idrefe,nomref,rucref,glosa," +
	                   "tmovim,debe,haber,debed,haberd,moneda,tipcam,idcompro,fvenci,detimp,dettas,detfec,fechao,codsub,codscc, montus,flucaj,codpos) " +
                       "VALUES (ltrim(rtrim(@ano_as)),ltrim(rtrim(@mes_as)),ltrim(rtrim(@dia_as)),ltrim(rtrim(@compro)),ltrim(rtrim(@origen)),ltrim(rtrim(@cuenta)),ltrim(rtrim(@ccosto)),ltrim(rtrim(@coddoc))," +
                       "ltrim(rtrim(@nrodoc)),ltrim(rtrim(@docref)),SUBSTRING(ltrim(rtrim(@nroref)),1,12),ltrim(rtrim(@idrefe)),substring(ltrim(rtrim(@nomref)),1,40),ltrim(rtrim(@rucref)),substring(@glosa,1,40),ltrim(rtrim(@tmov))," + 
                   
                       "convert(decimal(15,2),@debe),convert(decimal(15,2),@haber),convert(decimal(15,2),@debed),convert(decimal(15,2),@haberd),ltrim(rtrim(@moneda)),ltrim(rtrim(@tipcam)),convert(int,@idcompro)," +
                       "getdate(),0.00,0.00,'01-01-1900',getdate(),'00',ltrim(rtrim(@codscc)),0.00,'',ltrim(rtrim(@codpos)))";
                    List<SqlParameter> parametros = new List<SqlParameter>();
                    parametros.Add(new SqlParameter("@ano_as", dr[0].ToString().Trim()));
                    parametros.Add(new SqlParameter("@mes_as", dr[1].ToString().Trim()));
                    parametros.Add(new SqlParameter("@dia_as", dr[2].ToString().Trim()));
                    parametros.Add(new SqlParameter("@compro", compro.Trim())); //dr[3].ToString()));
                    parametros.Add(new SqlParameter("@origen", dr[4].ToString().Trim()));
                    parametros.Add(new SqlParameter("@cuenta", dr[5].ToString().Trim()));
                    parametros.Add(new SqlParameter("@coddoc", dr[6].ToString().Trim()));
                    parametros.Add(new SqlParameter("@nrodoc", dr[7].ToString().Trim()));
                    parametros.Add(new SqlParameter("@docref", dr[8].ToString().Trim()));
                    parametros.Add(new SqlParameter("@nroref", dr[9].ToString().Trim()));
                    parametros.Add(new SqlParameter("@idrefe", dr[10].ToString().Trim()));
                    parametros.Add(new SqlParameter("@nomref", dr[11].ToString().Trim()));
                    parametros.Add(new SqlParameter("@rucref", dr[12].ToString().Trim()));
                    parametros.Add(new SqlParameter("@glosa", dr[13].ToString().Trim()));
                    parametros.Add(new SqlParameter("@tmov", dr[14].ToString().Trim()));
                    parametros.Add(new SqlParameter("@debe", Convert.ToDouble(dr[15].ToString().Trim())));
                    parametros.Add(new SqlParameter("@haber", Convert.ToDouble(dr[16].ToString().Trim())));
                    parametros.Add(new SqlParameter("@debed", Convert.ToDouble(dr[17].ToString().Trim())));
                    parametros.Add(new SqlParameter("@haberd", Convert.ToDouble(dr[18].ToString().Trim())));
                    parametros.Add(new SqlParameter("@moneda", dr[19].ToString().Trim()));
                    parametros.Add(new SqlParameter("@tipcam", dr[20].ToString().Trim()));
                    parametros.Add(new SqlParameter("@idcompro", Convert.ToInt32(dr[21].ToString().Trim())));
                    parametros.Add(new SqlParameter("@codscc", dr[22].ToString().Trim()));
                    parametros.Add(new SqlParameter("@ccosto", dr[23].ToString().Trim()));
                    parametros.Add(new SqlParameter("@codpos", dr[24].ToString().Trim()));

                    //resultado=
                    //SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db), CommandType.Text, SQL_INSERTAR, parametros.ToArray()).ToString();
                    SqlHelper.ExecuteNonQuery(trx, CommandType.Text, SQL_INSERTAR, parametros.ToArray()).ToString();
                
                }
                trx.Commit();
                estado = "1";

            }
            catch( Exception ex )
            {
               if ( trx != null )
               trx.Rollback();
               estado = ex.Message+ " ::Verificar la Fila::"+ Convert.ToString(numero_fila);
               
            }
            finally
            {
               if ( conn != null )
               conn.Close();
            }

            return estado;
        }

    }
}
