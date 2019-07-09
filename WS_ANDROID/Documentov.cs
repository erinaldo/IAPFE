using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Documentov
    {
        public DateTime Fecha { get; set; }
        public String Cdocu { get; set; }
        public String Ndocu { get; set; }
        public String Drefe { get; set; }
        public String Crefe { get; set; }
        public String Nrefe { get; set; }
        public Cliente Cli { get; set; }

        public CondicionVenta CondicionV { get; set; }

        public String Flag { get; set; }
        public String Estado { get; set; }
        public String Mone { get; set; }
        public double Tcam { get; set; }
        public double Tota { get; set; }
        public double Toti { get; set; }
        public double Totn { get; set; }
        public int Flg_Fe { get; set; }
        public String EstadoFe { get; set; }
        //public String RespuestaFE { get; set; }
        public string Serie { get; set; }
        public String  Numero { get; set; }
        public string Enlace { get; set; }
        public Boolean AceptadaPorSunat { get; set; }
        public string SunatDescription { get; set; }
        public String SunatNote { get; set; }
        public String SunatResponseCode { get; set; }
        public String SunatSoapError { get; set; }
        public String EnlaceDelPdf { get; set; }
        public String EnlaceDelXml { get; set; }
        public String EnlaceDelCdr { get; set; }
        public string Tipo_de_comprobante { get; set; }
        public string Motivo_Anulacion { get; set; }
        public String EnlaceDelPdfAnulado { get; set; }
        public bool FlgCheck { get; set; }
        public string TeleSol_Serie { get; set; }
        public string TeleSol_Numero { get; set; }
        public DateTime? TeleSol_FechaEmitido { get; set; }
        public string TeleSol_Emitido { get; set; }
        public string TeleSol_Baja { get; set; }
        public string TeleSol_DigestValue_Hash { get; set; }
        public string TeleSol_SignatureValue_Firma { get; set; }
        public string TeleSol_IdConstancia { get; set; }
        public string TeleSol_IdRespuesta { get; set; }
        public string TeleSol_CodigoRespuestaSunat { get; set; }
        public string TeleSol_NotaAsociada { get; set; }
        public string TeleSol_Descripcion { get; set; }
        public string TeleSol_IdFactura { get; set; }
        public string TeleSol_IdComunicacionBaja { get; set; }


        public Documentov()
        {

        }


        //CONSTRUCTOR PARA NUBEFACT
        public Documentov(DateTime fecha, string cdocu, string ndocu, string drefe, string crefe,string nrefe, Cliente cli, CondicionVenta condicionv , string flag, string estado, string mone, double tcam, double tota,
        double toti, double totn, int flg_fe, string estadofe,string serie,string numero,string enlace,Boolean aceptadaporsunat,string sunatdescription,string sunatnote,
        string sunatresponsecode,string sunatsoaperror,string enlacedelpdf,string enlacedelxml,string enlacedelcdr,string tipo_de_comprobante,string motivo_anulacion,string enlacedelpdfanulado)
        {
            this.Fecha = fecha;
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Drefe = drefe;
            this.Crefe = crefe;
            this.Nrefe = nrefe;
            this.Cli = cli;
            this.CondicionV = condicionv;
            this.Flag = flag;
            this.Estado = estado;
            this.Mone = mone;
            this.Tcam = tcam;
            this.Tota = tota;
            this.Toti = toti;
            this.Totn = totn;
            this.Flg_Fe = flg_fe;
            this.EstadoFe = estadofe;
            this.Serie = serie;
            this.Numero = numero;
            this.Enlace = enlace;
            this.AceptadaPorSunat = aceptadaporsunat;
            this.SunatDescription = sunatdescription;
            this.SunatNote = sunatnote;
            this.SunatResponseCode = sunatresponsecode;
            this.SunatSoapError = sunatsoaperror;
            this.EnlaceDelPdf = enlacedelpdf;
            this.EnlaceDelCdr = enlacedelcdr;
            this.EnlaceDelXml = enlacedelxml;
            this.Tipo_de_comprobante = tipo_de_comprobante;
            this.Motivo_Anulacion = motivo_anulacion;
            this.EnlaceDelPdfAnulado = enlacedelpdfanulado;
        }

        //CONSTRUCTOR PARA TELESOLUCIONES
        public Documentov(DateTime fecha, string cdocu, string ndocu, string drefe, string crefe, string nrefe, Cliente cli, CondicionVenta condicionv, string flag, string estado, string mone, double tcam, double tota,
        double toti, double totn, int flg_fe, string estadofe, string serie, string numero, string enlace, Boolean aceptadaporsunat, string sunatdescription, string sunatnote,
        string sunatresponsecode, string sunatsoaperror, string enlacedelpdf, string enlacedelxml, string enlacedelcdr, string tipo_de_comprobante, string motivo_anulacion, string enlacedelpdfanulado,
        string teleSol_Serie,string teleSol_Numero,DateTime? teleSol_FechaEmitido,string teleSol_Emitido,string teleSol_Baja,string teleSol_DigestValue_Hash,string teleSol_SignatureValue_Firma,
        string teleSol_IdConstancia,string teleSol_IdRespuesta,string teleSol_CodigoRespuestaSunat,string teleSol_NotaAsociada,string teleSol_Descripcion,string teleSol_IdFactura,
        string teleSol_IdComunicacionBaja)
        {
            this.Fecha = fecha;
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Drefe = drefe;
            this.Crefe = crefe;
            this.Nrefe = nrefe;
            this.Cli = cli;
            this.CondicionV = condicionv;
            this.Flag = flag;
            this.Estado = estado;
            this.Mone = mone;
            this.Tcam = tcam;
            this.Tota = tota;
            this.Toti = toti;
            this.Totn = totn;
            this.Flg_Fe = flg_fe;
            this.EstadoFe = estadofe;
            this.Serie = serie;
            this.Numero = numero;
            this.Enlace = enlace;
            this.AceptadaPorSunat = aceptadaporsunat;
            this.SunatDescription = sunatdescription;
            this.SunatNote = sunatnote;
            this.SunatResponseCode = sunatresponsecode;
            this.SunatSoapError = sunatsoaperror;
            this.EnlaceDelPdf = enlacedelpdf;
            this.EnlaceDelCdr = enlacedelcdr;
            this.EnlaceDelXml = enlacedelxml;
            this.Tipo_de_comprobante = tipo_de_comprobante;
            this.Motivo_Anulacion = motivo_anulacion;
            this.EnlaceDelPdfAnulado = enlacedelpdfanulado;
            this.TeleSol_Serie = teleSol_Serie;
            TeleSol_Numero = teleSol_Numero;
            TeleSol_FechaEmitido = teleSol_FechaEmitido;
            TeleSol_Emitido = teleSol_Emitido;
            TeleSol_Baja = teleSol_Baja;
            TeleSol_DigestValue_Hash = teleSol_DigestValue_Hash;
            TeleSol_SignatureValue_Firma = teleSol_SignatureValue_Firma;
            TeleSol_IdConstancia = teleSol_IdConstancia;
            TeleSol_IdRespuesta = teleSol_IdRespuesta;
            TeleSol_CodigoRespuestaSunat = teleSol_CodigoRespuestaSunat;
            TeleSol_NotaAsociada = teleSol_NotaAsociada;
            TeleSol_Descripcion = teleSol_Descripcion;
            TeleSol_IdFactura = teleSol_IdFactura;
            TeleSol_IdComunicacionBaja = teleSol_IdComunicacionBaja;
        }
        //CONSTRUCTOR PARA ENVIAR A SUNAT
        public Documentov(string cdocu,string ndocu,string flag,int flg_fe)
        {
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Flag = flag;
            this.Flg_Fe = flg_fe;
        }
        //CONSTRUCTOR PARA OBTENER CONSTANCIA TELESOLUCIONES
        public Documentov(string cdocu, string ndocu, string flag, int flg_fe,string teleSol_IdFactura,string teleSol_serie,string teleSol_numero)
        {
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Flag = flag;
            this.Flg_Fe = flg_fe;
            this.TeleSol_IdFactura = teleSol_IdFactura;
            this.TeleSol_Serie = teleSol_serie;
            this.TeleSol_Numero = teleSol_numero;
        }

        //CONSTRUCTOR PARA LA ANULACION
        public Documentov(string cdocu, string ndocu, string flag, int flg_fe,string tipo_de_comprobante,string motivo_Anulacion,string serie,string numero)
        {
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Flag = flag;
            this.Flg_Fe = flg_fe;
            this.Tipo_de_comprobante = tipo_de_comprobante;
            this.Motivo_Anulacion = motivo_Anulacion;
            this.Serie = serie;
            this.Numero = numero;
        }

        //CONSTRUCTOR PARA LA ANULACION TELESOLUCIONES
        public Documentov(string cdocu, string ndocu, string flag, int flg_fe, string tipo_de_comprobante, string motivo_Anulacion, string serie, string numero,
            DateTime? teleSol_FechaEmitido, string teleSol_Numero,string teleSol_Serie)
        {
            this.Cdocu = cdocu;
            this.Ndocu = ndocu;
            this.Flag = flag;
            this.Flg_Fe = flg_fe;
            this.Tipo_de_comprobante = tipo_de_comprobante;
            this.Motivo_Anulacion = motivo_Anulacion;
            this.Serie = serie;
            this.Numero = numero;
            this.TeleSol_FechaEmitido = teleSol_FechaEmitido;
            this.TeleSol_Numero = teleSol_Numero;
            this.TeleSol_Serie = teleSol_Serie;
        }

       

    }

    public class DocumentovDet
    {
        public Producto Product { get; set; }
        public Double Cant { get; set; }
        public Double Preu { get; set; }
        public Double Total { get; set; }

        public DocumentovDet()
        { }

        public DocumentovDet(Producto product, Double cant, Double preu, Double total)
        {
            this.Product = product;
            this.Cant = cant;
            this.Preu = preu;
            this.Total = total;
        }

    }

    public class TipoDocumento
    {
        public String Cdocu { get; set; }
        public String Nomdocu { get; set; }


        public TipoDocumento() { }

        public TipoDocumento(String cdocu,string nomdocu)
        {
            this.Cdocu = cdocu;
            this.Nomdocu = nomdocu;
        }
    }
}