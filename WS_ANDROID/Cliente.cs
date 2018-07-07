using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Cliente
    {
        public string Ruc { get; set; }
        public string Nombre { get; set; }


        public Cliente() { }

        public Cliente(string ruc,string nombre)
        {
            this.Ruc = ruc;
            this.Nombre = nombre;
        }
    }
}
