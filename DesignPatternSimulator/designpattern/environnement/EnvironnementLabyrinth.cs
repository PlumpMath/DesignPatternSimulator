using DesignPatternSimulator.designpattern.environnement.parent;
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
        private PlateauDeJeuDame plateau;
        public PlateauDeJeuDame Plateau {
            get { 
                return plateau;
            }
            set { 
                plateau = value;
            }
        }

        public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique)
        {
            PlateauDeJeuDame monLabyrinth = new PlateauDeJeuDame();
            FactoryLabyrinth factory = new FactoryLabyrinth();

            List<AbstractZone> terrain = new List<AbstractZone>();
            terrain = factory.CreateLabyrinthSpace17x8();
            monLabyrinth.setZonesAcces(terrain);

            plateau = monLabyrinth;
            return plateau;
        }

        public override AbstractPlateauDeJeu GetPlateauDeJeu()
        {
            return plateau;
        }

        public void PlacerLesObjectsDansLabyrinth17x8(List<Personnage> perso, Labyrinthe laby)
        {
            var listezone = laby.getZonesAcces();// damier.getZonesAcces();
            
            foreach (AbstractZone z in listezone)
            {
                
            }
        }
    }
}
