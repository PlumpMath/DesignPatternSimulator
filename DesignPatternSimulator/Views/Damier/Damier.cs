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

        public Dictionary<Color, Rectangle> listeTriangle = new Dictionary<Color, Rectangle>();

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
                rec.Height = 25;
                rec.Width = 25;
                rec.X = zone.X * rec.Height;
                rec.Y = zone.Y * rec.Width;

                listeRectanges.Add(rec);
            }

            Pen pen = new Pen(Color.Red, 2);
            //using(Graphics graphics = this.painter1.CreateGraphics())
            //{
            //    for (int i = 0; i <= 9; i++)
            //    {
            //        for (int j = 0; j <= 9; j++)
            //        {
            //            Brush brush = (i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0) ? Brushes.Green : Brushes.White;
            //            graphics.FillRectangle(brush, new Rectangle(i * 45, j * 45, 45, 45));
            //        }
            //    }
            //}

            //using (Graphics g = this.painter1.CreateGraphics())
            //{
            //    g.DrawRectangles(pen, listeRectanges.ToArray());
            //    // this.Invalidate();
            //}
            Pen peno = new Pen(Color.Black, 1);
            Label newlabel = new Label();
            using (Graphics g = this.painter1.CreateGraphics()) 
            {
                //g.DrawRectangles(peno, listeRectanges.ToArray());
                foreach (var item in listeRectanges.ToArray())
                {
                    
                    if (item.X % 2 == 0)
                    {
                        if (item.Y % 2 == 0)
                        {
                            Brush brush = Brushes.White;

                            g.DrawRectangle(peno, item);
                            g.FillRectangle(brush, item);
                            g.DrawImage(Image.FromFile(@"C:\Users\"+Environment.UserName+@"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                        }
                        else
                        {
                            Brush brush = Brushes.Turquoise;
                            g.DrawRectangle(peno, item);
                            g.FillRectangle(brush, item);
                            g.DrawImage(Image.FromFile(@"C:\Users\"+Environment.UserName+@"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);

                        }

                    }
                    else
                    {
                        if (item.Y % 2 == 0)
                        {
                            Brush brush = Brushes.Turquoise;
                            Brush balck = Brushes.Black;
                            g.DrawRectangle(peno, item);
                            g.FillRectangle(brush, item);
                            g.DrawImage(Image.FromFile(@"C:\Users\"+Environment.UserName+@"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                        }
                        else
                        {
                            Brush brush = Brushes.White;
                            g.DrawRectangle(peno, item);
                            g.FillRectangle(brush, item);
                            g.DrawImage(Image.FromFile(@"C:\Users\"+Environment.UserName+@"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                        }
                    }

                }
            }

        }

    }
}
