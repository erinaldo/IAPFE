using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Factura
    {
        public DateTime Fecha { get; set; }
        public string Cdocu { get; set; }
        public string Ndocu { get; set; }
        public string Crefe { get; set; }
        public string Nrefe { get; set;}
        public string Orden { get; set; }
        public string Codcli { get; set; }
        public string NombreCliente { get; set; }
        public string DniCliente { get; set; }
        public string RucCliente { get; set; }
        public string Direccion { get; set; }
        public string Codcdv { get; set; }
        public string CondicionVenta { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Moneda { get; set; }
        public double TipoCambio { get; set; }
        public double Tota { get; set; }
        public double Toti { get; set; }
        public double Totn { get; set; }
        public string Codven { get; set; }
        public string NomVen { get; set; }
        public string Flag { get; set; }
        public string NumeroLetras { get; set; }
        public Byte[] CodigoQR { get; set; }

        public Factura() { }
        public Factura(string cdocu,string ndocu,string nombrecliente,string dnicliente,string ruccliente,byte[] codigoqr )
        {
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.NombreCliente = nombrecliente;
            this.DniCliente = dnicliente;
            this.RucCliente = ruccliente;
            this.CodigoQR = codigoqr;
        }
    }

    public class DetalleFactura
    {
        public string Cdocu { get; set; }
        public string Ndocu { get; set; }
        public int Item { get; set; }
        public string Codi { get; set; }
        public string Codf { get; set; }
        public string Marca { get; set; }
        public string Descrip { get; set; }
        public string Umed { get; set; }
        public double Cantidad { get; set; }
        public double Preu { get; set; }
        public double Tota { get; set; }
        public double Totn { get; set; }
        public string Mone { get; set; }

    }
}
