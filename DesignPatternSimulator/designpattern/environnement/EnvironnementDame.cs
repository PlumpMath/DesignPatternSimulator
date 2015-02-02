using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.dame;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.designpattern.environnement
{
    public class EnvironnementDame : EnvironnementDeJeu
    {
        private PlateauDeJeuDame plateau;
        public PlateauDeJeuDame Plateau { get { return plateau; } set { plateau = value; } }

        public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique)
        {
            PlateauDeJeuDame damier = new PlateauDeJeuDame();
            FactoryDame factory = new FactoryDame();

            List<ZonePion> caseDamier = new List<ZonePion>();
            caseDamier = factory.CreateCarre(10, 10);
            damier.setZoneFree(caseDamier);

            plateau = damier;
            return plateau;
        }

        public override AbstractPlateauDeJeu GetPlateauDeJeu()
        {
            return plateau;
        }

        public PlateauDeJeuDame GetPlateauDeJeuDame()
        {
            return Plateau;
        }

        public void PlacerLesPions(List<Personnage> perso, TableLayoutPanel pa)
        {

        }

        /// <summary>
        /// Placer les pions sur un damier constitué de zone
        /// </summary>
        /// <param name="perso"></param>
        /// <param name="damier"></param>
        public void PlacerLesPionsSurDamier(List<Personnage> perso, PlateauDeJeuDame damier)
        {
            var listezone = damier.getZoneForFree();// damier.getZonesAcces();
            foreach (ZonePion z in listezone)
            {
                foreach (Pion p in perso)
                {

                    if (p.GetType().Equals(typeof(PionBlanc)))
                    {
                        if (z.Y < 4 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                        }
                        else if (z.Y < 4 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                        }
                    }
                    else if (p.GetType().Equals(typeof(PionNoir)))
                    {
                        if (z.Y > 5 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                        }
                        else if (z.Y > 5 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pion"></param>
        /// <param name="plateau"></param>
        /// <returns></returns>
        public Boolean PionADeplacer(Pion pion, PlateauDeJeuDame plateau)
        {
            var zoneEnvironnantDuPion = pion.Position.GetList(pion, plateau.getZoneForFree());

            var zoneFree = zoneEnvironnantDuPion.Where(c=>c.Occupe == false).ToList<ZonePion>();

            int nbreZoneFree = zoneFree.Count;
            //var zoneOfPlateau = plateau.getZoneForFree();
            if(zoneFree != null && zoneFree.Count >= 2){
                return true;
            }
            else{
                return false;
            }
        }





        /// <summary>
        /// Deplacement d'une zone vers une zone
        /// </summary>
        /// <param name="perso"></param>
        /// <param name="damier"></param>
        public void Execution(List<Pion> perso, PlateauDeJeuDame damier)
        {
            Random hasard = new Random();
            List<Pion> listPionNoir = new List<Pion>();
            List<Pion> listPionBlanc = new List<Pion>();
            foreach (var pionPerso in perso)
            {
                if (pionPerso.Color == Color.White)
                {
                    listPionBlanc.Add(pionPerso);
                }
                else
                {
                    listPionNoir.Add(pionPerso);
                }
            }


            int tour = 100;
            
            Pion pionBlanc; //= new PionBlanc();
            Pion pionNoir ;//= new PionNoir();
            for(int i = 0;  i <= tour; i++){
                if (i % 2 == 0)
                {
                    bool testB ;

                    do
                    {
                        testB = PionADeplacer(listPionBlanc.ElementAt(hasard.Next(listPionBlanc.Count)),damier);
                        pionBlanc = listPionBlanc.ElementAt(hasard.Next(listPionBlanc.Count));
                    } while (testB == true);
                }
                else
                {
                    bool testN;

                    do
                    {
                        testN = PionADeplacer(listPionNoir.ElementAt(hasard.Next(0, listPionNoir.Count)), damier);
                        pionNoir = listPionNoir.ElementAt(hasard.Next(0, listPionNoir.Count));
                    } while (testN == true);

                }
            }


            /*
            foreach (Pion i in perso)
            {
                var ip = i.Position.GetList(i, damier.getZoneForFree());
                int taille = ip.Count;



                foreach (var item in ip)
                {
                    int numhasard = hasard.Next(0, 20);
                    if (item.Occupe == false)
                    {
                        i.ZoneVersZone(item);
                        return;
                    }
                }
            }
             */

        }

    }
}
