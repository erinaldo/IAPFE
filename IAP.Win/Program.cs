using IAP.Win.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using IAP.Win.Comercial;
namespace IAP.Win
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FRM_MENU_MAIN());
            Application.Run(new Splash());
            //Application.Run(new frm_facturas());
        }
    }
}
