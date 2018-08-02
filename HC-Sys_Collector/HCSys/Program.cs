using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSys
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connexion.ConnectToDb();
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("EN-en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("EN-en");
            Application.Run(new Form2());
        }
    }
}
