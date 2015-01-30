using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.dame;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.designpattern.environnement
{
    public class EnvironnementDame : EnvironnementDeJeu
    {
        public PlateauDeJeu plateau { get; set; }

        public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique)
        {
            PlateauDeJeu damier = new PlateauDeJeu();
            FactoryDame factory = new FactoryDame();

            IEnumerable<AbstractZone> caseDamier = new List<ZonePion>();
            caseDamier = factory.CreateCarre(10, 10);
            damier.setZoneFree(caseDamier);

            plateau = damier;
            return plateau;
        }

        public override AbstractPlateauDeJeu GetPlateauDeJeu()
        {
            return plateau;
        }


        public void PlacerLesPions(List<Personnage> perso, TableLayoutPanel pa)
        {

        }

        //méthode reussie
        public void PlacerLesPions(List<Personnage> perso, PlateauDeJeu damier)
        {
            var listezone = damier.getZoneFree();// damier.getZonesAcces();
            foreach (ZonePion z in listezone)
            {
                foreach (var p in perso)
                {

                    if (p.GetType().Equals("PionBlanc"))
                    {
                        if (z.Y < 4 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            p.Emplacement = z;
                        }
                        else if (z.Y < 4 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Emplacement = z;
                        }
                    }
                    else if (p.GetType().Equals("PionNoir"))
                    {
                        if (z.Y > 5 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Emplacement = z;
                        }
                        else if (z.Y > 5 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            p.Emplacement = z;
                        }
                    }
                }
            }
        }



    }
}
