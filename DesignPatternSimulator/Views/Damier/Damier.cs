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
        public SimulationDeJeuDame simulation;
        public Damier()
        {
            InitializeComponent();
            //Paint += new PaintEventHandler(Damier_Paint);
        }

        PlateauDeJeuDame plateau;
        Bitmap checkerBoardBitmap = new Bitmap(400, 400);
        private void launcher_Click(object sender, EventArgs e)
        {
            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var plateau = fm.Organisme.Plateau.getZoneForFree().Count;
            
            Graphics checkBoard = Graphics.FromImage(checkerBoardBitmap);

            SolidBrush fillColourBrush = new SolidBrush(Color.Red);
            checkBoard.Clear(this.consoleBox.BackColor);

            //var sim = simulation.usa.GetPlateauDeJeuDame();

            var dimensionPlateau = Math.Sqrt(plateau);

            List<Rectangle> listeRectangle = new List<Rectangle>();

            //using (Rectangle p = new Rectangle())
            //{
            Rectangle p = new Rectangle();
            foreach (var zone in fm.Organisme.Plateau.getZoneForFree())
            {
                p.X = zone.X;
                p.Y = zone.Y;
                p.Height = 4;
                p.Width = 4;

                listeRectangle.Add(p);
            }

            Pen pen = new Pen(Color.White, 10);

            
                foreach (var item in listeRectangle)
                {
                    Brush brush = (item.X % 2 == 0 && item.Y % 2 == 0) || (item.X % 2 != 0 && item.Y % 2 != 0) ? Brushes.Black : Brushes.White;
                    checkBoard.DrawRectangle(pen, item);
                    checkBoard.FillRectangle(brush, item);

                    //graph.DrawRectangle(brush, item);
                }
                //BackgroundImage = image;
            
            // code needs to be inserted here
            //.
            //.
            //.
            consoleBox.Refresh();
            consoleBox.Dispose();
            fillColourBrush.Dispose();



            /*

            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());
            
            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var p = fm.Organisme.Plateau;
            
             */

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



        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    DrawDamier(e.Graphics, simulation.usa.GetPlateauDeJeuDame());
        //}


        private void DrawDamier(Graphics graph, PlateauDeJeuDame plateau)
        {
            Bitmap image = new Bitmap(800, 800);
            var dimensionPlateau = Math.Sqrt(plateau.getZoneForFree().Count);

            List<Rectangle> listeRectangle = new List<Rectangle>();

            //using (Rectangle p = new Rectangle())
            //{
            Rectangle p = new Rectangle();
                foreach (var zone in plateau.getZoneForFree())
                {
                    p.X = zone.X;
                    p.Y = zone.Y;
                    p.Height = 4;
                    p.Width = 4;

                    listeRectangle.Add(p);
                }

            Pen pen = new Pen(Color.White,10);
            using (graph = Graphics.FromImage(image))
            {
                foreach (var item in listeRectangle)
                {
                    Brush brush = (item.X % 2 == 0 && item.Y % 2 == 0) || (item.X % 2 != 0 && item.Y % 2 != 0) ? Brushes.Black : Brushes.White;
                    graph.DrawRectangle(pen, item);
                    graph.FillRectangle(brush, item);

                    //graph.DrawRectangle(brush, item);
                }
                BackgroundImage = image;
            }
            //}






        }

        private void Damier_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(checkerBoardBitmap, 0, 0);
            /*
            // Get the graphics object
            Graphics 
            gfx = e.Graphics;
            
            // Create a new pen that we shall 
            //use for drawing the line
            Pen myPen = new Pen(Color.Black);
            
            // Loop and create a horizontal line 10 pixels
             //below the last one
            for(int i =20; i <=250;i = i + 10)
            {
                gfx.DrawLine(myPen, 20, i,270, i);
            }
            
            // Loop and create a vertical line 10 
            //pixels next to the last one
            for(int x = 20; x < 280; x = x +10)
            {   
                gfx.DrawLine(myPen, x, 20, x, 250);
            } 

            */

            //DrawDamier(e.Graphics, simulation.usa.GetPlateauDeJeuDame());
        }

       
    }
}
