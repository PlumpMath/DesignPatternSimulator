using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.Views.Labyrinthe
{
    public partial class Labyrinthe : Form
    {
        LabyrinthGraphix lab;

        public Labyrinthe()
        {
            InitializeComponent();
            int nb = 10;
            //LabyrinthGraphix lab = new LabyrinthGraphix(this);
            //lab = new LabyrinthGraphix(this, nb);
            //LabyrinthGraphix lab = new LabyrinthGraphix();
            lblNBcoupsValue.Text = nb.ToString();
            Labyr.Controls.Add(lab);


        }

        public Labyrinthe(int coups, int facilite)
        {
            InitializeComponent();
            int nb = coups;
            //LabyrinthGraphix lab = new LabyrinthGraphix(this);
            //lab = new LabyrinthGraphix(this, nb);
            lab = new LabyrinthGraphix(this, nb, facilite);
            //LabyrinthGraphix lab = new LabyrinthGraphix();
            lblNBcoupsValue.Text = nb.ToString();
            Labyr.Controls.Add(lab);


        }

        public void HeMoved()
        {
            int nb = int.Parse(lblNBcoupsValue.Text);
            nb--;
            lblNBcoupsValue.Text = nb.ToString();
        }

        public void HeWin()
        {
            MessageBox.Show("Vous avez trouvé la mine de graine de tournesol..",
            "Bravo !");
        }

        public void PowerUp(int i)
        {
            int nb = int.Parse(lblNBcoupsValue.Text);
            nb += i;
            lblNBcoupsValue.Text = nb.ToString();
        }

        private void btnPause_MouseClick(object sender, MouseEventArgs e)
        {
            lab.Pause();
        }

        
        /*
        public List<Rectangle> listeRectangles = new List<Rectangle>();

        private void Labyrinthe_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);

            using (Graphics g = this.painter1.CreateGraphics())
            {
                g.DrawRectangles(pen, LoadLabyrinthe().ToArray());
            }
        }

        public List<Rectangle> LoadLabyrinthe()
        {
            Rectangle rect = new Rectangle();
            rect.Size = new Size(50, 50);
            for (int x = 0; x < 10; x++)
            {
                rect.X = x * rect.Width;
                for (int y = 0; y < 8; y++)
                {
                    rect.Y = y * rect.Height;
                    listeRectangles.Add(rect);
                }
            }

            return listeRectangles;
        }*/
    }
}
