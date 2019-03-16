using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using IAP.BE;
using System.Data.Common;
using System.IO;

namespace IAP.DL
{
    public class DCreditos
    {
        public DCreditos()
        {

        }

        public List<LetrasEmitidas> Obtener_LetrasElectronicas(DateTime fechainicial, DateTime fechafinal, string nombrecliente, string nroletra, string dbConexion)
        {
            List<LetrasEmitidas> lst = new List<LetrasEmitidas>();
            Database db = DatabaseFactory.CreateDatabase(dbConexion);
            DbCommand cmd;
            cmd = db.GetStoredProcCommand("USP_SEL_LETRASEMITIDAS", fechainicial, fechafinal, nombrecliente, nroletra);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;

            DataSet ds = db.ExecuteDataSet(cmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lst.Add(new LetrasEmitidas
                {
                    Fecha = Convert.ToDateTime(row["fecha"]),
                    Cdocu = row["cdocu"].ToString(),
                    Ndocu = row["ndocu"].ToString(),
                    Crefe = row["crefe"].ToString(),
                    Nrefe = row["nrefe"].ToString(),
                    Codcli = row["codcli"].ToString(),
                    Nomcli = row["nomcli"].ToString(),
                    Ruccli = row["ruccli"].ToString(),
                    Monto = Convert.ToDouble(row["monto"]),
                    Saldo = Convert.ToDouble(row["saldo"]),
                    Glosa = row["glosa"].ToString(),
                    Dias = Convert.ToInt32(row["dias"]),
                    Fven = Convert.ToDateTime(row["fven"]),
                    Tcam = Convert.ToDouble(row["tcam"]),
                    Mone = row["mone"].ToString(),
                    Nomest = row["nomest"].ToString(),
                    Nomsub = row["nomsub"].ToString(),
                    Nombcox = row["nombcox"].ToString(),
                    Nomdis = row["nomdis"].ToString(),
                    Nompro = row["nompro"].ToString(),
                    Dircli = row["dircli"].ToString(),
                    Coddis = row["coddis"].ToString(),
                    Codpro = row["codpro"].ToString(),
                    Telcli = row["telcli"].ToString(),
                    Rucava = row["rucava"].ToString(),
                    Nomava = row["nomava"].ToString(),
                    Dirava = row["dirava"].ToString(),
                    Telava = row["telava"].ToString(),
                    

                });

            }
            return lst;

        }
    }
}
