using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Producto
    {
        public String Codi { get; set; }
        public String Codf { get; set; }
        public String Marc { get; set; }
        public String Descr { get; set; }
        public String Umed { get; set; }

        public Producto() { }

        public Producto(string codi,string codf,string marc,string descr,string umed)
        {
            this.Codi = codi;
            this.Codf = codf;
            this.Marc = marc;
            this.Descr = descr;
            this.Umed = umed;
        }
    }
}
