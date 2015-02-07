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

namespace DesignPatternSimulator.Views.Damier
{
    public partial class LabyrinthGraphix : UserControl
    {
        public static int WEIGHT = 50;
        public static int IMG_SIZE = 40;
        public static int IMG_PADDING = 5;

        FabriqueManagerLabyrinth fmLabyrinth;

        public List<Rectangle> listRec = new List<Rectangle>();
        Graphics g = null;
        Graphics gx;
        Image hamtaro = Image.FromFile(@"C:\Users\Mamadou\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\p1.jpg");
        Size hamtaroLocation = new Size(2, 0); //personnage
        Size hamtaroOldLocation = new Size(2,0);
        //Image tresor = Image.FromFile(@"");
        Size tresorLocation = new Size(13, 6); //zone
        //tout le reste est aussi composé de zones
        //Pépites..
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

        Timer ticker = new Timer();
        Timer waiter = new Timer();
        Bitmap bmp;

        public LabyrinthGraphix()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            //hamtaro = (Image)(new Bitmap(hamtaro, new Size(IMG_SIZE, IMG_SIZE)));


            /*
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
             */
            //Pen p = new Pen(Color.Transparent);
            //g.DrawRectangles(p, listRec.ToArray());

            //bmp = new Bitmap(894, 450, g);
        }

        public void LoadLabyrinth()
        {

            Pen p = new Pen(Color.Black);
            p.Width = 3;
            g.DrawRectangles(p, listRec.ToArray());
            //foreach (Rectangle rec in listRec)
            //{
            //    g.DrawRectangle(p, rec);
            //}

            SetImageOnGraph(g, hamtaroLocation);
            //g.DrawRectangles(p, listRec.ToArray());
            //g.FillRectangles(myBrush, listRec.ToArray());
            //g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            LoadLabyrinth();
        }

        private void LabyrinthGraphix_Paint(PaintEventArgs e)
        {
            //LabyrinthGraphixBlack();
        }

        public void SetImageOnGraph(Graphics gx, Size s)
        {
            if (s.Height < 8 && s.Width < 17)
            {
                //g.FillRectangle(myBrush, listRec.Find(x => x.X == s.Width - 2 && x.Y == s.Height - 1));
                listRec.Find(x => x.X == s.Width - 2 && x.Y == s.Height - 1);
                gx.DrawImage(hamtaro, s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
            }

        }

        private void LabyrinthGraphix_Load(object sender, EventArgs e)
        {

            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);

            //InitializeComponent();
            ticker.Interval = 2000;
            ticker.Tick += new EventHandler(T_ticker);

            if(g == null)
                g = this.CreateGraphics();
            hamtaro = (Image)(new Bitmap(hamtaro, new Size(IMG_SIZE, IMG_SIZE)));

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
            Pen p = new Pen(Color.Black);
            g.DrawRectangles(p, listRec.ToArray());

            bmp = new Bitmap(894, 450, g);

            ticker.Start();
        }

        void T_ticker(Object sender, EventArgs e)
        {

            if (g != null)
            {
                //g.Clear(System.Drawing.Color.White);
                ClearRectangle(hamtaroOldLocation);
            }
            hamtaroOldLocation = hamtaroLocation;
            //LoadLabyrinth();
            if (hamtaroLocation.Width + 2 < 17 && hamtaroLocation.Height + 1 < 8)
            {
                hamtaroLocation.Width += 2;
                hamtaroLocation.Height += 1;
            }
        }

        void T_waiter(Object sender, EventArgs e)
        {

        }

        // Clear all blocks in specified line. 
        private void ClearRectangle(Size s)
        {
            Invalidate(new Rectangle(new Point(s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING),
                       new Size(40, 40)));
        }

    }
}
