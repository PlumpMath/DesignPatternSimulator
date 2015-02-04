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
        public Labyrinthe()
        {
            InitializeComponent();
        }

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
            rect.Size = new Size(25, 25);
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
        }
    }
}
