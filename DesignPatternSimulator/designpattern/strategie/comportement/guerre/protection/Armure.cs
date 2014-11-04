using DesignPatternSimulator.designpattern.strategie.comportement.guerre.protection.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.protection
{
    class Armure : AbstractProtection
    {
        private int resistance;

        public Armure(int r)
        {
            this.resistance = r;
        }

        public int getResistance()
        {
            return resistance;
        }

    }
}
