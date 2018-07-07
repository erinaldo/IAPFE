using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class listaprecio
    {
        public string Codi { get; set; }
        public string Codf { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Umedida { get; set; }
        public double Stockdisponible { get; set; }
        public double Ultcostocomprasoles { get; set; }
        public double Ultcostocompradolar { get; set; }
        public double Precioventasoles { get; set; }
        public double Precioventadolar { get; set; }
        public double Valorventaingreso { get; set; }
        public DateTime? Fechavalorventa { get; set; }
        public double Tcventa { get; set; }
        public DateTime? Fechatc { get; set; }

        public string Moneda { get; set; }

        public bool FlgCheck { get; set; }

        public listaprecio()
        {
        }

        public listaprecio(string codi, string codf, string marca, string descripcion, string umedida, double stockdisponible, double ultcostocomprasoles, 
            double ultcostocompradolar,double precioventasoles,double precioventadolar, 
            double valorventaingreso, DateTime? fechavalorventa,double tcventa,DateTime? fechatc,string moneda)
        {
            this.Codi = codi;
            this.Codf = codf;
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.Umedida = umedida;
            this.Stockdisponible = stockdisponible;
            this.Ultcostocomprasoles = ultcostocomprasoles;
            this.Ultcostocompradolar = ultcostocompradolar;
            this.Precioventasoles = precioventasoles;
            this.Precioventadolar = precioventadolar;
            this.Valorventaingreso = valorventaingreso;
            this.Fechavalorventa = fechavalorventa;
            this.Tcventa = tcventa;
            this.Fechatc = fechatc;
            this.Moneda = moneda;
        }
    }
}
