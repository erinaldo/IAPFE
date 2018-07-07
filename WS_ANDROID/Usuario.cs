using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP.BE
{
    [Serializable]
    public class Usuario
    {
        public Int32 Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Usuario() { }
        public Usuario(Int32 id,string nombres,string apellidos,string razonsocial,string correo,string contrasena,DateTime fecharegistro)
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.RazonSocial = razonsocial;
            this.Correo = correo;
            this.Contrasena = contrasena;
            this.FechaRegistro = fecharegistro;
        }
        public Usuario(string correo,string contrasena)
        {
            this.Correo = correo;
            this.Contrasena = contrasena;
        }
    }
}
