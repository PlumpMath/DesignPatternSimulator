using DesignPatternSimulator.designpattern.strategie.comportement.dame.deplacement;
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
        protected internal StatusAbstrait state;
        public StatusAbstrait()
        {

        }
        public StatusAbstrait(StatusAbstrait status)
        {
            state = status;
        }

        protected AvancerAbstract deplacement;
        
        //public abstract void ModifierEtat(Pion personnage);

        //public abstract void SeDeplacer();


    }
}
