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
using System.ComponentModel;

namespace IAP.DL
{
    public class Comercial
    {
        public Comercial()
        {

        }

        public static DataSet DL_CDN(string fechai,string fechaf,string vendedor,string familia,string subfam,string db, string usuario, string password, string servidor)
        {
            DataSet ds = new DataSet();
            string strSql = "SP_VS_CDN";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@FECHAI", fechai));
            arParams.Add(new SqlParameter("@FECHAF", fechaf));
            arParams.Add(new SqlParameter("@VENDEDOR",vendedor));
            arParams.Add(new SqlParameter("@FAMILIA", familia));
            arParams.Add(new SqlParameter("@SUBFAM", subfam));
            ds=SqlHelper.ExecuteDataset (ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.StoredProcedure, strSql, arParams.ToArray());
            return ds;
        }

        public static void RegistrarListaPrecios(listaprecio l,string db, string usuario, string password, string servidor)
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
            SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.StoredProcedure, strSql, arParams.ToArray());
        }
        public static List<listaprecio> ObtenerListadePrecios(string familia, string subfamilia, string grupo, string moneda,int costomayorcero,
            int stockmayorcero,string codf ,string descripcion,string db, string usuario, string password, string servidor)
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
            
            ds = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.StoredProcedure, strSql, arParams.ToArray());
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

        public static List<ClaveVenta> ObtenerClaveVenta(string db, string usuario, string password, string servidor)
        {
            DataSet ds = new DataSet();
            string strSql = "sp_ObtenerClaveVenta";
            ds = SqlHelper.ExecuteDataset(ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.StoredProcedure, strSql);
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

        public static void RegistrarClaveVenta(string clave,string db, string usuario, string password, string servidor)
        {
            DataSet ds = new DataSet();
            string strSql = "sp_RegistrarClaveVenta";
            List<SqlParameter> arParams = new List<SqlParameter>();
            arParams.Add(new SqlParameter("@clave", clave));
            SqlHelper.ExecuteNonQuery(ConexionDC.ConectarBD(db,usuario,password,servidor), CommandType.StoredProcedure, strSql, arParams.ToArray());
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
            string xml = db.ExecuteScalar(cmd).ToString();
            byte[] byteArray = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + xml);
            MemoryStream strm = new MemoryStream(byteArray);
            return strm;
        }

        public MemoryStream ObtenerXmlDashBoardV2(string id_xml, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);

            DbCommand cmd = db.GetStoredProcCommand("ObtenerXmlRepositorio", id_xml);
            cmd.CommandTimeout = 10000;
            byte[] byteArray = Encoding.UTF8.GetBytes("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + db.ExecuteScalar(cmd).ToString());
            MemoryStream strm = new MemoryStream(byteArray);
            return strm;
        }

        public void ObtenerCabeceraFBNCND(string cdocu,string ndocu,string dbconexion,ref Factura eFac,ref List<DetalleFactura> lstDet)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_Sel_ObtenerCabeceraDetalleFBNCND",cdocu,ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                eFac = new Factura
                {
                    Fecha = Convert.ToDateTime(row["fecha"]),
                    Cdocu = row["Cdocu"].ToString(),
                    Ndocu = row["Ndocu"].ToString(),
                    Crefe = row["Crefe"].ToString(),
                    Nrefe = row["Nrefe"].ToString(),
                    Orden = row["Orde"].ToString(),
                    Codcli = row["Codcli"].ToString(),
                    NombreCliente = row["Nomcli"].ToString(),
                    RucCliente = row["Ruccli"].ToString(),
                    DniCliente= row["Ruccli"].ToString().Replace("DNI",""),
                    Direccion = row["DirCli"].ToString(),
                    Codcdv = row["codcdv"].ToString(),
                    CondicionVenta = row["CondicionVenta"].ToString(),
                    FechaVencimiento = Convert.ToDateTime(row["fven"].ToString()),
                    Moneda = row["mone"].ToString(),
                    TipoCambio = Convert.ToDouble(row["tcam"]),
                    Tota = Convert.ToDouble(row["tota"]),
                    Toti = Convert.ToDouble(row["toti"]),
                    Totn = Convert.ToDouble(row["totn"]),
                    Codven = row["codven"].ToString(),
                    NomVen = row["nomven"].ToString(),
                    Flag = row["flag"].ToString()
                };

            }

            foreach (DataRow row in ds.Tables[1].Rows)
            {
                lstDet.Add(new DetalleFactura
                {
                    Cdocu = row["Cdocu"].ToString(),
                    Ndocu = row["Ndocu"].ToString(),
                    Item = Convert.ToInt32(row["Item"].ToString()),
                    Codi = row["codi"].ToString(),
                    Codf = row["Codf"].ToString(),
                    Marca = row["Marc"].ToString(),
                    Descrip = row["descr"].ToString(),
                    Umed = row["Umed"].ToString(),
                    Cantidad = Convert.ToDouble(row["Cant"].ToString()),
                    Preu = Convert.ToDouble(row["preu"]),
                    Tota = Convert.ToDouble(row["tota"]),
                    Totn = Convert.ToDouble(row["totn"]),
                    Mone = row["mone"].ToString()

                });
            }

        }

        public void ObtenerCabeceraGuia(string cdocu,string ndocu,string dbconexion,ref Guia eGuia,ref List<DetalleGuia> lstDet)
        {

            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_Sel_ObtenerCabeceraDetalleGUIA", cdocu, ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                eGuia = new Guia
                {
                    Fecha = Convert.ToDateTime(row["Fecha"].ToString()),
                    Cdocu = row["Cdocu"].ToString(),
                    Ndocu = row["Ndocu"].ToString(),
                    Codcli = row["Codcli"].ToString(),
                    Nomcli = row["Nomcli"].ToString(),
                    Ruccli = row["Ruccli"].ToString(),
                    CodGlo = row["codGlo"].ToString(),
                    MotivoTraslado= row["MotivoTraslado"].ToString(),
                    CodTrans= row["codtra"].ToString(),
                    Transportista= row["transporte"].ToString(),
                    TelefonoTransp= row["teltra"].ToString(),
                    DireccionTransp= row["direccionTransporte"].ToString(),
                    RucTransp= row["ructra"].ToString(),
                    TipoDocRefe= row["tipodocrefe"].ToString(),
                    Crefe = row["Crefe"].ToString(),
                    Nrefe = row["Nrefe"].ToString(),
                    Mone = row["Mone"].ToString(),
                    TipoCambio= Convert.ToDouble(row["tcam"].ToString()),
                    Tota = Convert.ToDouble(row["Tota"].ToString()),
                    Toti = Convert.ToDouble(row["Toti"].ToString()),
                    Totn = Convert.ToDouble(row["Totn"].ToString()),
                    Codven = row["Codven"].ToString(),
                    Nomven = row["vendedor"].ToString(),
                    DireccionPartida= row["direccionpartida"].ToString(),
                    DireccionEntrega= row["direccionentrega"].ToString(),
                    MarcaVehiculo= row["marveh"].ToString(),
                    PlacaVehiculo= row["plaveh"].ToString(),
                    NombreChofer= row["nomcho"].ToString(),
                    NroLicencia= row["nrolic"].ToString(),
                    Anno = row["Anno"].ToString(),
                    Mes = row["Mes"].ToString(),
                    Dia = row["Dia"].ToString(),
                    NroFactura = row["NroFactura"].ToString(),
                    DirCli= row["dircli"].ToString()
                };
            }

            foreach(DataRow row in ds.Tables[1].Rows)
            {
                lstDet.Add(new DetalleGuia
                {
                   
                    Item=Convert.ToInt32(row["Item"]),
                    Codi = row["codi"].ToString(),
                    Codf = row["Codf"].ToString(),
                    Marc = row["Marc"].ToString(),
                    Descr = row["Descr"].ToString(),
                    Umed = row["Umed"].ToString(),
                    Cant=Convert.ToDouble(row["Cant"])
                    
                });
            }
        }

        public List<ParametrosFormatos>  ObtenerParametroFormatosFB(string dbconexion)
        {
            List<ParametrosFormatos> lst = new List<ParametrosFormatos>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_ParametroFormato");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);
            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new ParametrosFormatos
                {
                    IdParametro = Convert.ToString(row["IDPARA"]),
                    Valor = Convert.ToString(row["VALOR"])
                });
               
            }
            return lst;
        }

        public List<OrdenServicio> ObtenerOrdenesServicio (DateTime fechai,DateTime fechaf,string ndocu,string nomcli, string dbconexion)
        {
            List<OrdenServicio> lst = new List<OrdenServicio>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_ORDENSERVICIO",fechai,fechaf,ndocu,nomcli,"0");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new OrdenServicio
                {
                    fecha = Convert.ToDateTime(row["fecha"]),
                    cdocu=row["cdocu"].ToString(),
                    ndocu=row["ndocu"].ToString(),
                    codcli = row["codcli"].ToString().Trim(),
                    nomcli = row["nomcli"].ToString().Trim(),
                    ruccli=row["ruccli"].ToString().Trim(),
                    tcam=Convert.ToDouble(row["tcam"]),
                    tota= Convert.ToDouble(row["tota"]),
                    toti= Convert.ToDouble(row["toti"]),
                    totn= Convert.ToDouble(row["totn"]),
                    flag=row["flag"].ToString(),
                    flagnombre=row["flagnombre"].ToString(),
                    IdPedidoAndroid= Convert.ToInt32(row["IdPedidoAndroid"]),
                    DirEnt= row["DirEnt"].ToString().Trim(),
                    CodUsuarioRegistro = row["CodUsuarioRegistro"].ToString().Trim(),
                    flag_Estadopedido= Convert.ToInt32(row["flag_Estadopedido"]),
                    EstadoPedido= row["EstadoPedido"].ToString()
                });
            }
            return lst;
        }


        public List<OrdenServicio> ObtenerOrdenesServicio_Operario(DateTime fechai, DateTime fechaf, string ndocu, string nomcli,string flag, string dbconexion)
        {
            List<OrdenServicio> lst = new List<OrdenServicio>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_ORDENSERVICIO_OPERARIOS", fechai, fechaf, ndocu, nomcli, flag);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new OrdenServicio
                {
                    fecha = Convert.ToDateTime(row["fecha"]),
                    cdocu = row["cdocu"].ToString(),
                    ndocu = row["ndocu"].ToString(),
                    codcli = row["codcli"].ToString().Trim(),
                    nomcli = row["nomcli"].ToString().Trim(),
                    ruccli = row["ruccli"].ToString().Trim(),
                    tcam = Convert.ToDouble(row["tcam"]),
                    tota = Convert.ToDouble(row["tota"]),
                    toti = Convert.ToDouble(row["toti"]),
                    totn = Convert.ToDouble(row["totn"]),
                    flag = row["flag"].ToString(),
                    flagnombre = row["flagnombre"].ToString(),
                    IdPedidoAndroid = Convert.ToInt32(row["IdPedidoAndroid"]),
                    DirEnt = row["DirEnt"].ToString().Trim(),
                    CodUsuarioRegistro = row["CodUsuarioRegistro"].ToString().Trim(),
                    flag_Estadopedido = Convert.ToInt32(row["flag_Estadopedido"]),
                    EstadoPedido = row["EstadoPedido"].ToString(),
                    Cod_Operario = Convert.ToString(row["Cod_Operario"]),
                    FechaInicioServicio= (row["FechaInicioServicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaInicioServicio"])),
                    FechaFinServicio = (row["FechaFinServicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaFinServicio"])),
                    Tiempo= row["Tiempo"].ToString().Trim()


                });
            }
            return lst;
        }

        public List<Operario> ObtenerOperarios(string dbconexion)
        {
            List<Operario> lst = new List<Operario>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_OperariosServicio");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new Operario
                {
                    Cod_Operario=Convert.ToString(row["Cod_Operario"]),
                    NombreOperario=Convert.ToString(row["NombreOperario"])

                });
            }
            return lst;
        }

        public List<TipoServicio> ObtenerTipoServicios(string dbconexion)
        {
            List<TipoServicio> lst = new List<TipoServicio>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_TipoServicio", dbconexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new TipoServicio
                {
                    Id_TipoServicio = Convert.ToInt32(row["Id_TipoServicio"]),
                    NombreServicio = Convert.ToString(row["NombreServicio"])

                });
            }
            return lst;
        }


        public List<OrdenServicioLinea> ObtenerOrdenServicioLinea(string ndocu,string dbconexion)
        {
            List<OrdenServicioLinea> lst = new List<OrdenServicioLinea>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_ORDENSERVICIOLINEA",ndocu);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new OrdenServicioLinea
                {
                    
                    codf = row["codf"].ToString(),
                    codi = row["codi"].ToString(),
                    descr = row["descr"].ToString().Trim(),
                    marc = row["marc"].ToString().Trim(),
                    umed = row["umed"].ToString().Trim(),
                    cant = Convert.ToDouble(row["cant"]),
                    preu = Convert.ToDouble(row["preu"]),
                    tota = Convert.ToDouble(row["tota"]),
                    totn = Convert.ToDouble(row["totn"]),
                    Cod_Operario = Convert.ToString(row["CodOte"]),
                    FechaInicioServicio = (row["FechaInicioServicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaInicioServicio"])),
                    FechaFinServicio = (row["FechaFinServicio"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FechaFinServicio"])),
                    ndocu= row["ndocu"].ToString(),
                    item = row["item"].ToString(),
                    tiposervicio= row["tiposervicio"].ToString().Trim()

                });
            }
            return lst;
        }



        public List<Cliente> ObtenerClientesOS(string dbconexion)
        {
            List<Cliente> lst = new List<Cliente>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_CLIENTES_OS");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new Cliente
                {
                    CodCli = Convert.ToString(row["codcli"]),
                    Nombre = Convert.ToString(row["nomcli"]),
                    Ruc= Convert.ToString(row["ruccli"])
                });

            }
            return lst;
        }

        public void ActualizarClienteOS(List<OrdenServicio> lst,string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            foreach (OrdenServicio o in lst)
            {
                db.ExecuteNonQuery("USP_UPD_ASIGNAR_CLIENTE_ORDENSERVICIO",o.codcli,o.ndocu);
            }
        }

        public void RegistrarClienteSunat(string ruc,string nombrecliente,DateTime fechainicio,string estado,string condicion,string direccion, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("USP_INS_CLIENTESUNAT",ruc,nombrecliente,fechainicio,estado,condicion,direccion);
            
        }


        public List<OrdenServicio> ObtenerArqueo_OS(DateTime fechainicial,DateTime fechafinal,string codcdv, string dbconexion)
        {
            List<OrdenServicio> lst = new List<OrdenServicio>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_OS_ARQUEO", fechainicial, fechafinal, codcdv);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new OrdenServicio
                {
                    fecha = Convert.ToDateTime(row["fecha"]==DBNull.Value ? (DateTime?)null : row["fecha"]),
                    cdocu = Convert.ToString(row["cdocu"]),
                    ndocu = Convert.ToString(row["ndocu"]),
                    nomcli = Convert.ToString(row["nomcli"]),
                    ruccli= Convert.ToString(row["ruccli"]),
                    codcdv= Convert.ToString(row["codcdv"]),
                    nomcodcdv= Convert.ToString(row["nombrecondicionventa"]),
                    mone = Convert.ToString(row["mone"]),
                    tcam=Convert.ToDouble(row["tcam"]),
                    tota = Convert.ToDouble(row["tota"]),
                    toti = Convert.ToDouble(row["toti"]),
                    totn = Convert.ToDouble(row["totn"]),
                    flag_arqueado=Convert.ToBoolean(row["flg_arqueado"]),
                    fechaarqueo = (row["fechaarqueo"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["fechaarqueo"])),
                    usuarioArqueo= Convert.ToString(row["usuarioArqueo"]),
                    saldo= Convert.ToDouble(row["saldo"]),
                    flag_cancelado = Convert.ToBoolean(row["flag_cancelado"])

                });

            }
            return lst;
        }

        public DataSet ObtenerOSPendientes(string codcli, string dbconexion)
        {
            List<OrdenServicio> lst = new List<OrdenServicio>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_OS_PENDIENTES", codcli);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            
            return ds;
        }

        public void RegistrarArqueo_OS(DateTime fecha,bool estadoarqueo,string usuarioPC,string codcdv,double totals,double totald,string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("USP_UDP_GUARDAR_ARQUEO_OS", fecha, estadoarqueo, usuarioPC, codcdv, totals, totald);
        }

        public void RegistrarAbono_OS(string cdocu,string ndocu,double monto,string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            db.ExecuteNonQuery("USP_UDP_GUARDAR_CANCELACION_OS", cdocu,ndocu,monto);
            //USP_UDP_GUARDAR_CANCELACION_OS
        }




        /* METODOS PARA CONEXION A HOSTING ANDROID */

        public List<OrdenServicio> RegistrarOrdenesServicioDescargadosAndroid_ERP(List<OrdenServicioDocumento> lst_OSDocumento ,string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexionAndroid);
            DbCommand cmd,cmd3,cmd4;
            List<OrdenServicio> lst = new List<OrdenServicio>();
            foreach (OrdenServicioDocumento doc in lst_OSDocumento)
            {
                try
                {
                    
                    db = DatabaseFactory.CreateDatabase(dbconexion);
                    cmd = db.GetStoredProcCommand("USP_INS_RegistrarOS_Android_ERP", doc.Cabecera.fecha, doc.Cabecera.codcli, doc.Cabecera.nomcli, doc.Cabecera.ruccli, doc.Cabecera.codcdv, doc.Cabecera.tcam, doc.Cabecera.tota,
                        doc.Cabecera.toti, doc.Cabecera.totn, doc.Cabecera.IdPedidoAndroid, doc.Cabecera.DirEnt, doc.Cabecera.CodUsuarioRegistro);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;

                    doc.Cabecera.ndocu = db.ExecuteScalar(cmd).ToString();

                    foreach (OrdenServicioLinea eLinea in doc.Detalle)
                    {
                        db = DatabaseFactory.CreateDatabase(dbconexion);
                        cmd3 = db.GetStoredProcCommand("USP_INS_RegistrarOS_Linea_Android_ERP", doc.Cabecera.ndocu, eLinea.codf, eLinea.codi, eLinea.cant, eLinea.preu, eLinea.tota, eLinea.totn);
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.CommandTimeout = 0;
                        db.ExecuteNonQuery(cmd3);
                    }
                    
                    lst.Add(new OrdenServicio
                    {
                        IdPedidoAndroid=doc.Cabecera.IdPedidoAndroid,
                        flag="1",
                        ndocu= doc.Cabecera.ndocu
                    });
                }
                catch(Exception ex)
                {
                    lst.Add(new OrdenServicio
                    {
                        IdPedidoAndroid = doc.Cabecera.IdPedidoAndroid,
                        flag = "0"
                    });
                    //USP_Del_EliminarOS_Android_ERP
                    db = DatabaseFactory.CreateDatabase(dbconexion);
                    cmd4 = db.GetStoredProcCommand("USP_Del_EliminarOS_Android_ERP", doc.Cabecera.ndocu);
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.CommandTimeout = 0;
                    db.ExecuteNonQuery(cmd4);
                }

            }
            return lst;
        }

        public void RegistrarFLagPedidosAndroid(List<OrdenServicio> lstOS, string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexionAndroid);
            DbCommand cmd;

            foreach(OrdenServicio eCab in lstOS)
            {
                try
                {
                    cmd = db.GetStoredProcCommand("usp_udp_ActualizarFlagPedidos", eCab.IdPedidoAndroid, eCab.flag, "");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    db.ExecuteNonQuery(cmd);
                   
                }
                catch(Exception ex)
                {

                }
                
            }
            
        }

        public void ActualizarFLagPedidosAndroid(Int32 IdPedido,string ruc, string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexionAndroid);
            DbCommand cmd;
            
            cmd = db.GetStoredProcCommand("usp_udp_ActualizarFlagEstadosPedido",IdPedido,ruc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }
        public void ActualizarFLagPedidosAndroidManual(Int32 IdPedido, string ruc,Int32 flag_estado, string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexionAndroid);
            DbCommand cmd;

            cmd = db.GetStoredProcCommand("usp_udp_ActualizarFlagEstadosPedidoManual", IdPedido, flag_estado, ruc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }

        public void ActualizarFLagPedidos(Int32 IdPedido, string ruc, string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;

            cmd = db.GetStoredProcCommand("usp_udp_ActualizarFlagEstadosPedido", IdPedido, ruc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }
        public void ActualizarFLagPedidosManual(Int32 IdPedido, string ruc, Int32 flag_estado, string dbconexion, string dbconexionAndroid)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;

            cmd = db.GetStoredProcCommand("usp_udp_ActualizarFlagEstadosPedidoManual", IdPedido, flag_estado, ruc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }

        public List<OrdenServicioDocumento> DescargarPedidosAndroid(DateTime fechai, DateTime fechaf,string ruc, string dbconexion,string dbconexionAndroid)
        {
            List<OrdenServicioDocumento> lst_OSDocumento = new List<OrdenServicioDocumento>();
            //List<OrdenServicio> lstOS_Cab = new List<OrdenServicio>();
            OrdenServicio eCab = new OrdenServicio();
            List<OrdenServicioLinea> lstOS_Det = new List<OrdenServicioLinea>();
            Database db = DatabaseFactory.CreateDatabase(dbconexionAndroid);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_sel_ObtenerPedidosSincronizacion", fechai, fechaf,ruc);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                eCab=(new OrdenServicio
                {
                    IdPedidoAndroid = Convert.ToInt32(row["IdPedido"]),
                    fecha = Convert.ToDateTime(row["fecha"]),
                    codcli = row["codcli"].ToString().Trim(),
                    nomcli = row["nomcli"].ToString().Trim(),
                    ruccli = row["ruccli"].ToString().Trim(),
                    flag = row["flag"].ToString(),
                    DirEnt = row["DirEnt"].ToString().Trim(),
                    mone= row["mone"].ToString().Trim(),
                    tcam = Convert.ToDouble(row["tcam"]),
                    tota = Convert.ToDouble(row["tota"]),
                    toti = Convert.ToDouble(row["toti"]),
                    totn = Convert.ToDouble(row["totn"]),
                    CodUsuarioRegistro = row["CodUsuarioRegistro"].ToString().Trim(),
                    codcdv= row["codcdv"].ToString(),
                    flag_Estadopedido = Convert.ToInt32(row["flag_Estadopedido"])
                    
                });
                /*
                
                */

                lstOS_Det = new List<OrdenServicioLinea>();
                lstOS_Det = DescargarPedidosLineaAndroid(Convert.ToInt32(row["IdPedido"]), dbconexionAndroid);

                lst_OSDocumento.Add(new OrdenServicioDocumento
                {
                    Cabecera = eCab,
                    Detalle = lstOS_Det
                });
               

            }

            return lst_OSDocumento;
           
        }

        public List<OrdenServicioLinea> DescargarPedidosLineaAndroid(Int32 IdPedidoAndroid, string dbconexion)
        {
            List<OrdenServicioLinea> lst = new List<OrdenServicioLinea>();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_sel_ObtenerPedidosLineaSincronizacion", IdPedidoAndroid);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new OrdenServicioLinea
                {
                    IdPedidoLinea = Convert.ToInt32(row["IdPedidoLinea"]),
                    IdPedido = Convert.ToInt32(row["IdPedido"]),

                    codf = row["codf"].ToString().Trim(),
                    codi = row["codi"].ToString().Trim(),
                    descr = row["descr"].ToString().Trim(),
                    marc = row["marc"].ToString(),
                    umed = row["umed"].ToString().Trim(),

                    cant = Convert.ToDouble(row["cant"]),
                    preu = Convert.ToDouble(row["preu"]),
                    tota = Convert.ToDouble(row["tota"]),
                    totn = Convert.ToDouble(row["totn"])

                });
            }
            return lst;
        }

        public void Actualizar_Operarios_OS(BindingList<OrdenServicioLinea> lstdetalle, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;

            foreach (OrdenServicioLinea l in lstdetalle)
            {
                cmd = db.GetStoredProcCommand("usp_udp_Actualizar_Operarios_OS", l.ndocu, Convert.ToInt32(l.item),l.Cod_Operario.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                db.ExecuteNonQuery(cmd);
            }
                
        }

        public void Actualizar_Fechas_proceso_OS(string ndocu, Int32 item,string cod_operario, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;

            cmd = db.GetStoredProcCommand("usp_udp_Actualizar_Fechas_Proceso_OS", ndocu, item,cod_operario);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }

        public void Registrar_PlantillaParametros_OS(OrdenServicioPlantillaParametros plantilla, string dbconexion)
        {
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;

            cmd = db.GetStoredProcCommand("usp_ins_Parametros_PlantillasOrdenServicio", plantilla.ndocu, plantilla.cod_operario, plantilla.codi, Convert.ToInt32(plantilla.item),
                plantilla.p1,
                plantilla.p2,
                plantilla.p3,
                plantilla.p4,
                plantilla.p5,
                plantilla.p6,
                plantilla.p7,
                plantilla.p8,
                plantilla.p9,
                plantilla.p10,
                plantilla.p11,
                plantilla.p12,
                plantilla.p13,
                plantilla.p14,
                plantilla.p15,
                plantilla.p16,
                plantilla.p17,
                plantilla.p18,
                plantilla.p19,
                plantilla.p20
                );
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            db.ExecuteNonQuery(cmd);
        }

        public OrdenServicioPlantillaParametros Obtener_PlantillaParametros_OS(string ndocu,string cod_operario,string codi,int item, string dbconexion)
        {
            OrdenServicioPlantillaParametros lst = new OrdenServicioPlantillaParametros();
            Database db = DatabaseFactory.CreateDatabase(dbconexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("usp_sel_ParametrosPlantillaOrdenServicio", ndocu,cod_operario,codi,item);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst=(new OrdenServicioPlantillaParametros
                {
                    ndocu = row["ndocu"].ToString().Trim(),
                    cod_operario = row["cod_operario"].ToString().Trim(),
                    codi = row["codi"].ToString().Trim(),
                    item = row["item"].ToString().Trim(),
                    p1 = (row["p1"]==DBNull.Value ? "" : row["p1"].ToString()),
                    p2 = Convert.ToDouble(row["p2"]),
                    p3 = Convert.ToDouble(row["p3"]),
                    p4 = Convert.ToDouble(row["p4"]),
                    p5 = Convert.ToDouble(row["p5"]),
                    p6 = Convert.ToDouble(row["p6"]),
                    p7 = Convert.ToDouble(row["p7"]),
                    p8 = Convert.ToDouble(row["p8"]),
                    p9 = Convert.ToDouble(row["p9"]),
                    p10 = Convert.ToDouble(row["p10"]),
                    p11 = Convert.ToDouble(row["p11"]),
                    p12 = Convert.ToDouble(row["p12"]),
                    p13 = Convert.ToDouble(row["p13"]),
                    p14 = Convert.ToDouble(row["p14"]),
                    p15 = Convert.ToDouble(row["p15"]),
                    p16 = Convert.ToDouble(row["p16"]),
                    p17 = Convert.ToDouble(row["p17"]),
                    p18 = Convert.ToDouble(row["p18"]),
                    p19 = Convert.ToDouble(row["p19"]),
                    p20 = Convert.ToDouble(row["p20"])
                });
            }
            return lst;
        }



    }
}
