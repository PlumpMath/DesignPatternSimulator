using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class Zariche : ArmeAbstraite
    {
        public Zariche()
        {
            base.Nom = EnumArme.Zariche.ToString();
            base.PAtk = 10000;
            base.MAtk = 10000;
        }
    }
}
