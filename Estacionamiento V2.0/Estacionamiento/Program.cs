using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Estacionamiento
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new f_login());


            f_login fLogin = new f_login();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                
                Application.Run(new f_Inicio(fLogin.Permiso, fLogin.Usuario));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
