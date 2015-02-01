using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.main;
using DesignPatternSimulator.simulation.fabriquemanager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternSimulator.simulation;


namespace DesignPatternSimulator.Views.Damier
{
    public partial class Damier : Form
    {
        public Damier()
        {
            InitializeComponent();
        }

        private void launcher_Click(object sender, EventArgs e)
        {
            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());
            
            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var p = fm.Organisme.Plateau;
            //var perso = fm.
            //SimulationDeJeuDame sdj = new SimulationDeJeuDame();
            //sdj.CreatePersonnagesDuJeu(new FactoryPersonnageDame());
            ////sdj.CreatePersonnagesDuJeu(new FactoryPersonnageGuerreDuGolf());
            ////sdj.FaireCrierToutLeMonde();
            //Console.WriteLine("--------");
            //consoleBox.Text += sdj.ShowAllPersonnage();
            //consoleBox.Text += "\n";
            //Console.WriteLine("--------");
            ////sdj.PartirAuCombat();
            //consoleBox.Text += sdj.AfficherLesUploads();
            //consoleBox.Text += "\n";
            //Console.WriteLine("--------");
            //sdj.ChangeEtat(eMode.AVANCER);
            //consoleBox.Text += sdj.AfficherLesUploadsObservateur();
            //consoleBox.Text += "\n";
            //Console.WriteLine("--------");

            //List<AbstractZone> lesZones = sdj.usa.GetPlateauDeJeu().getZonesAcces();

            //var f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();

            //this.Controls.Clear();
            //EnvironnementDame env = new EnvironnementDame();
            //FactoryPersonnage per = new FactoryPersonnageDame();
            //FabriqueManagerDame fm = new FabriqueManagerDame(env, per);

            //TableLayoutPanel pan = fm.InitTableLayout(10, 10);
            

            //this.Controls.Add(pan);
        }


    }
}
