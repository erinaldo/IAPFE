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
        public string codcdv { get; set; }
        public string nomcodcdv { get; set; }
        public string mone { get; set; }
        public Boolean flag_arqueado { get; set; }
        public DateTime? fechaarqueo { get; set; }
        public string usuarioArqueo { get; set; }
        public double saldo { get; set; }
        public Boolean flag_cancelado { get; set; }

        public int IdPedidoAndroid { get; set; }
        public string DirEnt { get; set; }
        public string CodUsuarioRegistro { get; set; }
        public int flag_Estadopedido { get; set; }
        public string EstadoPedido { get; set; }
        public string Cod_Operario { get; set; }
        public DateTime? FechaInicioServicio { get; set; }
        public DateTime? FechaFinServicio { get; set; }
        public string Tiempo { get; set; }

    }

    public class OrdenServicioLinea
    {
        public int IdPedidoLinea { get; set; }
        public int IdPedido { get; set; }
        public string codf { get; set; }
        public string codi { get; set; }
        public string descr { get; set; }
        public string marc { get; set; }
        public string umed { get; set; }
        public double cant { get; set; }
        public double preu { get; set; }
        public double tota { get; set; }
        public double totn { get; set; }
        public string Cod_Operario { get; set; }
        public DateTime? FechaInicioServicio { get; set; }
        public DateTime? FechaFinServicio { get; set; }
        public string ndocu { get; set; }
        public string item { get; set; }
        public string tiposervicio { get; set; }

    }

    public class OrdenServicioDocumento
    {
        public OrdenServicio Cabecera { get; set; }
        public List<OrdenServicioLinea> Detalle { get; set; }
    }

    public class OrdenServicioPlantillaParametros
    {
        public string ndocu { get; set; }
        public string cod_operario { get; set; }
        public string codi { get; set; }
        public string item { get; set; }
        public double p1   {get;set;}
        public double p2   {get;set;}
        public double p3   {get;set;}
        public double p4   {get;set;}
        public double p5   {get;set;}
        public double p6   {get;set;}
        public double p7   {get;set;}
        public double p8   {get;set;}
        public double p9   {get;set;}
        public double p10  {get;set;}
        public double p11  {get;set;}
        public double p12 { get; set; }
        public double p13 {get;set;}
        public double p14 {get;set;}
        public double p15 {get;set;}
        public double p16 {get;set;}
        public double p17 {get;set;}
        public double p18 {get;set;}
        public double p19 {get;set;}
        public double p20 { get; set; }

    }

}
