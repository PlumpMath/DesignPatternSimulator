using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternSimulator.Views;
using DesignPatternSimulator.Views.Damier;
using DesignPatternSimulator.simulation.fabriquemanager;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        //[STAThread]
        static void Main( string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectorSimulation());
            //Application.Run(new TestDamier());
            //Application.Run(new Damier());


        }
    }
}
