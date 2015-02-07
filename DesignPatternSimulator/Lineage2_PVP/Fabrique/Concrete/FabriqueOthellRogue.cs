using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class FabriqueOthellRogue : FabriqueAbstraite
    {
        public override PersonnageAbstrait CreerPersonnage(String unNom)
        {
            return new OthellRogue(unNom);
        }
    }
}
