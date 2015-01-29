using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.style;


namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu.football
{
    public class FactoryDeRencontre : AbstractFabriqueDeJeu
    {
        public override EnvironnementDeJeu CreateEnvironnementDeJeu(EnvironnementDeJeu world)
        {
            throw new NotImplementedException();
        }

        public override AbstractZone CreateZone(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override AbstractZone CreateZone(string nom, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override AbstractAcces CreateAcces(Zone z1, Zone z2)
        {
            throw new NotImplementedException();
        }
    }
}
