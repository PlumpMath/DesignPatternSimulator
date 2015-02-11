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
            //Application.Run(new SelectorSimulation());
            //Application.Run(new TestDamier());
            //Application.Run(new Damier());

            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var plateau = fm.Organisme.Plateau.getZoneForFree().Count;
            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var p = fm.Organisme.Plateau;
            //Rectangle rec = new Rectangle();
            var listeDesZones = fm.Organisme.Plateau.getZoneForFree();
            var nbrePionBlanc = fm.Organisme.Plateau.getZoneForFree().Where(c => c.PionPosseder == "PionBlanc").Count();
            var nbrePionNoir = fm.Organisme.Plateau.getZoneForFree().Where(c => c.PionPosseder == "PionNoir").Count();
            //DrawDamierInital(this.painter1, fm.Organisme.Plateau);
            fm.ShowAllPersonnage();

            fm.Organisme.Execution(fm.LesPersonnes, fm.Organisme.Plateau);
            fm.Organisme.Execution(fm.LesPersonnes, fm.Organisme.Plateau);
            fm.ShowAllPersonnage();

            Console.WriteLine("Joyeux");

            var plateauChange = fm.Organisme.Plateau.getZoneForFree().Where(c => c.Occupe == true).Count();

            foreach (Pion item in fm.LesPersonnes)
            {
                Console.WriteLine(item.PionManger);
            }

            Console.WriteLine("Unfuck");
        }
    }
}
