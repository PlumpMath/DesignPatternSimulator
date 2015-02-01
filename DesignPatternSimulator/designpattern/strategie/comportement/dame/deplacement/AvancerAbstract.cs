using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement
{
    public abstract class AvancerAbstract
    {
        public abstract void Avance(Pion pion, int i);
        public abstract void Recule(Pion pion, int i);
        public abstract void Sauter(Pion pionA, Pion pionB);
        public abstract ZonePion Avance(int i);
        public abstract ZonePion Recule(int i);
    }
}
 