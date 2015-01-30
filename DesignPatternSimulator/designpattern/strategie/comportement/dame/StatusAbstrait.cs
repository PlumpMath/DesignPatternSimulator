using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame
{
    public abstract class StatusAbstrait
    {
        public abstract void ModifierEtat(Personnage personnage);
    }
}
