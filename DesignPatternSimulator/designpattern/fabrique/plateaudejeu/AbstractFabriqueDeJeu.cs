using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu
{
    public abstract class AbstractFabriqueDeJeu
    {

        public AbstractFabriqueDeJeu()
        {

        }

        //public abstract AbstractZone CreateZone(string nom);

        public abstract EnvironnementDeJeu CreateEnvironnementDeJeu(EnvironnementDeJeu world);

        public abstract AbstractZone CreateZone(int x, int y);

        public abstract AbstractZone CreateZone(string nom, int x, int y);

        public abstract AbstractAcces CreateAcces(Zone z1, Zone z2);
    }
}