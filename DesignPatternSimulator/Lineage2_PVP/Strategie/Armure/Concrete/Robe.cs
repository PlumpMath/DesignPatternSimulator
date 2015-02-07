using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class Robe : ArmureAbstraite
    {
        public Robe()
        {
            base.Nom = EnumArmure.Robe.ToString();
            base.PDef = 4000;
        }
    }
}
