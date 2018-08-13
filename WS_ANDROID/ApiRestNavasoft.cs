using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class ApiRestNavasoft
    {
    }
    public class GetMst01Fac
    {
        public string cdocu { get; set; }
        public DateTime fechai { get; set; }
        public DateTime fechaf { get; set; }
        public string cliente { get; set; }
        public string documento { get; set; }
        public int enviadosunat { get; set; } 
        public int anulado { get; set; }
    }
}
