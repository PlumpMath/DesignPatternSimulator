using DesignPatternSimulator.designpattern.environnement.style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Hamtaro : Personnage
    {
        public Position position;
        Position anciennePosition;
        public static int IMG_SIZE = 40; 
        string Picture;
        public int X;
        public int Y;
        Image img;

        public Hamtaro(string sonNom)
            : base(null, sonNom, null)
        {
            Picture = @"C:\Users\" + Environment.UserName + @"\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\p1.jpg";
            img = (Image)(new Bitmap(Image.FromFile(Picture), new Size(IMG_SIZE, IMG_SIZE)));
        }

        public Image GetPicture()
        {
            return img;
        }
    }
}
