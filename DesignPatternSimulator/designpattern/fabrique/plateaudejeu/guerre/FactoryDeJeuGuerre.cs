using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre
{
    public class FactoryDeJeuGuerre : AbstractFabriqueDeJeu
    {

        public FactoryDeJeuGuerre()
            : base()
        {

        }

        public override AbstractZone CreateZone(string nom)
        {
            return new Zone(nom);
        }

        public override AbstractAcces CreateAcces(Zone z1, Zone z2)
        {
            return new Acces(z1, z2);
        }

        public List<Acces> CreateCarre(int longeur, int largeur)
        {
            List<Acces> environnement = new List<Acces>();
            List<Zone> zones = null;

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < longeur; j++)
                {
                    zones = new List<Zone>();
                    zones.Add(new Zone(i + ":" + j));
                }
            }
            int ligne = 0;
            int saut = largeur;

            for (int j = 0; j < largeur; j++)
            {
                for (int i = 1; i < saut; i++)
                {
                    environnement.Add(new Acces(zones.ElementAt(ligne + i - 1), zones.ElementAt(ligne + i)));
                    environnement.Add(new Acces(zones.ElementAt(ligne + i - 1), zones.ElementAt(saut + i - 1)));
                }

                ligne += largeur;
                saut += largeur;
            }

            return environnement;
        }
    }
}