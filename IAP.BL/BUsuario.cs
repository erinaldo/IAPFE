using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAP.BE;
using System.Transactions;
using IAP.DL;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace IAP.BL
{
    public class BUsuario
    {
        DUsuario du = new DUsuario();   
        public BUsuario() { }

        public Boolean ObtenerUsuario(string correo, string contrasena, string dbEmpresa)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
               
                return du.ObtenerUsuario(correo, contrasena, dbEmpresa);
                ts.Complete();
            }
        }
        public List<Usuario> ObtenerUsuariosIntranet(int id, string nombres, int esLista, string dbEmpresa)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                return du.ObtenerUsuariosIntranet(id,nombres,esLista, dbEmpresa);
                ts.Complete();
            }
        }

        public Boolean RegistrarUsuarioIntranet(Usuario eu, string dbEmpresa)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {

                du.RegistrarUsuarioIntranet(eu, dbEmpresa);
                ts.Complete();
                return true;
            }
        }

    }
}
