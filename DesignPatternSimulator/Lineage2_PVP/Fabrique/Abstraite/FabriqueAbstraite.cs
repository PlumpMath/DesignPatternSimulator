using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    internal abstract class FabriqueAbstraite
    {
        public abstract PersonnageAbstrait CreerPersonnage(String unNom);
    }
}
