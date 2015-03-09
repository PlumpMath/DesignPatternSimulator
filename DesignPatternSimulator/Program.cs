using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternSimulator.Views;
using DesignPatternSimulator.Views.Labyrinthe;

namespace DesignPatternSimulator
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
            Application.Run(new Damier());
            //Application.Run(new TestDamier());
            //Application.Run(new Damier());
        }
    }
}
