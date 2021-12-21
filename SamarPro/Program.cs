using SamarPro.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamarPro
{
    static class Program
    { 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static int Casheir_ID ;
        public static string Casheir_Name;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplash());
        }
    } 
}
