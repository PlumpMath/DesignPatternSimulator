using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternSimulator.simulation.fabriquemanager;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.Views.Labyrinthe
{
    public partial class LabyrinthGraphix : UserControl
    {
        Labyrinthe labyrinth;
        int nbCoups;
        //int for random
        //0 = up
        //1 = right
        //2 = down
        //3 = left
        Random randomizer = new Random();

        public static int WEIGHT = 50;
        public static int IMG_SIZE = 40;
        public static int IMG_PADDING = 5;

        public static int TOP_SCREEN = 0;
        public static int RIGHT_SCREEN = 17;
        public static int DOWN_SCREEN = 8;
        public static int LEFT_SCREEN = 0;

        public static int EASY_LEVEL = 75;
        public static int MEDIUM_LEVEL = 85;
        public static int HARD_LEVEL = 95;
        public int level;

        FabriqueManagerLabyrinth fmLabyrinth;

        public List<Zone> listZone = new List<Zone>();
        public List<Rectangle> listRec = new List<Rectangle>();
        public List<Rectangle> nextStep;
        public List<Rocher> lesRochers = new List<Rocher>();
        public List<Bonus> lesBonus = new List<Bonus>();
        List<Rectangle> Cheminement = new List<Rectangle>();
        Graphics g = null;
        Hamtaro hamster;
        //Image hamtaro = Image.FromFile(@"C:\Users\"+Environment.UserName+@"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\p1.jpg");
        Tresor gain = new Tresor();
        //tout le reste est aussi composé de zones
        //Pépites..
        SolidBrush myBrush = new SolidBrush(Color.Red);

        Timer ticker = new Timer();
        Bitmap bmp;

        bool first = true;

        public LabyrinthGraphix(Labyrinthe lab, int nb, int niveau)
        //public LabyrinthGraphix(Labyrinthe lab)
        //public LabyrinthGraphix()
        {
            InitializeComponent();
            g = this.CreateGraphics();

            labyrinth = lab;
            nbCoups = nb;
            if (niveau == 1)
            {
                level = EASY_LEVEL;
            }
            else if(niveau == 2)
            {
                level = MEDIUM_LEVEL;
            }
            else
            {
                level = HARD_LEVEL;
            }

            fmLabyrinth = new FabriqueManagerLabyrinth();

            listZone = fmLabyrinth.GetLesZones();
            //hamtaro = (Image)(new Bitmap(hamtaro, new Size(IMG_SIZE, IMG_SIZE)));


            
            Rectangle rect = new Rectangle();
            rect.Size = new Size(WEIGHT, WEIGHT);
            for (int x = 0; x < 17; x++)
            {
                rect.X = x * rect.Width;
                for (int y = 0; y < 8; y++)
                {
                    rect.Y = y * rect.Height;
                    listRec.Add(rect);
                }
            }

            int yy = 24;
            Rocher roc;
            Random random = new Random();
            foreach (Zone z in listZone)
            {
                //rect.X = z.X;
                //rect.Y = z.Y;
                //listRec.Add(rect);

                if (z.GetZoneStatus() == true)
                {
                    hamster = (Hamtaro)z.GetPersonnage();
                    hamster.X = z.X;
                    hamster.Y = z.Y;

                    //hamtaroLocation = new Size(hamster.position.getPositionX(), hamster.position.getPositionY());
                }

                if (z.GetType() == typeof(Rocher))
                {
                    roc = (Rocher)z;
                    roc.changePosition(z.X, z.Y);
                    lesRochers.Add(roc);
                }

                if (z.GetZoneStatus() == false && z.GetType() == typeof(Zone) && z.X == 6 && z.Y == 4)
                {
                    yy = listZone.IndexOf(z);
                    Zone zon = listZone.ElementAt(yy);
                    gain.X = zon.X;
                    gain.Y = zon.Y;
                }

                if (z.GetZoneStatus() == false && z.GetType() == typeof(Zone))
                {
                    if (z.X != gain.X && z.Y != gain.Y)
                    {
                        bool HadSomething = false;
                        if (listZone.Contains(gain))
                        {
                            HadSomething = true;
                        }
                        foreach (Rocher unRocher in lesRochers)
                        {
                            if (z.X == unRocher.X && z.Y == unRocher.Y)
                            {
                                HadSomething = true;
                            }
                        }
                        if (HadSomething == false)
                        {
                            int al = random.Next(0, 100);
                            if (al > level)
                            {
                                lesBonus.Add(new Bonus(z.X, z.Y));
                            }
                        }
                    }
                }

                //listZone.Insert(yy, gain);
                
            }

            //Pen p = new Pen(Color.Transparent);
            //g.DrawRectangles(p, listRec.ToArray());

            //bmp = new Bitmap(894, 450, g);
        }

        public void LoadLabyrinth(Graphics graph)
        {
            g = graph;
            Pen p = new Pen(Color.Black);
            //p.Width = 1;
            g.DrawRectangles(p, listRec.ToArray());
            //foreach (Rectangle rec in listRec)
            //{
            //    g.DrawRectangle(p, rec);
            //}
            /*if (lesRochers.Count > 0)
            {
                foreach (Rocher roc in lesRochers)
                {
                    SetImageZoneOnGraph(roc.GetPicture(), new Size(roc.GetPosition().getPositionX(), roc.GetPosition().getPositionY()));
                }
            }
            if (hamster != null)
            {
                SetImageOnGraph(hamster, hamtaroLocation);
            }*/
            if (nbCoups > 0)
            {
                if (lesRochers.Count > 0)
                {
                    foreach (Rocher roca in lesRochers)
                    {
                        //SetImageZoneOnGraph(roca.GetPicture(), new Size(5, 7));
                        SetImageZoneOnGraph(roca.GetPicture(), new Rectangle(roca.X * 50,
                            roca.Y * 50, WEIGHT, WEIGHT));
                    }
                }
                if (gain != null)
                {
                    //Rectangle fstRect = new Rectangle(gain.X * 50, gain.Y * 50, WEIGHT, WEIGHT);
                    //SetImageZoneOnGraph(gain.GetPicture(), fstRect);-
                    SetImageZoneOnGraph(gain.GetPicture(), new Rectangle(gain.X * 50,
                            gain.Y * 50, WEIGHT, WEIGHT));
                }
                foreach (Bonus b in lesBonus)
                {
                    SetImageZoneOnGraph(b.GetPicture(), new Rectangle(b.X * 50,
                            b.Y * 50, WEIGHT, WEIGHT));
                }
                if (hamster != null)
                {

                    if (hamster.X == gain.X && hamster.Y == gain.Y)
                    {
                        ticker.Stop();
                        labyrinth.HeWin();
                    }

                    Rectangle rectangleFind = LookingForMeat();
                    if (rectangleFind.X != 1000 && rectangleFind.Y != 1000)
                    {
                        Bonus BonusASupprimer = null;
                        foreach (Bonus bon in lesBonus)
                        {
                            if ((bon.X * 50) == rectangleFind.X && (bon.Y * 50) == rectangleFind.Y)
                            {
                                BonusASupprimer = bon;
                                labyrinth.PowerUp(5);
                                nbCoups += 5;
                            }
                        }
                        lesBonus.Remove(BonusASupprimer);

                        Cheminement.Add(rectangleFind);
                        nbCoups--;
                        labyrinth.HeMoved();
                        SetImageOnGraph(hamster, rectangleFind);

                    }
                    else
                    {
                        if (first)
                        {
                            Rectangle fstRect = new Rectangle(hamster.X * 50, hamster.Y * 50, WEIGHT, WEIGHT);
                            SetImageOnGraph(hamster, fstRect);
                            first = false;
                            Cheminement.Add(fstRect);

                        }
                        else
                        {
                            Rectangle rec = listRec.Find(x => ((x.X / 50) == hamster.X) && ((x.Y / 50) == hamster.Y));

                            //Console.WriteLine("index = " + index);
                            //Rectangle rec = listRec.ElementAt(index);
                            Console.WriteLine((rec.X / 50) + " == " + hamster.X + " && " + (rec.Y / 50) + " == " + hamster.Y);
                            Random aleatoire = new Random();

                            //
                            nextStep = new List<Rectangle>();
                            List<Rectangle> nozone = listRec.Where(x => lesRochers.Any(z => ((x.X / 50) == z.X) && ((x.Y / 50) == z.Y))).ToList();
                            Rectangle sideRectangle = new Rectangle(rec.X, rec.Y - (1 * WEIGHT), WEIGHT, WEIGHT);
                            if (!nozone.Contains(sideRectangle) && sideRectangle.X >= 0 && sideRectangle.Y >= 0
                                && sideRectangle.X < 17 * WEIGHT && sideRectangle.Y < 8 * WEIGHT) //top
                            {
                                if (!Cheminement.Contains(sideRectangle))
                                    nextStep.Add(sideRectangle);
                            }
                            sideRectangle = new Rectangle(rec.X + (1 * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                            if (!nozone.Contains(sideRectangle) && sideRectangle.X >= 0 && sideRectangle.Y >= 0
                                && sideRectangle.X < 17 * WEIGHT && sideRectangle.Y < 8 * WEIGHT) //right
                            {
                                if (!Cheminement.Contains(sideRectangle))
                                    nextStep.Add(sideRectangle);
                            }
                            sideRectangle = new Rectangle(rec.X, rec.Y + (1 * WEIGHT), WEIGHT, WEIGHT);
                            if (!nozone.Contains(sideRectangle) && sideRectangle.X >= 0 && sideRectangle.Y >= 0
                                && sideRectangle.X < 17 * WEIGHT && sideRectangle.Y < 8 * WEIGHT) //down
                            {
                                if (!Cheminement.Contains(sideRectangle))
                                    nextStep.Add(sideRectangle);
                            }
                            sideRectangle = new Rectangle(rec.X - (1 * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                            if (!nozone.Contains(sideRectangle) && sideRectangle.X >= 0 && sideRectangle.Y >= 0
                                && sideRectangle.X < 17 * WEIGHT && sideRectangle.Y < 8 * WEIGHT) //left
                            {
                                if (!Cheminement.Contains(sideRectangle))
                                    nextStep.Add(sideRectangle);
                            }

                            int c = nextStep.Count;
                            Console.WriteLine("coups possible : " + c);
                            int val = -1;
                            if (c > 0)
                            {
                                if (c == 1)
                                {
                                    rec = nextStep.ElementAt(0);

                                    Bonus BonusASupprimer = null;
                                    foreach (Bonus bon in lesBonus)
                                    {
                                        if ((bon.X * 50) == rec.X && (bon.Y * 50) == rec.Y)
                                        {
                                            BonusASupprimer = bon;
                                            labyrinth.PowerUp(5);
                                            nbCoups += 5;
                                        }
                                    }
                                    lesBonus.Remove(BonusASupprimer);

                                    Cheminement.Add(rec);
                                    nbCoups--;
                                    labyrinth.HeMoved();
                                }
                                else
                                {
                                    val = aleatoire.Next(0, c);
                                    int val2 = aleatoire.Next(0, c);
                                    //if (val != val2)
                                    {
                                        rec = nextStep.ElementAt(val);

                                        Bonus BonusASupprimer = null;
                                        foreach (Bonus bon in lesBonus)
                                        {
                                            if ((bon.X * 50) == rec.X && (bon.Y * 50) == rec.Y)
                                            {
                                                BonusASupprimer = bon;
                                                labyrinth.PowerUp(5);
                                                nbCoups += 5;
                                            }
                                        }
                                        lesBonus.Remove(BonusASupprimer);

                                        Cheminement.Add(rec);
                                        nbCoups--;
                                        labyrinth.HeMoved();
                                    }
                                }
                            }
                            else
                            {
                                if (Cheminement.Count > 0)
                                {
                                    int last = Cheminement.Count - 1;
                                    rec = Cheminement.ElementAt(last);
                                    Rectangle deleteRectangle;
                                    for (int z = 0; z < 2; z++)
                                    {
                                        deleteRectangle = new Rectangle(rec.X - (z * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);
                                        deleteRectangle = new Rectangle(rec.X, rec.Y - (z * WEIGHT), WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);
                                        deleteRectangle = new Rectangle(rec.X - (z * WEIGHT), rec.Y - (z * WEIGHT), WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);

                                        deleteRectangle = new Rectangle(rec.X + (z * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);
                                        deleteRectangle = new Rectangle(rec.X, rec.Y + (z * WEIGHT), WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);
                                        deleteRectangle = new Rectangle(rec.X + (z * WEIGHT), rec.Y + (z * WEIGHT), WEIGHT, WEIGHT);
                                        Cheminement.Remove(deleteRectangle);
                                    }
                                    /*
                                    deleteRectangle = new Rectangle(rec.X - (1 * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                                    Cheminement.Remove(deleteRectangle);
                                    deleteRectangle = new Rectangle(rec.X + (1 * WEIGHT), rec.Y, WEIGHT, WEIGHT);
                                    Cheminement.Remove(deleteRectangle);
                                    deleteRectangle = new Rectangle(rec.X, rec.Y - (1 * WEIGHT), WEIGHT, WEIGHT);
                                    Cheminement.Remove(deleteRectangle);
                                    deleteRectangle = new Rectangle(rec.X, rec.Y + (1 * WEIGHT), WEIGHT, WEIGHT);
                                    Cheminement.Remove(deleteRectangle);
                                    //Cheminement.RemoveAt(last);
                                    //Cheminement.RemoveAt(last - 1);
                                     */
                                }
                            }
                            SetImageOnGraph(hamster, rec);
                        }
                    }
                }
            }
            else
            {
                GameEnd();
            }

            //g.DrawRectangles(p, listRec.ToArray());
            //g.FillRectangles(myBrush, listRec.ToArray());
            //g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            LoadLabyrinth(e.Graphics);
        }

        private void LabyrinthGraphix_Paint(PaintEventArgs e)
        {
            //LabyrinthGraphixBlack();
        }
        
        //public void SetImageOnGraph(Hamtaro h, Size s)
        public void SetImageOnGraph(Hamtaro h, Rectangle r)
        {
            //if (s.Height < 8 && s.Width < 17)
            {
                //g.FillRectangle(myBrush, listRec.Find(x => x.X == s.Width - 2 && x.Y == s.Height - 1));
                //g.DrawImage(h.GetPicture(), s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
                //gx.DrawImage(hamtaro, s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
                g.DrawImage(h.GetPicture(), r);
                h.X = r.X / 50;
                h.Y = r.Y / 50;
            }

        }

        public Rectangle LookingForMeat()
        {
            Rectangle rectangle = new Rectangle(1000, 1000, WEIGHT, WEIGHT);

            //AMELIORER LE FOREACH
            for (int i = ((hamster.X > 5) ? hamster.X : hamster.X - 5); i < hamster.X + 5; i++)
            {
                for (int j = ((hamster.Y > 5) ? hamster.Y : hamster.Y - 5); j < hamster.Y + 5; j++)
                {
                    if (gain.X == i && gain.Y == j)
                    {
                        Console.WriteLine(gain.X + " == " + i + " && " + gain.Y + " == " + j);
                        rectangle.X = i;
                        rectangle.Y = j;
                        Console.WriteLine("Plus proche trouvé");
                    }
                }
            }
            if (rectangle.X != 1000 && rectangle.Y != 1000)
            {
                int xval;
                int yval;
                if (hamster.X < gain.X)
                    xval = gain.X - hamster.X;
                else
                    xval = hamster.X - gain.X;

                if (hamster.Y < gain.Y)
                    yval = gain.Y - hamster.Y;
                else
                    yval = hamster.Y - gain.Y;

                //if (xval < yval)
                if (xval > yval)
                {
                    bool canMoveHorizontaly = true;
                    Rectangle nextRectangle = new Rectangle((hamster.X + 1) * WEIGHT, hamster.Y * WEIGHT, WEIGHT, WEIGHT);
                    foreach (Rocher r in lesRochers)
                    {
                        if (nextRectangle.X == r.X && nextRectangle.Y == r.Y)
                        {
                            canMoveHorizontaly = false;
                        }
                    }
                    if (canMoveHorizontaly)
                        rectangle = nextRectangle;
                }
                else
                {
                    bool canMoveVericaly = true;
                    Rectangle nextRectangle = new Rectangle(hamster.X * WEIGHT, (hamster.Y + 1) * WEIGHT, WEIGHT, WEIGHT);
                    foreach (Rocher r in lesRochers)
                    {
                        if (nextRectangle.X == r.X && nextRectangle.Y == r.Y)
                        {
                            canMoveVericaly = false;
                        }
                    }
                    if (canMoveVericaly)
                        rectangle = nextRectangle;
                }
                    
            }
            return rectangle;
        }

        public void Pause()
        {
            if (ticker.Enabled)
                ticker.Enabled = false;
            else
                ticker.Enabled = true;
        }

        public void GameEnd()
        {
            ticker.Stop();
            MessageBox.Show("Hamtaro est mort de faim..",
            "Perdu !");
        }

        //public void SetImageZoneOnGraph(Image img, Size s)
        public void SetImageZoneOnGraph(Image img, Rectangle r)
        {
            //if (s.Height < 8 && s.Width < 17)
            {
                //g.FillRectangle(myBrush, listRec.Find(x => x.X == s.Width - 2 && x.Y == s.Height - 1));
                //g.DrawImage(img, s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
                //gx.DrawImage(img, s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
                g.DrawImage(img, r);
            }

        }

        private void LabyrinthGraphix_Load(object sender, EventArgs e)
        {

            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);

            //InitializeComponent();
            ticker.Interval = 600;
            ticker.Tick += new EventHandler(T_ticker);

            if(g == null)
                g = this.CreateGraphics();

            ticker.Start();
        }

        void T_ticker(Object sender, EventArgs e)
        {
            this.Invalidate();
            //SeDeplacer();
        }

        //public void SeDeplacer()
        //{
            
        //    //LoadLabyrinth();
        //    if (hamtaroLocation.Width + 2 < 17 && hamtaroLocation.Height + 1 < 8)
        //    {
        //        if (g != null)
        //        {
        //            //g.Clear(System.Drawing.Color.White);
        //            hamtaroOldLocation = hamtaroLocation;
        //            ClearRectangle(hamtaroOldLocation);
        //        }
        //        hamtaroLocation.Width += 2;
        //        hamtaroLocation.Height += 1;
        //    }
        //}

        // Clear all blocks in specified line. 
        private void ClearRectangle(Size s)
        {
            this.Invalidate();
            //Invalidate(new Rectangle(new Point(s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING), new Size(40, 40)));
        }

    }
}
