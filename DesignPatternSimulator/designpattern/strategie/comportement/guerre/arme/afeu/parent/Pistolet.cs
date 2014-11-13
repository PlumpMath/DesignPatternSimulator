using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent
{

    public class Pistolet : ArmeAFeu
    {

        public Pistolet(string nom, int imp, int nbBullet, int nbRecharge)
            : base(nom, imp, nbBullet, nbRecharge)
        {

        }

        /*
        public override int getNumberOfRecharge()
        {

            return base.getNumberOfRecharge();
        }

        public override int getNumberOfBullet()
        {
            return base.getNumberOfBullet();
        }

        public override string getName()
        {
            return base.GetName();
        }

        public override int getImpact()
        {
            return base.GetImpact();
        }
        */
    }
}