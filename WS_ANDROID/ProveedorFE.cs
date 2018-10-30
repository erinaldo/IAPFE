using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    public class ProveedorFE
    {
        public string Empresa { get; set; }
        public string Ruc { get; set; }
        public string Link      {get;set;}
        public string Usuario   {get;set;}
        public string Clave     {get;set;}
        public string Ruta      {get;set;}
        public string Token     {get;set;}
        public string IdEmpresa { get; set; }

        public ProveedorFE()
        { }

        public ProveedorFE(string empresa,string ruc,string link,string usuario,string clave,string ruta,string token)
        {
            this.Empresa = empresa;
            this.Ruc = ruc;
            this.Link = link;
            this.Usuario = usuario;
            this.Clave = clave;
            this.Ruta = ruta;
            this.Token = token;
        }
    }
}
