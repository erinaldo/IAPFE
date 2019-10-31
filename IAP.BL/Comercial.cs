using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Transactions;
using IAP.BE;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using IAP.DL;
using System.ComponentModel;

namespace IAP.BL
{
    public class Comercial
    {

        DL.Comercial Dcom = new DL.Comercial();

        public static DataSet BL_CDN(string fechai, string fechaf, string vendedor, string familia, string subfam, string db, string usuario, string password, string servidor)
        {
            return DL.Comercial.DL_CDN(fechai, fechaf, vendedor, familia, subfam, db,usuario,password,servidor);
        }

        public static List<listaprecio> ObtenerListadePrecios(string familia, string subfamilia, string grupo, string moneda, int costomayorcero, 
            int stockmayorcero, string codf, string descripcion, string db, string usuario, string password, string servidor)
        {
            return DL.Comercial.ObtenerListadePrecios(familia, subfamilia, grupo, moneda, costomayorcero,
                stockmayorcero, codf, descripcion, db,usuario,password,servidor);
        }

        public static void RegistrarListaPrecios(List<listaprecio> l, string db, string usuario, string password, string servidor)
        {
            listaprecio lista = new listaprecio();
            foreach (listaprecio ls in l)
            {
                lista = new listaprecio();
                lista = ls;
                DL.Comercial.RegistrarListaPrecios(lista, db,usuario,password,servidor);
            }
        }

        public static List<ClaveVenta> ObtenerClaveVenta(string db, string usuario, string password, string servidor)
        {
            return DL.Comercial.ObtenerClaveVenta(db,usuario,password,servidor);
        }

        public static void RegistrarClaveVenta(string clave, string db, string usuario, string password, string servidor)
        {
            DL.Comercial.RegistrarClaveVenta(clave, db,usuario,password,servidor);
        }

        public static List<TipoDocumento> ObtenerTipoDocumento(string dbconexion)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                return DL.Comercial.ObtenerTipoDocumento(dbconexion);
                ts.Complete();
            }
        }


        public static MemoryStream ObtenerXmlDashBoard(string id_xml, string dbconexion)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                //DProcProduccion dProcProduccion = new DProcProduccion();
                return DL.Comercial.ObtenerXmlDashBoard(id_xml, dbconexion);
            }
        }
        //ObtenerXmlDashBoardV2
        public MemoryStream ObtenerXmlDashBoardV2(string id_xml, string dbconexion)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                //DProcProduccion dProcProduccion = new DProcProduccion();
                return DL.Comercial.ObtenerXmlDashBoard(id_xml, dbconexion);
            }
        }

        public void ObtenerCabeceraFBNCND(string cdocu, string ndocu, string dbconexion, ref Factura eFac, ref List<DetalleFactura> lstDet)
        {
            DL.Comercial eCom = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                eCom.ObtenerCabeceraFBNCND(cdocu, ndocu, dbconexion, ref eFac, ref lstDet);
            }
        }

        public void ObtenerCabeceraGuia(string cdocu, string ndocu, string dbconexion, ref Guia eGuia, ref List<DetalleGuia> lstDet)
        {
            DL.Comercial eCom = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                eCom.ObtenerCabeceraGuia(cdocu, ndocu, dbconexion, ref eGuia, ref lstDet);
            }
        }

        public List<ParametrosFormatos> ObtenerParametroFormatosFB(string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerParametroFormatosFB(dbconexion);
        }


        public List<OrdenServicio> ObtenerOrdenesServicio_Operario(DateTime fechai, DateTime fechaf, string ndocu, string nomcli,string flag, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOrdenesServicio_Operario(fechai, fechaf, ndocu, nomcli,flag, dbconexion);
        }

        public List<Operario> ObtenerOperarios(string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOperarios(dbconexion);
        }
        public List<TipoServicio> ObtenerTipoServicios(string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerTipoServicios(dbconexion);
        }


        public List<OrdenServicio> ObtenerOrdenesServicio(DateTime fechai, DateTime fechaf, string ndocu, string nomcli, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOrdenesServicio(fechai, fechaf, ndocu, nomcli, dbconexion);
        }

        public List<OrdenServicioLinea> ObtenerOrdenServicioLinea(string ndocu, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOrdenServicioLinea(ndocu, dbconexion);
        }

        public List<Cliente> ObtenerClientesOS(string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerClientesOS(dbconexion);
        }

        public void ActualizarClienteOS(List<OrdenServicio> lst, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.ActualizarClienteOS(lst, dbconexion);
                ts.Complete();
            }
        }
        public void RegistrarClienteSunat(string ruc, string nombrecliente, DateTime fechainicio, string estado, string condicion, string direccion, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.RegistrarClienteSunat(ruc, nombrecliente, fechainicio, estado, condicion, direccion, dbconexion);
                ts.Complete();
            }
        }
        public List<OrdenServicio> ObtenerArqueo_OS(DateTime fechaInicial,DateTime fechaFinal, string codcdv, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerArqueo_OS(fechaInicial,fechaFinal, codcdv, dbconexion);
        }

        public DataSet ObtenerOSPendientes(string codcli, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOSPendientes(codcli, dbconexion);
        }

        public void RegistrarArqueo_OS(DateTime fecha, bool estadoarqueo, string usuarioPC, string codcdv, double totals, double totald, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.RegistrarArqueo_OS(fecha, estadoarqueo, usuarioPC, codcdv, totals, totald, dbconexion);
                ts.Complete();
            }
        }

        public void RegistrarAbono_OS(string cdocu, string ndocu, double monto, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.RegistrarAbono_OS(cdocu,ndocu,monto, dbconexion);
                ts.Complete();
            }
        }

        public void Actualizar_FlagEstadoPedidos(Int32 IdPedido,string ruc, string dbconexion, string dbconexionAndroid)
        {
            DL.Comercial cls = new DL.Comercial();
           
            

            try
            {
                using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    cls.ActualizarFLagPedidosAndroid(IdPedido, ruc, dbconexion, dbconexionAndroid);
                    ts.Complete();
                }

                using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    cls.ActualizarFLagPedidos(IdPedido, ruc, dbconexion, dbconexionAndroid);
                    ts.Complete();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Actualizar_FlagEstadoPedidosManual(Int32 IdPedido, string ruc,Int32 flag_Estado, string dbconexion, string dbconexionAndroid)
        {
            DL.Comercial cls = new DL.Comercial();



            try
            {
                using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    cls.ActualizarFLagPedidosAndroidManual(IdPedido, ruc, flag_Estado, dbconexion, dbconexionAndroid);
                    ts.Complete();
                }

                using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    cls.ActualizarFLagPedidosManual(IdPedido, ruc, flag_Estado, dbconexion, dbconexionAndroid);
                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DescargarRegistrarPedidosAndroid(DateTime fechai, DateTime fechaf,string ruc, string dbconexion, string dbconexionAndroid)
        {
            DL.Comercial cls = new DL.Comercial();
            List<OrdenServicioDocumento> lstOSDoc = new List<OrdenServicioDocumento>();
            List<OrdenServicio> lstOS = new List<OrdenServicio>();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                lstOSDoc=cls.DescargarPedidosAndroid(fechai, fechaf,ruc, dbconexion, dbconexionAndroid);
                ts.Complete();
            }

            try
            {
                using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
                {
                    lstOS = cls.RegistrarOrdenesServicioDescargadosAndroid_ERP(lstOSDoc, dbconexion, dbconexionAndroid);
                    ts.Complete();
                }
            }
            catch
            {

            }
            
            
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.RegistrarFLagPedidosAndroid(lstOS, dbconexion, dbconexionAndroid);
                ts.Complete();
            }

        }

        public void Actualizar_Operarios_OS(BindingList<OrdenServicioLinea> lstdetalle, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                
                cls.Actualizar_Operarios_OS(lstdetalle, dbconexion);
                ts.Complete();
            }
        }

        public void Actualizar_Fechas_proceso_OS(string ndocu, Int32 item, string cod_operario, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                cls.Actualizar_Fechas_proceso_OS(ndocu, item, cod_operario, dbconexion);
                ts.Complete();
            }
        }

        public void Registrar_PlantillaParametros_OS(OrdenServicioPlantillaParametros plantilla, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                cls.Registrar_PlantillaParametros_OS(plantilla, dbconexion);
                ts.Complete();
            }
        }

        public OrdenServicioPlantillaParametros Obtener_PlantillaParametros_OS(string ndocu, string cod_operario, string codi, int item, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.Obtener_PlantillaParametros_OS(ndocu,cod_operario,codi,item, dbconexion);
        }

    }
}
