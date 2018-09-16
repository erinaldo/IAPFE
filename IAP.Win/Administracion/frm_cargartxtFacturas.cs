using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAP.BE;

namespace IAP.Win.Administracion
{
    public partial class frm_cargartxtFacturas : Form
    {
        List<Mst01facTxt> _lstCabecera = new List<Mst01facTxt>();
        List<Dtl01facTxt> _lstDetalle = new List<Dtl01facTxt>();
        public frm_cargartxtFacturas()
        {
            InitializeComponent();
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                if(ofdcab.ShowDialog()==DialogResult.OK)
                {
                    string[] ruta = ofdcab.FileNames;
                    if (ruta.ToList().Any())
                        txtcabecera.Text = ruta[0].ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnabrirdet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofddet.ShowDialog() == DialogResult.OK)
                {
                    string[] ruta = ofddet.FileNames;
                    if (ruta.ToList().Any())
                        txtdetalle.Text = ruta[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(txtcabecera.Text);
            
            DataRow dr;
            Mst01facTxt eCab = new Mst01facTxt();
            Dtl01facTxt eDet = new Dtl01facTxt();
            foreach (string line in lines)
            {
                var cols = line.Split('|');
                //if (cabecera)
                //{
                //    for (int cIndex = 0; cIndex <= 2; cIndex++)
                //    {

                //        tbl.Columns.Add(new DataColumn(cols[cIndex].ToString()));
                //    }

                //    cabecera = false;
                //}
                //else
                //{
                eCab = new Mst01facTxt
                {
                    Fecha = Convert.ToDateTime(cols[0]),
                    Cdocu = cols[1].ToString(),
                    Ndocu = cols[2].ToString(),
                    Tfact = cols[3].ToString(),
                    Drefe = cols[4].ToString(),
                    Atte = cols[5].ToString(),
                    Crefe = cols[6].ToString(),
                    Nrefe = cols[7].ToString(),
                    Orde = cols[8].ToString(),
                    Codcli = cols[9].ToString(),
                    Nomcli = cols[10].ToString(),
                    Ruccli = cols[11].ToString(),
                    Codcdv = cols[12].ToString(),
                    Codvta = cols[13].ToString(),
                    Dias = Convert.ToInt32(cols[14].ToString()),
                    Fven = Convert.ToDateTime(cols[15].ToString()),
                    Mone = cols[16].ToString(),
                    Tcam = Convert.ToDouble(cols[17].ToString()),
                    Tota = Convert.ToDouble(cols[18].ToString()),
                    Toti = Convert.ToDouble(cols[19].ToString()),
                    Totn = Convert.ToDouble(cols[20].ToString()),
                    Codven = cols[21].ToString(),
                    Codalm = cols[22].ToString(),
                    Notai = cols[23].ToString(),
                    Codpto = cols[24].ToString(),
                    Flag = cols[25].ToString(),
                    Cdge = cols[26].ToString(),
                    Ndge = cols[27].ToString(),
                    Compro = cols[28].ToString(),
                    Selchk = Convert.ToInt32(cols[29].ToString()),
                    Marchk = cols[30].ToString(),
                    Lcheck = Convert.ToInt32(cols[31].ToString()),
                    Codscc = cols[32].ToString(),
                    Codfdp = cols[33].ToString(),
                    Codtar = cols[34].ToString(),
                    Geng = Convert.ToInt32(cols[35].ToString()),
                    Codtra = cols[36].ToString(),
                    Dirpar = cols[37].ToString(),
                    Dirent = cols[38].ToString(),
                    Marveh = cols[39].ToString(),
                    Plaveh = cols[40].ToString(),
                    Placar = cols[41].ToString(),
                    Nomcho = cols[42].ToString(),
                    Nrolic = cols[43].ToString(),
                    Frontera = Convert.ToInt32(cols[44].ToString()),
                    Motanu = cols[45].ToString(),
                    Autg = Convert.ToInt32(cols[46].ToString()),
                    Codrep = cols[47].ToString(),
                    Infrep = Convert.ToInt32(cols[48].ToString()),
                    Nroci = cols[49].ToString(),
                    Codsub = cols[50].ToString(),
                    Fladet = cols[51].ToString(),
                    Fecdep = Convert.ToDateTime(cols[52].ToString()),
                    Nrodep = cols[53].ToString(),
                    Impdep = Convert.ToDouble(cols[54].ToString()),
                    Observ = cols[55].ToString(),
                    Numpre = cols[56].ToString(),
                    Idalias = Convert.ToInt32(cols[57].ToString()),
                    Flagtp = cols[58].ToString(),
                    Totrc = Convert.ToDouble(cols[59].ToString()),
                    Persnt = Convert.ToInt32(cols[60].ToString()),
                    Fecreg = Convert.ToDateTime(cols[61].ToString()),
                    Tcme = Convert.ToDouble(cols[62].ToString()),
                    Nrobx = cols[63].ToString(),
                    Ctrans = cols[64].ToString(),
                    Placacar = cols[65].ToString(),
                    Modcar = cols[66].ToString(),
                    Marcar = cols[67].ToString(),
                    Añocar = Convert.ToInt32(cols[68].ToString()),
                    Kilcar = Convert.ToDouble(cols[69].ToString()),
                    Afec_flete = Convert.ToInt32(cols[70].ToString()),
                    Afec_gasto = Convert.ToInt32(cols[71].ToString()),
                    Afec_tarjeta = Convert.ToInt32(cols[72].ToString()),
                    Tipo_flete = cols[73].ToString(),
                    Idprom = Convert.ToInt32(cols[74].ToString()),
                    Forpagvta = cols[75].ToString(),
                    Codpag = cols[76].ToString(),
                    Nropag = cols[77].ToString(),
                    Agru = cols[78].ToString(),
                    Dagru = cols[79].ToString(),
                    For_pag = Convert.ToInt32(cols[80].ToString())
                };


                _lstCabecera.Add(eCab);

                //dr = tbl.NewRow();
                //for (int cIndex = 0; cIndex <= cols.ToList().Count(); cIndex++)
                //{

                //    dr[cIndex] = cols[cIndex];
                //}

                //tbl.Rows.Add(dr);   
                //}
            }
            gctxt.DataSource = tbl;
            gctxt.Refresh();

            lines = System.IO.File.ReadAllLines(txtdetalle.Text);
            foreach(string line in lines)
            {
                var cols = line.Split('|');
                eDet = new Dtl01facTxt
                {
                    Fecha = Convert.ToDateTime(cols[0].ToString()),
                    Cdocu = cols[1].ToString(),
                    Ndocu = cols[2].ToString(),
                    Tfact = cols[3].ToString(),
                    Codcli = cols[4].ToString(),
                    Guia = cols[5].ToString(),
                    Item = Convert.ToDouble(cols[6].ToString()),
                    Codi = cols[7].ToString(),
                    Codf = cols[8].ToString(),
                    Marc = cols[9].ToString(),
                    Descr = cols[10].ToString(),
                    Umed = cols[11].ToString(),
                    Cant = Convert.ToDouble(cols[12].ToString()),
                    Cdes = Convert.ToDouble(cols[13].ToString()),
                    Cost = Convert.ToDouble(cols[14].ToString()),
                    Preu = Convert.ToDouble(cols[15].ToString()),
                    Dsct = Convert.ToDouble(cols[16].ToString()),
                    Dsct2 =Convert.ToDouble( cols[17].ToString()),
                    Dsct3 =Convert.ToDouble( cols[18].ToString()),
                    Tota = Convert.ToDouble(cols[19].ToString()),
                    Totn = Convert.ToDouble(cols[20].ToString()),
                    Mone = cols[21].ToString(),
                    Moneitm = cols[22].ToString(),
                    Tcam = Convert.ToDouble(cols[23].ToString()),
                    Aigv = cols[24].ToString(),
                    Codalm = cols[25].ToString(),
                    Codvta = cols[26].ToString(),
                    Codcdv = cols[27].ToString(),
                    Codven = cols[28].ToString(),
                    Codpos = cols[29].ToString(),
                    Flag = cols[30].ToString(),
                    Msto = cols[31].ToString(),
                    Uvta = Convert.ToInt32(cols[32].ToString()),
                    Umedu = cols[33].ToString(),
                    Plcpa = Convert.ToDouble(cols[34].ToString()),
                    Plpvta = Convert.ToDouble(cols[35].ToString()),
                    Ucon = Convert.ToDouble(cols[36].ToString()),
                    Ucom = cols[37].ToString(),
                    Dis_fle = Convert.ToDouble(cols[38].ToString()),
                    Dis_gas = Convert.ToDouble(cols[39].ToString()),
                    Canbon = Convert.ToDouble(cols[40].ToString()),
                    Codscc = cols[41].ToString(),
                    Dis_tar = Convert.ToDouble(cols[42].ToString()),
                    Plce = Convert.ToDouble(cols[43].ToString()),
                    Idprom = Convert.ToInt32(cols[44].ToString())
                };
                _lstDetalle.Add(eDet);
            }
            //List<object> lstcab = ((IEnumerable)gctxt.DataSource).Cast<object>().ToList();

        }
    }

    public class cab
    {
        public string cdocu { get; set; }
        public string ndocu { get; set; }
        public DateTime fecha { get; set; }

    }
}
