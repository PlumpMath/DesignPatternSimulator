using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style.parent
{
    public abstract class AbstractAcces
    {
        public abstract AbstractAcces CreerAcces(AbstractZone premiereZone, AbstractZone deuxiemeZone);
    }
}