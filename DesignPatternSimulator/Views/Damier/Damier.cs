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
using DesignPatternSimulator.designpattern.strategie.personnage;


namespace DesignPatternSimulator.Views.Damier
{
    public partial class Damier : Form
    {
        public SimulationDeJeuDame simulation;
        public Damier()
        {
            InitializeComponent();
            //for (int i = 0; i < 24; i++)
            //{
            //    rec = new Rectangle(15,15,15,15);
            //    listeRectanges.Add(rec);
            //    this.Invalidate();
            //}
         
        }

        Rectangle rec;
        PlateauDeJeuDame plateau;
        Bitmap checkerBoardBitmap = new Bitmap(400, 400);
        private void launcher_Click(object sender, EventArgs e)
        {
            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var plateau = fm.Organisme.Plateau.getZoneForFree().Count;

            //Graphics checkBoard = Graphics.FromImage(checkerBoardBitmap);

        //    SolidBrush fillColourBrush = new SolidBrush(Color.Red);
        //    checkBoard.Clear(this.consoleBox.BackColor);

        //    //var sim = simulation.usa.GetPlateauDeJeuDame();

        //    var dimensionPlateau = Math.Sqrt(plateau);

        //    List<Rectangle> listeRectangle = new List<Rectangle>();

        //    //using (Rectangle p = new Rectangle())
        //    //{
        //    Rectangle p = new Rectangle();
        //    foreach (var zone in fm.Organisme.Plateau.getZoneForFree())
        //    {
        //        p.X = zone.X;
        //        p.Y = zone.Y;
        //        p.Height = 4;
        //        p.Width = 4;

        //        listeRectangle.Add(p);
        //    }

        //    Pen pen = new Pen(Color.White, 10);

            
        //        foreach (var item in listeRectangle)
        //        {
        //            Brush brush = (item.X % 2 == 0 && item.Y % 2 == 0) || (item.X % 2 != 0 && item.Y % 2 != 0) ? Brushes.Black : Brushes.White;
        //            checkBoard.DrawRectangle(pen, item);
        //            checkBoard.FillRectangle(brush, item);

        //            //graph.DrawRectangle(brush, item);
        //        }
        //        //BackgroundImage = image;
            
        //    // code needs to be inserted here
        //    //.
        //    //.
        //    //.
        //    consoleBox.Refresh();
        //    consoleBox.Dispose();
        //    fillColourBrush.Dispose();



        //    /*

        //    FabriqueManagerDame fm = new FabriqueManagerDame();
        //    fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());
            
        //    fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
        //    var p = fm.Organisme.Plateau;
            
        //     */

        //      //var perso = fm.
        //    //SimulationDeJeuDame sdj = new SimulationDeJeuDame();
        //    //sdj.CreatePersonnagesDuJeu(new FactoryPersonnageDame());
        //    ////sdj.CreatePersonnagesDuJeu(new FactoryPersonnageGuerreDuGolf());
        //    ////sdj.FaireCrierToutLeMonde();
        //    //Console.WriteLine("--------");
        //    //consoleBox.Text += sdj.ShowAllPersonnage();
        //    //consoleBox.Text += "\n";
        //    //Console.WriteLine("--------");
        //    ////sdj.PartirAuCombat();
        //    //consoleBox.Text += sdj.AfficherLesUploads();
        //    //consoleBox.Text += "\n";
        //    //Console.WriteLine("--------");
        //    //sdj.ChangeEtat(eMode.AVANCER);
        //    //consoleBox.Text += sdj.AfficherLesUploadsObservateur();
        //    //consoleBox.Text += "\n";
        //    //Console.WriteLine("--------");

        //    //List<AbstractZone> lesZones = sdj.usa.GetPlateauDeJeu().getZonesAcces();

        //    //var f2 = new Form2();
        //    //this.Hide();
        //    //f2.ShowDialog();

        //    //this.Controls.Clear();
        //    //EnvironnementDame env = new EnvironnementDame();
        //    //FactoryPersonnage per = new FactoryPersonnageDame();
        //    //FabriqueManagerDame fm = new FabriqueManagerDame(env, per);

        //    //TableLayoutPanel pan = fm.InitTableLayout(10, 10);
            

        //    //this.Controls.Add(pan);
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

        //private void Damier_Paint(object sender, PaintEventArgs e) { }


        private Panel[,] boardPanels;
        //private void Damier_Load(object sender, EventArgs e)
        //{
        //    //FabriqueManagerDame fm = new FabriqueManagerDame();
        //    //fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

        //    //fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
        //    //var listeDesZone = fm.Organisme.Plateau.getZoneForFree();
        //    //var plateau = fm.Organisme.Plateau.getZoneForFree().Count;


        //    //const int tileSize = 60;
        //    //const int gridSize = 10;
        //    //var clr1 = Color.DarkGray;
        //    //var clr2 = Color.White;

        //    ////initialiser le board
        //    //boardPanels = new Panel[gridSize, gridSize];

        //    //List<Pion> pipo = new List<Pion>();
        //    //foreach (Pion ez in fm.LesPersonnes)
        //    //{
        //    //    pipo.Add(ez);
        //    //}
        //    //// double for loop to handle all rows and columns
        //    //for (var n = 0; n < gridSize; n++)
        //    //{
        //    //    for (var m = 0; m < gridSize; m++)
        //    //    {
        //    //        // create new Panel control which will be one 
        //    //        // chess board tile



        //    //        //foreach(Pion uneZone in fm.LesPersonnes){
        //    //        //    if (uneZone.Position.X == n && uneZone.Position.Y == m)
        //    //        //    {
        //    //                // create new Panel control which will be one 
        //    //                // chess board tile
        //    //                var newPanel = new Panel
        //    //                {
        //    //                    Size = new Size(tileSize, tileSize),
        //    //                    Location = new Point(tileSize * n, tileSize * m),
        //    //                    //BackgroundImage = Image.FromFile(locationImage)
        //    //                };

        //    //                // add to Form's Controls so that they show up
                            
        //    //        Controls.Add(newPanel);

        //    //                // add to our 2d array of panels for future use
        //    //                boardPanels[n, m] = newPanel;

        //    //                // color the backgrounds
        //    //                if (n % 2 == 0)
        //    //                {
        //    //                    newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
        //    //                    //newPanel.BackgroundImage = Image.FromFile(PlacerImageDansPanel(pipo,n,m));
                                
                                
        //    //                }
        //    //                else
        //    //                {
        //    //                    newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
        //    //                    //newPanel.BackgroundImage = Image.FromFile(PlacerImageDansPanel(pipo, n, m));
                                
        //    //                }
        //    //    //        }
        //    //    //}
        //    //    }
        //    //}

        //}

        public string PlacerImageDansPanel(List<Pion> listePion, int n, int m)
        {
            var pion = listePion.Single(c => c.Position.X == n && c.Position.Y == m);

            if (pion.GetType().Equals(typeof(PionBlanc)))
            {
                return @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png";
            }
            else
            {
                return @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png";
            }

        }


        //private void Damier_Paint(object sender, PaintEventArgs e)
        //{

        //    e.Graphics.DrawImage(checkerBoardBitmap, 0, 0);
        //    /*
        //    // Get the graphics object
        //    Graphics 
        //    gfx = e.Graphics;
            
        //    // Create a new pen that we shall 
        //    //use for drawing the line
        //    Pen myPen = new Pen(Color.Black);
            
        //    // Loop and create a horizontal line 10 pixels
        //     //below the last one
        //    for(int i =20; i <=250;i = i + 10)
        //    {
        //        gfx.DrawLine(myPen, 20, i,270, i);
        //    }
            
        //    // Loop and create a vertical line 10 
        //    //pixels next to the last one
        //    for(int x = 20; x < 280; x = x +10)
        //    {   
        //        gfx.DrawLine(myPen, x, 20, x, 250);
        //    } 

        //    */

        //    //DrawDamier(e.Graphics, simulation.usa.GetPlateauDeJeuDame());
        //}


        //essai final



        List<Rectangle> listeRectanges = new List<Rectangle>();
        //private void Damier_Paint(object sender, PaintEventArgs e)
        //{
        //    using (Pen pen = new Pen(Color.Red, 2))
        //    {
        //        e.Graphics.DrawRectangles(pen, listeRectanges.ToArray());
        //    }

        //}


        private void Damier_Load(object sender, EventArgs e)
        {

        }

        private void Damier_Paint(object sender, PaintEventArgs e)
        {
            FabriqueManagerDame fm = new FabriqueManagerDame();
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var plateau = fm.Organisme.Plateau.getZoneForFree().Count;
            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var p = fm.Organisme.Plateau;
            Rectangle rec = new Rectangle();
            foreach (var zone in fm.Organisme.Plateau.getZoneForFree())
            {
                //p.X = zone.X;
                //p.Y = zone.Y;
                //p.Height = 4;
                //p.Width = 4;
                rec.Height = 5;
                rec.Width = 5;
                rec.X = zone.X * rec.Height;
                rec.Y = zone.Y * rec.Width;

                listeRectanges.Add(rec);
            }

            Pen pen = new Pen(Color.Red, 2);
            using (Graphics g = this.painter1.CreateGraphics())
            {
                g.DrawRectangles(pen, listeRectanges.ToArray());
               // this.Invalidate();
            }
        }

    }
}
