using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.environnement.parent;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre
{
    public class FactoryDeJeuGuerre : AbstractFabriqueDeJeu
    {

        public FactoryDeJeuGuerre()
            : base()
        {

        }

        public override EnvironnementDeJeu CreateEnvironnementDeJeu(EnvironnementDeJeu world)
        {
            return null;
        }

        public override AbstractZone CreateZone(int x, int y)
        {
            return new Zone(x, y);
        }

        public override AbstractZone CreateZone(string nom, int x, int y)
        {
            return new Zone(nom, x, y);
        }

        public override AbstractAcces CreateAcces(Zone z1, Zone z2)
        {
            return new Acces(z1, z2);
        }

        public List<AbstractZone> CreateCarre(int longeur, int largeur)
        {
            List<Acces> environnement = new List<Acces>();
            List<AbstractZone> zones = null;

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longeur; j++)
                {
                    zones = new List<AbstractZone>();
                    zones.Add(new Zone(i + ":" + j, i, j));
                }
            }

            return zones;
        }

        /*
        public List<Acces> CreateCarre(int longeur, int largeur)
        {
            List<Acces> environnement = new List<Acces>();
            List<Zone> zones = null;

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longeur; j++)
                {
                    zones = new List<Zone>();
                    zones.Add(new Zone(i + ":" + j, i, j));
                }
            }

            return environnement;
        }
         */
    }
}