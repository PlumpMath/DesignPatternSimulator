using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using DesignPatternSimulator.designpattern.factory.personnage.guerredugolf.FactoryPersonnageGuerreDuGolf;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.main;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.simulation.fabriquemanager;
using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.simulation;
using DesignPatternSimulator.Views.Labyrinthe;

namespace DesignPatternSimulator
{
    public partial class Form1 : Form
    {
        private FabriqueManager fm;
        private CustomTableLayoutPanel pan;
        public Form1()
        {
            InitializeComponent();
            launcher.Click += launcher_Click;
            consoleBox.Text = "bonjour";
        }

        private void launcher_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            //LabyrinthGraphix lab = new LabyrinthGraphix();
            //this.Controls.Add(lab);
        }
            /*
            //consoleBox.AppendText("\n");
            consoleBox.Text += "\n";

            SimulationDeJeu sdj = new SimulationDeJeu();
            sdj.CreatePersonnagesDuJeu(new FactoryPersonnageMoyenAge());
            //sdj.CreatePersonnagesDuJeu(new FactoryPersonnageGuerreDuGolf());
            //sdj.FaireCrierToutLeMonde();
            Console.WriteLine("--------");
            consoleBox.Text += sdj.ShowAllPersonnage();
            consoleBox.Text += "\n";
            Console.WriteLine("--------");
            //sdj.PartirAuCombat();
            consoleBox.Text += sdj.AfficherLesUploads();
            consoleBox.Text += "\n";
            Console.WriteLine("--------");
            sdj.ChangeEtat(eMode.EN_GUERRE);
            consoleBox.Text += sdj.AfficherLesUploadsObservateur();
            consoleBox.Text += "\n";
            Console.WriteLine("--------");
            sdj.ChangeEtat(eMode.EN_PAIX);
            consoleBox.Text += sdj.AfficherLesUploadsObservateur();
            consoleBox.Text += "\n";

            List<AbstractZone> lesZones = sdj.usa.GetPlateauDeJeu().getZonesAcces();

            //var f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();

            this.Controls.Clear();
            EnvironnementDeJeuMoyenAge env = new EnvironnementDeJeuMoyenAge();
            FactoryPersonnage per = new FactoryPersonnageMoyenAge();
            fm = new FabriqueManager(env, per);

            pan = fm.InitTableLayout(30, 30);

            this.Controls.Add(pan);

            deplacerPerso();
        }

        public void deplacerPerso()
        {
            int ts = DateTime.Now.Second;
            ts = ts + 10;
            
           
            bool ismove = false;
            while (ismove == false)
            {
                if (ts == DateTime.Now.Second)
                {
                    pan.deplacerPersonnage();
                    //this.Refresh();
                    ismove = true;
                }
                ts = DateTime.Now.Second;
            }
            pan = fm.deplacerPersonnage(pan);
            //this.Refresh();
        }*/
    }
}
