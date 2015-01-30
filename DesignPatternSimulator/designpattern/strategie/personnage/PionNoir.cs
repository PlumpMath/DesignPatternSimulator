using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.dame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class PionNoir : Personnage
    {
        private Zone position;
        public Zone Position;
        private PictureBox pic;
        public PictureBox Pic
        {
            get { return pic; }
            set
            {
                pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png";
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public PionNoir(Organisation org, String nom, Zone zone)
            : base(org, nom)
        {
            position = zone;
        }

        public PionNoir(Organisation org, String nom)
            : base(org, nom)
        {
        }


    }
}
