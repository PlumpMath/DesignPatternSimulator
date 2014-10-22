using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu
{
    public abstract class AbstractFabriqueDeJeu
    {

        public AbstractFabriqueDeJeu()
        {

        }

        public abstract AbstractZone CreateZone(string nom);

        public abstract AbstractAcces CreateAcces(Zone z1, Zone z2);
    }
}