using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.status
{
    public class PionDouble : StatusAbstrait
    {
        public override void ModifierEtat(Personnage personnage)
        {
            //personnage.EtatCourant = new PionDouble();
        }
    }
}
