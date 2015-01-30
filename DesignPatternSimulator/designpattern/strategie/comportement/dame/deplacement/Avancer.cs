using DesignPatternSimulator.designpattern.environnement.style;
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
        public override void Avance( int i)
        {
            pos.setPositionY(pos.getPositionY() + i);
            pos.setPositionX(pos.getPositionY() + i);
        }

        public override void Recule(int i)
        {
            pos.setPositionY(pos.getPositionY() - i);
            pos.setPositionX(pos.getPositionY() - i);
        }
    }
}
