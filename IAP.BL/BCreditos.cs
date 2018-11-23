using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IAP.BE;
using System.Data.Common;


namespace IAP.BL
{
    public class BCreditos
    {
        public BCreditos()
        {

        }

        public List<LetrasEmitidas> Obtener_LetrasElectronicas(DateTime fechainicial, DateTime fechafinal, string nombrecliente, string nroletra, string dbConexion)
        {
            DL.DCreditos cls = new DL.DCreditos();
            return cls.Obtener_LetrasElectronicas(fechainicial, fechafinal, nombrecliente, nroletra, dbConexion);
        }
    }
}
