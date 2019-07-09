using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Email
    {
        public Email()
        {

        }
        

    }

    public class EnvioEmailFE
    {
        public int Id { get; set; }
        public string Cdocu { get; set; }
        public string Ndocu { get; set; }
        public string Correo { get; set; }
        public string Nomcli { get; set; }
        public DateTime Fecha { get; set; }
        public double Totn { get; set; }
        public string Moneda { get; set; }
        public string SerieFE { get; set; }
        public string NumeroFE { get; set; }
    }
}
