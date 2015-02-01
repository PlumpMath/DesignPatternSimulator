using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.dame;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class PionNoir : Pion
    {
        private AvancerAbstract avancer;
        
        private ZonePion position;
        public ZonePion Position {
            get { return position; }
            set { position = value; }
        }
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
        public PionNoir(Organisation org, String nom, ZonePion zone)
            : base(org, nom)
        {
            Position = zone;
        }

        public PionNoir(Organisation org, String nom)
            : base(org, nom)
        {
        }

        public void Avancer(int x)
        {
            if (StatusCourant. == new PionNonDouble() && x > 1)
            {
                x = 1;
                avancer.Avance(this, x);
            }
            else if (statusCourant == new PionDouble())
            {
                avancer.Avance(this, x);
            }
        }


        public void Reculer(int x)
        {
            if (StatusCourant == new PionNonDouble() && x > 1)
            {
                x = 1;
                avancer.Recule(this, x);
            }
            else if (statusCourant == new PionDouble())
            {
                avancer.Recule(this, x);
            }
        }


    }
}
