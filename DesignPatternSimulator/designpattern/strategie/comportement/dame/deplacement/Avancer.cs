using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.strategie.comportement.dame.status;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement
{
    public class Avancer : AvancerAbstract
    {
        private Position pos;

        private ZonePion position;



        

        public override ZonePion Avance(int i)
        {
            position.X = position.X + i;
            position.Y = position.Y + i;
            //pos.setPositionY(pos.getPositionY() + i);
            //pos.setPositionX(pos.getPositionY() + i);

            return position;
        }

        public override ZonePion Recule(int i)
        {
            position.X = position.X + i;
            position.Y = position.Y + i;
            //pos.setPositionY(pos.getPositionY() - i);
            //pos.setPositionX(pos.getPositionY() - i);

            return position;
        }

        public override ZonePion AvancerManuel(int x, int y)
        {
            position.X = position.X + x;
            position.Y = position.Y + y;
            return position;
        }

        public override void AvancerManuel(Pion pion, int x, int y)
        {
            pion.Position.Occupe = false;
            pion.Position = this.AvancerManuel(x, y);
            pion.Position.Occupe = true;
        }

        public override void Recule(Pion pion, int i)
        {
            pion.Position.Occupe = false;
            pion.Position = this.Recule(i);
            pion.Position.Occupe = true;
        }

        public override void Avance(Pion pion, int i)
        {
            pion.Position.Occupe = false;
            pion.Position = this.Avance(i);
            pion.Position.Occupe = true;
        }

        public override void Sauter(Pion pionA, Pion pionB)
        {
            if (pionA.StatusCourant == new PionNonDouble())
            {

            }
        }

        public override void ZoneVersZone(Pion pion, ZonePion zonePi)
        {
            pion.Position.Occupe = false;
            pion.Position = zonePi;
            zonePi.Occupe = true;
        }
    }
}
