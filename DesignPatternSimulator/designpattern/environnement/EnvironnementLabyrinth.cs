using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.labyrinth;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement
{
    class EnvironnementLabyrinth : EnvironnementDeJeu
    {
        Labyrinthe monLabyrinth;
        Personnage hamster;
        List<Zone> terrain;

        private Labyrinthe plateau;
        public Labyrinthe Plateau
        {
            get
            {
                return plateau;
            }
            set
            {
                plateau = value;
            }
        }

        //public EnvironnementLabyrinth(Hamtaro p)
        //{
        //    hamster = p;
        //}

        //public override AbstractPlateauDeJeu CreerPlateauDeJeu()
        public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique)
        {
            monLabyrinth = new Labyrinthe();
            //FactoryLabyrinth factory = new FactoryLabyrinth();
            FactoryLabyrinth factory = (FactoryLabyrinth)fabrique;

            terrain = new List<Zone>();
            terrain = factory.CreateLabyrinthSpace17x8();
            monLabyrinth.setZones(terrain);

            plateau = monLabyrinth;
            return plateau;
        }

        public override AbstractPlateauDeJeu GetPlateauDeJeu()
        {
            return plateau;
        }

        public List<Zone> GetTerrain()
        {
            return terrain;
        }

        /*public void CreerLabyrinth17x8()
        {
            for(int i = 0; i < 17; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    monLabyrinth.AjouterZone(new Zone(i, j));
                }
            }
        }*/

        public List<Zone> PlacerLesObjectsDansLabyrinth17x8()
        {
            var listezone = monLabyrinth.getZones();
            var random = new Random();

            /*foreach (AbstractZone z in listezone)
            {
                
            }*/
            Zone zona;
            Rocher r = new Rocher();
            Rocher r2 = new Rocher();

            zona = (Zone)listezone.ElementAt(2);
            r.X = zona.X;
            r.Y = zona.Y;
            listezone.Insert(2, r);

            zona = (Zone)listezone.ElementAt(30);
            r2.X = zona.X;
            r2.Y = zona.Y;
            listezone.Insert(30, r2);

            zona = (Zone)listezone.ElementAt(11);
            zona.SetPersonnage(hamster);
            listezone.Insert(11, zona);

            return listezone;
        }
    }
}
