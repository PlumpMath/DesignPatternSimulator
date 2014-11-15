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

            //var f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();

            this.Controls.Clear();

            TableLayoutPanel pan = new TableLayoutPanel();
            pan.Dock = DockStyle.Fill;



            /*
            pan.ColumnCount = 5;
            pan.RowCount = 5;
            pan.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            TableLayoutColumnStyleCollection styles = pan.ColumnStyles;
            foreach (ColumnStyle style in styles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 20;
            }

            TableLayoutRowStyleCollection rowstyles = pan.RowStyles;
            foreach (RowStyle style in rowstyles)
            {
                style.SizeType = SizeType.Percent;
                style.Height = 20;
            }
            */

            // Create TableLayoutPanel
            TableLayoutPanel tlp = new TableLayoutPanel();
            
            /*tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            
            //tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            //tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            */

            // Grid has two columns
            tlp.ColumnCount = 10;

            // Grid has two rows
            tlp.RowCount = 10;

            float percent = 100 / tlp.RowCount;
            Console.WriteLine(percent);
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, percent));
            }

            percent = 100 / tlp.ColumnCount;
            for (int j = 0; j < tlp.ColumnCount; j++ )
            {
                tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percent));
            }

            //tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            //tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

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
        }
    }
}
