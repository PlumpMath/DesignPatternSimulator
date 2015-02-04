using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.Views.Damier
{
    public partial class LabyrinthGraphix : UserControl
    {
        public List<Rectangle> listRec = new List<Rectangle>();
        Graphics g;

        public LabyrinthGraphix()
        {
            InitializeComponent();
            Rectangle rect = new Rectangle();
            rect.Size = new Size(50, 50);
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
            g = this.CreateGraphics();
            p.Width = 3;
            foreach (Rectangle rec in listRec)
            {
                g.DrawRectangle(p, rec);
            }

            //g.DrawRectangles(p, listRec.ToArray());
            //g.FillRectangles(myBrush, listRec.ToArray());
            g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            LoadLabyrinth();
        }

        private void LabyrinthGraphix_Paint(PaintEventArgs e)
        {
            LoadLabyrinth();
        }

        private void LabyrinthGraphix_Load(object sender, EventArgs e)
        {
            //LoadLabyrinth();
        }

    }
}
