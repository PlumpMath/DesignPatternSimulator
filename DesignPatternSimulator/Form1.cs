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

namespace DesignPatternSimulator
{
    public partial class Form1 : Form
    {
        private FabriqueManager fm;
        private TableLayoutPanel pan;
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

            List<AbstractZone> lesZones = sdj.usa.GetPlateauDeJeu().getZonesAcces();

            //var f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();

            this.Controls.Clear();
            EnvironnementDeJeuMoyenAge env = new EnvironnementDeJeuMoyenAge();
            FactoryPersonnage per = new FactoryPersonnageMoyenAge();
            fm = new FabriqueManager(env, per);

            pan = fm.InitTableLayout(30, 30);
            /*
            TableLayoutPanel pan = new TableLayoutPanel();
            pan.Dock = DockStyle.Fill;

            // Create TableLayoutPanel
            TableLayoutPanel tlp = new TableLayoutPanel();

            // Grid has two columns
            tlp.ColumnCount = 10;

            // Grid has two rows
            tlp.RowCount = 10;

            float percentRow = 100 / tlp.RowCount;
            float percentColumn = 100 / tlp.ColumnCount;

            int maxCount = 0;
            if(tlp.RowCount == tlp.ColumnCount)
            {
                maxCount = tlp.RowCount;
            }
            else
            {
                if (tlp.RowCount > tlp.ColumnCount)
                {
                    maxCount = tlp.RowCount;
                }
                else
                {
                    maxCount = tlp.ColumnCount;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                if(tlp.RowCount <= maxCount)
                {
                    tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, percentRow));
                }
                if(tlp.ColumnCount <= maxCount)
                {
                    tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percentColumn));
                }
            }

            // Set the BorderStyle to Inset
            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            // If grid is full add extra cells by adding column
            tlp.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;

            // Padding (pixels)within each cell (left, top, right, bottom)
            tlp.Padding = new Padding(1, 1, 1, 1);

            tlp.Dock = DockStyle.Fill;

            // Add TableLayoutPanel to the Forms controls
            this.Controls.Add(tlp);

            TextBox text = new TextBox();
            text.Enabled = false;
            TextBox text2 = new TextBox();
            text2.Enabled = false;
            text.Text = "début";
            tlp.Controls.Add(text, 2, 1);
            text2.Text = "fin";
            tlp.Controls.Add(text2, 0, 3);
            
            PictureBox pic = new PictureBox();
            pic.ImageLocation = "C:\\Users\\Mamadou\\GitHub\\DesignPatternSimulator\\DesignPatternSimulator\\designpattern\\strategie\\personnage\\pictures\\eliwood_critique45.png";
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            tlp.Controls.Add(pic, 0, 3);
            */
            deplacerPerso();

            this.Controls.Add(pan);
        }

        public void deplacerPerso()
        {
            /*
            DateTime ta_variable = DateTime.Now;
            int x = ta_variable.Millisecond;

            while (x < x+ 0) // X en milliseconde il me semble
            { }*/
            pan = fm.deplacerPersonnage(pan);
            this.Refresh();
        }
    }
}
