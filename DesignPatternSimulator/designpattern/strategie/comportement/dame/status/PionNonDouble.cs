using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.status
{
    public class PionNonDouble : StatusAbstrait
    {
        public override void ModifierEtat(Personnage personnage)
        {
            //personnage.EtatCourant = new PionNonDouble();
        }
    }
}
