using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class Guia
    {
        public DateTime Fecha            {get;set;}
        public string Cdocu            {get;set;}
        public string Ndocu            {get;set;}
        
        public string Codcli           {get;set;}
        public string Nomcli           {get;set;}
        public string Ruccli           {get;set;}
        public string CodGlo { get; set; }
        public string MotivoTraslado { get; set; }
        public string CodTrans { get; set; }
        public string Transportista { get; set; }
        public string TelefonoTransp { get; set; }
        public string DireccionTransp { get; set; }
        public string RucTransp { get; set; }
        public string TipoDocRefe { get; set; }
        public string Crefe { get; set; }
        public string Nrefe { get; set; }
        public string Mone { get; set; }
        public double TipoCambio { get; set; }
        public double Tota { get; set; }
        public double Toti { get; set; }
        public double Totn { get; set; }
        public string Codven { get; set; }
        public string Nomven { get; set; }
        public string DireccionPartida { get; set; }
        public string DireccionEntrega { get; set; }
        public string MarcaVehiculo { get; set; }
        public string PlacaVehiculo { get; set; }
        public string NombreChofer { get; set; }
        public string NroLicencia { get; set; }
        public string Anno { get; set; }
        public string Mes { get; set; }
        public string Dia { get; set; }
        public string NroFactura { get; set; }
        public string DirCli { get; set; }
        

    }

    public class DetalleGuia
    {
        public string Cdocu    {get;set;}
        public string Ndocu    {get;set;}
        public int Item     {get;set;}
        public string Codi     {get;set;}
        public string Codf     {get;set;}
        public string Marc     {get;set;}
        public string Descr    {get;set;}
        public string Umed     {get;set;}
        public double Cant     {get;set;}
        public double Preu     {get;set;}
        public double Tota     {get;set;}
        public double Totn     {get;set;}
        public string Mone     {get;set;}

    }
}
