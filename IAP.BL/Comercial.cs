﻿using System;
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

namespace IAP.BL
{
    public class Comercial
    {

        DL.Comercial Dcom = new DL.Comercial();

        public static DataSet BL_CDN(string fechai, string fechaf, string vendedor, string familia, string subfam, string db)
        {
            return DL.Comercial.DL_CDN(fechai, fechaf, vendedor, familia, subfam, db);
        }

        public static List<listaprecio> ObtenerListadePrecios(string familia, string subfamilia, string grupo, string moneda, int costomayorcero, int stockmayorcero, string codf, string descripcion, string db)
        {
            return DL.Comercial.ObtenerListadePrecios(familia, subfamilia, grupo, moneda, costomayorcero, stockmayorcero, codf, descripcion, db);
        }

        public static void RegistrarListaPrecios(List<listaprecio> l, string db)
        {
            listaprecio lista = new listaprecio();
            foreach (listaprecio ls in l)
            {
                lista = new listaprecio();
                lista = ls;
                DL.Comercial.RegistrarListaPrecios(lista, db);
            }
        }

        public static List<ClaveVenta> ObtenerClaveVenta(string db)
        {
            return DL.Comercial.ObtenerClaveVenta(db);
        }

        public static void RegistrarClaveVenta(string clave, string db)
        {
            DL.Comercial.RegistrarClaveVenta(clave, db);
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

        public List<OrdenServicio> ObtenerOrdenesServicio(DateTime fechai, DateTime fechaf, string ndocu, string nomcli, string dbconexion)
        {
            DL.Comercial cls = new DL.Comercial();
            return cls.ObtenerOrdenesServicio(fechai, fechaf, ndocu, nomcli, dbconexion);
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
    }
}
