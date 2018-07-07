using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class ClaveVenta
    {
        public DateTime Fecha { get; set; }
        public string Clave { get; set; }
        public Boolean Activo { get; set; }

        public ClaveVenta()
        {
        }

        public ClaveVenta(DateTime fecha,string clave,Boolean activo)
        {
            Fecha = fecha;
            Clave = clave;
            Activo = activo;
        }
    }
}
