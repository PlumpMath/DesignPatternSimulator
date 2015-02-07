using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class BoucleOreille : BijouAbstrait
    {
        public BoucleOreille()
        {
            base.Nom = EnumBijou.BoucleOreille.ToString();
            base.MDef = 1000;
        }
    }
}
