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
using DesignPatternSimulator.designpattern.environnement.style;


namespace DesignPatternSimulator.Views.Labyrinthe
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
        FabriqueManagerDame fm = new FabriqueManagerDame();
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


        

        private void DrawDamierInital(UserControl graph, List<ZonePion> plateau)
        {
            foreach(var zone in plateau)
            {
                rec.Height = 55;
                rec.Width = 55;
                rec.X = zone.X * rec.Height;
                rec.Y = zone.Y * rec.Width;

                Pen peno = new Pen(Color.Black);
                using (Graphics g = graph.CreateGraphics())
                {
                    if (rec.X % 2 == 0)
                    {
                        if (rec.Y % 2 == 0)
                        {
                            Brush brush = Brushes.White;
                            
                            g.DrawRectangle(peno, rec);
                            g.FillRectangle(brush, rec);
                            if (zone.Occupe == true && zone.PionPosseder.Equals("PionBlanc"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png"), rec);
                            else if (zone.Occupe == true && zone.PionPosseder.Equals("PionNoir"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                        }
                        else
                        {
                            Brush brush = Brushes.Turquoise;
                            g.DrawRectangle(peno, rec);
                            g.FillRectangle(brush, rec);
                            if (zone.Occupe == true && zone.PionPosseder.Equals("PionNoir"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                            else if (zone.Occupe == true && zone.PionPosseder.Equals("PionBlanc"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png"), rec);
                        }

                    }
                    else
                    {
                        if (rec.Y % 2 == 0)
                        {
                            Brush brush = Brushes.Turquoise;
                            Brush balck = Brushes.Black;
                            g.DrawRectangle(peno, rec);
                            g.FillRectangle(brush, rec);
                            if (zone.Occupe == true && zone.PionPosseder.Equals("PionNoir"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                            else if (zone.Occupe == true && zone.PionPosseder.Equals("PionBlanc"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png"), rec);
                        }
                        else
                        {
                            Brush brush = Brushes.White;
                            g.DrawRectangle(peno, rec);
                            g.FillRectangle(brush, rec);
                            if (zone.Occupe == true && zone.PionPosseder.Equals("PionBlanc"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png"), rec);
                            else if (zone.Occupe == true && zone.PionPosseder.Equals("PionNoir"))
                                g.DrawImage(Image.FromFile(@"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png"), rec);
                        }
                    }
                }
            }


        }


     


   

        List<Rectangle> listeRectangles = new List<Rectangle>();
        //private void Damier_Paint(object sender, PaintEventArgs e)
        //{
        //    using (Pen pen = new Pen(Color.Red, 2))
        //    {
        //        e.Graphics.DrawRectangles(pen, listeRectanges.ToArray());
        //    }

        //}

        public Dictionary<Color, Rectangle> listeTriangleithColor = new Dictionary<Color, Rectangle>();
        public Dictionary<bool,Rectangle> listeRectangleWithOccupied = new Dictionary<bool,Rectangle>();
        private void Damier_Load(object sender, EventArgs e)
        {

        }

        //protected override void OnPaint (PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    DrawDamierInital(this.painter1, fm.Organisme.Plateau);
        //}
        private void Damier_Paint(object sender, PaintEventArgs e)
        {

            
            fm.CreatePersonnagesDuJeu(new FactoryPersonnageDame());

            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var plateau = fm.Organisme.Plateau.getZoneForFree().Count;
            fm.Organisme.PlacerLesPionsSurDamier(fm.LesPersonnes, fm.Organisme.Plateau);
            var p = fm.Organisme.Plateau;
            //Rectangle rec = new Rectangle();
            var listeDesZones = fm.Organisme.Plateau.getZoneForFree();
            var nbrePionBlanc = fm.Organisme.Plateau.getZoneForFree().Where(c => c.PionPosseder == "PionBlanc").Count();
            var nbrePionNoir = fm.Organisme.Plateau.getZoneForFree().Where(c => c.PionPosseder == "PionNoir").Count();
            this.DrawDamierInital(this.painter1, fm.Organisme.Plateau.getZoneForFree());

            //fm.Organisme.Execution(fm.LesPersonnes, fm.Organisme.Plateau);

        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    this.DrawDamierInital(this.painter1, fm.Organisme.Plateau);
        //    base.OnPaint(e);
        //}


        //interagir avec le jeu pions Blancs
        private void buttonB_Click(object sender, EventArgs e)
        {

        }



        //interagir avec le jeu pions Noirs
        private void buttonN_Click(object sender, EventArgs e)
        {

        }



    }
}
