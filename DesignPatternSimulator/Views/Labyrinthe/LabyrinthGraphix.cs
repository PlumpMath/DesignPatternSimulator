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
        Graphics g;
        Image hamtaro = Image.FromFile(@"C:\Users\Mamadou\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\p1.jpg");
        Size hamtaroLocation = new Size(2, 0); //personnage
        Image tresor = Image.FromFile(@"");
        Size tresorLocation = new Size(13, 6); //zone
        //tout le reste est aussi composé de zones
        //Pépites..

        Timer ticker = new Timer();

        public LabyrinthGraphix()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Rectangle rect = new Rectangle();
            hamtaro = (Image)(new Bitmap(hamtaro, new Size(IMG_SIZE, IMG_SIZE)));

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
        }

        public void LoadLabyrinth()
        {
            System.Drawing.SolidBrush myBrush;
            myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);

            Pen p = new Pen(Color.Black);
            p.Width = 3;
            foreach (Rectangle rec in listRec)
            {
                g.DrawRectangle(p, rec);
            }

            SetImageOnGraph(g, hamtaroLocation);
            //g.DrawRectangles(p, listRec.ToArray());
            //g.FillRectangles(myBrush, listRec.ToArray());
            //g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //LoadLabyrinth();
        }

        private void LabyrinthGraphix_Paint(PaintEventArgs e)
        {
            //LoadLabyrinth();
        }

        public void SetImageOnGraph(Graphics gx, Size s)
        {
            if (s.Height < 8 && s.Width < 17)
            {
                gx.DrawImage(hamtaro, s.Width * WEIGHT + IMG_PADDING, s.Height * WEIGHT + IMG_PADDING);
            }

        }

        private void LabyrinthGraphix_Load(object sender, EventArgs e)
        {
            ticker.Interval = 1000;
            ticker.Tick += new EventHandler(T_ticker);
            ticker.Start();
        }

        void T_ticker(Object sender, EventArgs e)
        {
            if (g != null)
            {
                g.Clear(System.Drawing.Color.White);
            }
            LoadLabyrinth();
            Size s = hamtaroLocation;
            if (hamtaroLocation.Width + 2 < 17 && hamtaroLocation.Height + 1 < 8)
            {
                hamtaroLocation.Width += 2;
                hamtaroLocation.Height += 1;
            }

        }

    }
}
