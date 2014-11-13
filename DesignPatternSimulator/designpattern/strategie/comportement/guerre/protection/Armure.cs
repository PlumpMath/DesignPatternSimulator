using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.protection
.parent;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.protection
{
    public class Armure : AbstractProtection
    {
        private int resistance;

        public Armure(int r)
        {
            this.resistance = r;
        }

        public override int getResistance()
        {
            return resistance;
        }

    }
}