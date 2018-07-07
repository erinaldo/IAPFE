using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using IAP.DL;
namespace IAP.BL
{
    public class Contabilidad
    {
        public static string importar_asientos(string anno, DataTable dt_asientos,string db)
        {
            return DL.Contabilidad.importar_asientos(anno,dt_asientos,db);
        }
    }
}
