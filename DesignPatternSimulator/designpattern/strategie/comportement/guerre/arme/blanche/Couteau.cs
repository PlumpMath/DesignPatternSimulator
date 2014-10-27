using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.blanche
{
    class Couteau : Arme
    {
        public Couteau(string nom, int imp)
            : base(nom, imp)
        {

        }

        public string GetNameOfWeapon()
        {
            return base.Name;
        }
    }
}
