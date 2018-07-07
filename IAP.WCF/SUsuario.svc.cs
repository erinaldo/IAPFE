using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using IAP.DL;
using IAP.BL;
using IAP.BE;
namespace IAP.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SUsuario.svc o SUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SUsuario : ISUsuario
    {
        
        public Boolean ObtenerExistenciaUsuario(string correo,string contrasena)
        {
            
            BUsuario bu = new BUsuario();
            return bu.ObtenerUsuario(correo, contrasena, "BdNava01");
           
        }
        public List<Usuario> ObtenerUsuariosIntranet(int id,string nombres,int eslista, string dbEmpresa)
        {
            BUsuario bu = new BUsuario();
            return bu.ObtenerUsuariosIntranet(id,nombres,eslista, dbEmpresa);
        }

        public Boolean RegistrarUsuarioIntranet(Usuario eu, string dbEmpresa)
        {
            BUsuario bu = new BUsuario();
            return bu.RegistrarUsuarioIntranet(eu, dbEmpresa);
        }

    }

}
