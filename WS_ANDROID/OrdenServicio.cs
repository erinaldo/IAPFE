using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class OrdenServicio
    {
        public DateTime fecha { get; set; }
        public string cdocu { get; set; }
        public string ndocu { get; set; }
        public string codcli { get; set; }
        public string nomcli { get; set; }
        public string ruccli { get; set; }
        public double tcam { get; set; }
        public double tota { get; set; }
        public double toti { get; set; }
        public double totn { get; set; }
        public string flag { get; set; }
        public string flagnombre { get; set; }
        public bool FlgCheck { get; set; }
    }
}
