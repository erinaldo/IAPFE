using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using IAP.BE;
namespace IAP.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISUsuario
    {
        [OperationContract]
        Boolean ObtenerExistenciaUsuario(string correo, string contrasena);

        [OperationContract]
        List<Usuario> ObtenerUsuariosIntranet(int id, string nombres, int eslista, string dbEmpresa);

        [OperationContract]
        Boolean RegistrarUsuarioIntranet(Usuario eu, string dbEmpresa);
    }
}
