using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using DevExpress.Utils;
namespace IAP.Win
{
    public partial class frm_statusSQL : Form
    {
        public frm_statusSQL()
        {
            InitializeComponent();
        }

        private void frm_statusSQL_Load(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");
            if (sc.Status.ToString().ToUpper() == "RUNNING")
                txtestado.Text = "EL servicio de BD esta activo";
            if(sc.Status.ToString().ToUpper() == "STOPPED")
                txtestado.Text = "EL servicio de BD esta inactivo";
        }
        private void StopService()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");

            try
            {
                if (sc != null && sc.Status == ServiceControllerStatus.Running)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Deteniendo Servicio>>>>"))
                    {
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);
                        txtestado.Text = "EL servicio de BD esta inactivo";
                    }
                    
                }
                
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void StartService()
        {
            ServiceController sc = new ServiceController("MSSQLSERVER");

            try
            {
                if (sc != null && sc.Status == ServiceControllerStatus.Stopped)
                {
                    using (WaitDialogForm waitDialog = new WaitDialogForm("Espere por favor...", "<<<<Iniciando Servicio>>>>"))
                    {
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);
                        txtestado.Text = "EL servicio de BD esta activo";
                    }
                    
                }
               
                sc.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error al arrancar el servicio:");
                //MessageBox.Show(ex.InnerException.ToString());
                MessageBox.Show(ex.Message.ToString());
                //Console.WriteLine(ex.Message);
            }
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            StopService();
        }
    }

    
}
