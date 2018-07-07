using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAP.DL;
using System.Data;
namespace IAP.BL
{
    public class Tablas_Maestras
    {
        public static DataSet Vendedores (string db)
        {
            return DL.Tablas_Maestras.Listado_Vendedores(db);
        }
        public static DataSet Familias(string db)
        {
            return DL.Tablas_Maestras.Listado_Familia(db);
        }
        public static DataSet SubFamilias(string familias, string db)
        {
            return DL.Tablas_Maestras.Listado_SubFamilia(familias, db);
        }
        public static DataSet Listado_Grupos(string subfamilia, string db)
        {
            return DL.Tablas_Maestras.Listado_Grupos(subfamilia, db);
        }
    }
}
