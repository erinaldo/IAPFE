using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IAP.DL
{
    public class Procedimientos_Generales
    {
        public static DataSet CargaExcel(string RutaExcel, string NombreHoja)
        {
            try
            {
                System.Data.OleDb.OleDbConnection connXls;
                System.Data.DataSet DSet;
                System.Data.OleDb.OleDbDataAdapter cmdXls;
                connXls = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    //RutaExcel + ";Extended Properties="+"""Excel 12.0;HDR=YES"""+" "+);
                                                                 RutaExcel + ";Extended Properties=\"Excel 12.0;HDR=YES\"");
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & SLibro & ";Extended Properties=""Excel 12.0;HDR=YES""
                //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & SLibro & ";Extended Properties=""Excel 12.0;HDR=YES"
                cmdXls = new System.Data.OleDb.OleDbDataAdapter

                ("select * from [" + NombreHoja + "$]", connXls);
                cmdXls.TableMappings.Add("Table", "TestTable");
                DSet = new System.Data.DataSet();
                cmdXls.Fill(DSet);
                connXls.Close();
                return DSet;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            

        }
    }
}
