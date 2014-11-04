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

namespace DesignPatternSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            launcher.Click += launcher_Click;
            consoleBox.Text = "bonjour";
        }

        private void launcher_Click(object sender, EventArgs e)
        {
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
        }
    }
}
