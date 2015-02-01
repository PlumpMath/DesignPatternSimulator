using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.dame;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.simulation
{
    public class SimulationDeJeuDame
    {

        public List<Personnage> lesPersonnes { get; set; }
        public Organisation etatMajor { get; set; }
        public EnvironnementDame usa { get; set; }

        public SimulationDeJeuDame()
        {
            //lesPersonnes = new List<Personnage>();
            //etatMajor = new Organisation();
        }

        public void CreatePersonnagesDuJeu(FactoryPersonnage caserne)
        {


            int b = 20;
            //Creer pion blanc
            for (int i = 0; i < b; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.PionBlanc, etatMajor, (i + 1).ToString() + "B"));
            }


            //Creer pion noir
            for (int i = 0; i < b; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.PionNoir, etatMajor, (i + 1).ToString() + "N"));
            }
    

            usa = new EnvironnementDame();
            usa.CreerPlateauDeJeu(new FactoryDame());

        }

        public void FaireCrierToutLeMonde()
        {

            foreach (Personnage p in lesPersonnes)
            {
                p.EmettreUnSon();
            }
        }

        public void PartirAuCombat()
        {
            foreach (Personnage p in lesPersonnes)
            {
                p.Combattre();
            }
        }

        public void SePresenter()
        {
            foreach (Personnage p in lesPersonnes)
            {
                p.Afficher();
            }
        }

        public string AfficherLesUploads()
        {
            string text = "";
            foreach (Personnage p in lesPersonnes)
            {
                //System.out.println(p.getEtat());
                Console.WriteLine(p.getEtat());
                text += p.getEtat();
                text += "\n";
            }
            return text;
        }

        //public void AfficherLesUploadsObservateur()
        public string AfficherLesUploadsObservateur()
        {
            string text = "";
            foreach (ObservateurAbstrait o in etatMajor.lesObservateurs)
            {
                //System.out.println(((Personnage)o).getEtat());
                Console.WriteLine(((Personnage)o).getEtat());
                text += ((Personnage)o).getEtat();
                text += "\n";
            }
            return text;
        }

        public void ChangeEtat(eMode mode)
        {
            etatMajor.setEMode(mode);
            etatMajor.Update();
        }

        public string ShowAllPersonnage()
        {
            string text = "";
            foreach (Personnage p in lesPersonnes)
            {
                //System.out.println(p.toString());
                //Console.WriteLine(p.ToString());
                text += p.ToString();
                text += "\n";
            }
            return text;
        }
    }
}
