using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.personnage;
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


        /// <summary>
        /// Placer les pions sur un damier constitué de zone
        /// </summary>
        /// <param name="perso"></param>
        /// <param name="damier"></param>
        public void PlacerLesPionsSurDamier(List<Personnage> perso, PlateauDeJeuDame damier)
        {
            var listezone = damier.getZoneForFree();// damier.getZonesAcces();
            foreach (var z in listezone)
            {
                foreach (var p in perso)
                {

                    if (p.GetType().Equals(typeof(PionBlanc)))
                    {
                        if (z.Y < 4 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            
                            p.Position = z;
                            z.Occupe = true;
                            z.PionPosseder = "PionBlanc";
                        }
                        else if (z.Y < 4 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                            z.PionPosseder = "PionBlanc";
                        }
                    }
                    else if (p.GetType().Equals(typeof(PionNoir)))
                    {
                        if (z.Y > 5 && (z.Y % 2 == 0) && (z.X % 2 != 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                            z.PionPosseder = "PionNoir";
                        }
                        else if (z.Y > 5 && (z.Y % 2 != 0) && (z.X % 2 == 0))
                        {
                            p.Position = z;
                            z.Occupe = true;
                            z.PionPosseder = "PionNoir";
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
            //récupérer toutes les zones autour du pion
            var zoneEnvironnantDuPion = pion.Position.GetList(pion, plateau.getZoneForFree());

            //récupérer les zones non occupé
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


        public List<ZonePion> ListePionsEnvironnants(Pion pion, List<ZonePion> listeDesZoneAuxAlentours)
        {
            
            List<ZonePion> listePionZoneEnvironnants = new List<ZonePion>();
            if(pion.GetType().Equals(typeof(PionBlanc)))
            {
                foreach (var item in listeDesZoneAuxAlentours)
                {
                    if(item.Occupe.Equals(true) && item.PionPosseder.Equals("PionNoir"))
                        listePionZoneEnvironnants.Add(item);
                }
                return listePionZoneEnvironnants;
            }
            else
            {
                foreach (var item in listeDesZoneAuxAlentours)
                {
                    if(item.Occupe.Equals(true) && item.PionPosseder.Equals("PionBlanc"))
                        listePionZoneEnvironnants.Add(item);
                }

            return listePionZoneEnvironnants;
            }
        }


        /// <summary>
        /// Deplacement d'une zone vers une zone
        /// </summary>
        /// <param name="perso"></param>
        /// <param name="damier"></param>
        public void Execution(List<Personnage> perso, PlateauDeJeuDame damier)
        {
            Random hasard = new Random();
            List<Pion> listPionNoir = new List<Pion>();
            List<Pion> listPionBlanc = new List<Pion>();
            foreach (Pion pionPerso in perso)
            {
                if (pionPerso.GetType().Equals(typeof(PionBlanc))) { listPionBlanc.Add(pionPerso); } else { listPionNoir.Add(pionPerso); }

            }
            int tour = 100;
            Pion pionBlanc = null;
            Pion pionBlancAdverse = null;
            Pion pionNoir = null ;
            Pion pionNoirAdverse = null;
            for(int i = 0;  i <= tour; i++){
                if (i % 2 == 0)
                {
                    bool testB = false ;
                    int varialeB;
                    while(testB == false){
                        varialeB = hasard.Next(1,listPionBlanc.Count);
                        testB = PionADeplacer(listPionBlanc.ElementAt(varialeB),damier);
                        pionBlanc = listPionBlanc.ElementAt(varialeB);
                    }
                    //public List<ZonePion> ListePionsEnvironnants(Pion pion, List<ZonePion> listeDesZoneAuxAlentours)
                    var listeDesPionsContrairesAlentours = this.ListePionsEnvironnants(pionBlanc, pionBlanc.Position.GetList(pionBlanc, plateau.getZoneForFree().ToList()));
                    if (listeDesPionsContrairesAlentours == null) 
                    {   pionBlanc.Avancer(1);}
                    else
                    {
                        if (listeDesPionsContrairesAlentours.Count != 0) { 
                        int  itemPionAdverse = hasard.Next(1,listeDesPionsContrairesAlentours.Count);
                        //Choisir un pion adverse au hasard à manger
                        foreach (Pion item in perso)
                        {
                            if( item.Position.X == listeDesPionsContrairesAlentours.ElementAt(itemPionAdverse).X && item.Position.Y == listeDesPionsContrairesAlentours.ElementAt(itemPionAdverse).Y
                                )
                            {
                                pionBlancAdverse = item;
                                continue;
                            }
                        }
                        pionBlanc.ComportementManger.MangerPion(pionBlanc, pionBlancAdverse,this);
                        }
                    }
                }
                else
                {
                    bool testN = false;
                    int variableN;
                    while(testN == false)
                    {
                        variableN = hasard.Next(1, listPionNoir.Count);
                        testN = PionADeplacer(listPionNoir.ElementAt(variableN), damier);
                        pionNoir = listPionNoir.ElementAt(variableN);
                    }

                    var listeDesPionsContrairesAlentours = this.ListePionsEnvironnants(pionNoir, pionNoir.Position.GetList(pionNoir, plateau.getZoneForFree().ToList()));
                    if (listeDesPionsContrairesAlentours == null)
                    { pionNoir.Avancer(1); }
                    else
                    {
                        if (listeDesPionsContrairesAlentours.Count != 0) 
                        { 
                        int itemPionAdverse = hasard.Next(1, listeDesPionsContrairesAlentours.Count);
                        //Choisir un pion adverse au hasard à manger
                        foreach (Pion item in perso)
                        {
                            if (item.Position.X == listeDesPionsContrairesAlentours.ElementAt(itemPionAdverse).X && item.Position.Y == listeDesPionsContrairesAlentours.ElementAt(itemPionAdverse).Y
                                )
                            {
                                pionNoirAdverse = item;
                                continue;
                            }
                        }
                        pionNoir.ComportementManger.MangerPion(pionBlanc, pionBlancAdverse,this);
                        }
                    }
                }
            }

        }





    }
}
