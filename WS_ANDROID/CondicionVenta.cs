using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class CondicionVenta
    {
        public String Codcdv { get; set; }
        public String Nomcdv { get; set; }

        public CondicionVenta() { }

        public CondicionVenta(string codcdv,string nomcdv)
        {
            this.Codcdv = codcdv;
            this.Nomcdv = nomcdv;
        }
    }
}
