using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.environnement
{
    public class Frontiere : Acces
    {
        public Frontiere() { }

        public Frontiere(AbstractZone z1, AbstractZone z2)
        {
            base.CreerAcces(z1, z2);
            // TODO Auto-generated constructor stub
        }

    }
}