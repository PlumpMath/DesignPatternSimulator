using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    class Tresor : Zone
    {
        public static string image = @"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\gain.jpg";
        public static int IMG_SIZE = 40;

        public Tresor(int x, int y)
            : base(x, y)
        {

        }

        public Tresor()
        {
            // TODO: Complete member initialization
        }

        public void changePosition(int x, int y)
        {
            base.X = x;
            base.Y = y;
        }

        public Image GetPicture()
        {
            return (Image)(new Bitmap(Image.FromFile(image), new Size(IMG_SIZE, IMG_SIZE)));
        }
    }
}
