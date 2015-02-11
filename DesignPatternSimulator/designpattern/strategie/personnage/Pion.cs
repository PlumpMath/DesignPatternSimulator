using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.dame;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.manger;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.status;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Pion : Personnage
    {
        private Color color;
        public int PionManger { get; set; }
        public Color Color { get { return color; } set { color = value; } }

        private ZonePion position;
        public Manger comportementManger = null;
        public Manger ComportementManger { get { return comportementManger; } set { comportementManger = value; } }
        private AvancerAbstract avancer = new Avancer();

        protected StatusAbstrait statusCourant;
        public StatusAbstrait StatusCourant {
            get { return statusCourant; }
            set { statusCourant = value; }
        }
        public ZonePion Position { get { return position; } set { position = value; } }

        public Pion(Organisation org, String nom,ZonePion zone) : base(org,nom)
        {
            comportementManger = null;
            avancer = new Avancer();
            this.position = zone;
            statusCourant = new PionNonDouble();
        }

        public Pion(Organisation org, String nom)
            : base(org, nom)
        {
            comportementManger = null;
            statusCourant = new PionNonDouble();   
        }



        public void ZoneVersZone(ZonePion a)
        {
            avancer.ZoneVersZone(this,a);
        }
        public void Avancer(int x)
        {
            if(StatusCourant == new PionNonDouble() && x>1){
                x = 1;
                avancer.Avance(this, x);
            }
            else if (StatusCourant == new PionDouble())
            {
                this.avancer.Avance(this, x);
            }
        }


        public void AvancerManuellement(int x, int y)
        {
            if (StatusCourant == new PionNonDouble() && x > 1 && y > 1)
            {
                x = 1;
                y = 1;
                avancer.AvancerManuel(this, x, y);
            }
            else if (StatusCourant == new PionDouble())
            {
                this.avancer.AvancerManuel(this, x, y);
            }
        }



        public void Reculer(int x)
        {
            if (StatusCourant == new PionNonDouble() && x > 1)
            {
                x = 1;
                avancer.Recule(this, x);
            }
            else if (StatusCourant == new PionDouble())
            {
                avancer.Recule(this, x);
            }
        }


        public void ChangeState(typeEtat etat)
        {
            switch (etat)
            {
                case typeEtat.doublette:
                    statusCourant = new PionDouble();
                    break;
                case typeEtat.normal:
                    statusCourant = new PionNonDouble();
                    break;
            }
        }

    }
}
