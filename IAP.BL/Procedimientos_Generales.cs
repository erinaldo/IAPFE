using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace IAP.BL
{
    public class Procedimientos_Generales
    {
        public static DataSet CargaExcel(string RutaExcelBL, string NombreHojaBL)
        {
            try
            {
                DataSet ds_le = new DataSet();
                ds_le = DL.Procedimientos_Generales.CargaExcel(RutaExcelBL, NombreHojaBL);
                ds_le.Tables[0].TableName = "listaexcel";
                return ds_le;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
