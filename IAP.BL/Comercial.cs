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

namespace IAP.BL
{
    public class Comercial
    {

        DL.Comercial Dcom = new DL.Comercial();

        public static DataSet BL_CDN(string fechai, string fechaf, string vendedor, string familia, string subfam, string db)
        {
            return DL.Comercial.DL_CDN(fechai, fechaf, vendedor, familia, subfam, db);
        }

        public static List<listaprecio> ObtenerListadePrecios(string familia, string subfamilia, string grupo, string moneda, int costomayorcero, int stockmayorcero, string codf,string descripcion, string db)
        {
            return DL.Comercial.ObtenerListadePrecios(familia, subfamilia, grupo, moneda,costomayorcero,stockmayorcero,codf, descripcion, db);
        }

        public static void RegistrarListaPrecios(List<listaprecio> l, string db)
        {
            listaprecio lista = new listaprecio();
            foreach(listaprecio ls in l)
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
    }
}
