using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.fabrique.plateaudejeu.dame
{
    public class FactoryDame : AbstractFabriqueDeJeu
    {
        public override EnvironnementDeJeu CreateEnvironnementDeJeu(EnvironnementDeJeu world)
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


        //public List<AbstractZone> CreateCarre(int longeur, int largeur)
        //{
        //    List<Acces> environnement = new List<Acces>();
        //    List<AbstractZone> zones = null;

        //    for (int i = 0; i < largeur; i++)
        //    {
        //        for (int j = 0; j < longeur; j++)
        //        {
        //            zones = new List<AbstractZone>();
        //            zones.Add(new Zone(i + ":" + j, i, j));
        //        }
        //    }

        //    return zones;
        //}


        /*
         * Création des zones du damiers
         **/
         
        public List<ZonePion> CreateCarre(int p1, int p2)
        {
            ZonePion p = new ZonePion(); 
            List<ZonePion> zones = new List<ZonePion>();
            
            for (int i = 1; i <= p2; i++)
            {
                for (int j = 1; j <= p1; j++)
                {
                    //zones = new List<ZonePion>();
                    zones.Add((ZonePion)(p.CreerZone(null, i, j)));
                }
            }

            return zones;
        }


    }
}
