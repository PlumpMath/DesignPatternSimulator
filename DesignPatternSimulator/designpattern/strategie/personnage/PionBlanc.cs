using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.dame;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.status;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class PionBlanc : Pion
    {
        public Avancer avancer;
        private Color couleur;
        public Color Couleur { get { return couleur; } set { couleur = value; } }
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
                pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png";
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public PionBlanc(Organisation org, String nom, ZonePion zone)
            : base(org, nom)
        {
            position = zone;
            couleur = Color.White;
        }

        public PionBlanc(Organisation org, String nom)
            : base(org, nom)
        {
            
        }


        new public void Avancer(int x)
        {
            if (StatusCourant == new PionNonDouble() && x > 1)
            {
                x = 1;
                this.avancer.Avance(this, x);
            }
            else if (StatusCourant == new PionDouble())
            {
                this.avancer.Avance(this, x);
            }
        }


        new public void Reculer(int x)
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
