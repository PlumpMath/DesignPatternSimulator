using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu.labyrinth
{
    class FactoryLabyrinth : AbstractFabriqueDeJeu
    {
        public override EnvironnementDeJeu CreateEnvironnementDeJeu(environnement.parent.EnvironnementDeJeu world)
        {
            throw new NotImplementedException();
        }

        public override AbstractZone CreateZone(int x, int y)
        {
            return new ZonePion(x, y);
        }

        public override AbstractZone CreateZone(string nom, int x, int y)
        {
            return new ZonePion(nom, x, y);
        }

        public override AbstractAcces CreateAcces(Zone z1, Zone z2)
        {
            return new Acces(z1, z2);
        }

        public List<Zone> CreateLabyrinthSpace17x8()
        {
            List<Zone> zones = new List<Zone>();
            
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 8 ; j++)
                {
                    //zones = new List<ZonePion>();
                    zones.Add(new Zone(i, j));
                }
            }

            return zones;
        }
    }
}
