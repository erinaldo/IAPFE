using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAP.Win.Usuario;

namespace IAP.Win.Usuario
{
    public partial class Splash : Form
    {
        Timer tmr;
        public Splash()
        {
            InitializeComponent();
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform
            this.Hide();
            FRM_MENU_MAIN mf = new FRM_MENU_MAIN();

            mf.Show();

            //hide this form

            

        }
        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }
    }
}
