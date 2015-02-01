using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement
{
    class Avancer : AvancerAbstract
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

        public override void Recule(Pion pion, int i)
        {
            pion.Position = Recule(i);
        }

        public override void Avance(Pion pion, int i)
        {
            pion.Position = Avance(i);
        }

        public override void Sauter(Pion pionA, Pion pionB)
        {
            throw new NotImplementedException();
        }
    }
}
