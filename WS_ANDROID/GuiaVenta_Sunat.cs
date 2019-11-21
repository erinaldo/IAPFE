using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class GuiaVenta_Sunat
    {
        public DateTime Fecha { get; set; }
        public string Cdocu { get; set; }
        public string Ndocu { get; set; }
        public string Nomcli { get; set; }
        public string Ruccli { get; set; }
        public string Crefe { get; set; }
        public string Nrefe { get; set; }
        public string MotAnu { get; set; }
        public double Tota { get; set; }
        public double Toti { get; set; }
        public double Totn { get; set; }
        public DateTime? Telesoluciones_FechaEmisionCliente { get; set; }
        public DateTime? Telesoluciones_FechaEmisionSunat { get; set; }
        public string Telesoluciones_CodigoComprobanteSunat { get; set; }
        public int? Telesoluciones_IdGuiaRemitente { get; set; }
        public string Telesoluciones_Serie { get; set; }
        public int? Telesoluciones_Numero { get; set; }
        public int? Telesoluciones_Emitido { get; set; }
        public int? Telesoluciones_Baja { get; set; }
        public string Telesoluciones_DigestValue { get; set; }
        public string Telesoluciones_SignatureValue { get; set; }
        public int? Telesoluciones_IdConstancia { get; set; }
        public bool Telesoluciones_FlagEnviadoSunat { get; set; }
        public bool FlgCheck { get; set; }

        public string Flag { get; set; }

        //public GuiaVenta_Sunat(string cdocu, string ndocu, string flag, bool flag_enviado)
        //{
        //    this.Cdocu = cdocu;
        //    this.Ndocu = ndocu;
        //    this.Telesoluciones_FlagEnviadoSunat = flag_enviado;
        //    this.Flag = flag;


        //}

    }
    

    public class GuiaVentaLinea_Sunat
    {
        public string Codi { get; set; }
        public string Codf { get; set; }
        public string Marc { get; set; }
        public string Descr { get; set; }
        public string Umed { get; set; }
        public double Cantidad { get; set; }
        public double Preu { get; set; }
        public double Totn { get; set; }

    }
}
