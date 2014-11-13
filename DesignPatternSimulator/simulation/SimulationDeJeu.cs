using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.strategie.main
{
	public class SimulationDeJeu {

		private List<Personnage> lesPersonnes;
		public Organisation etatMajor;
	
		public SimulationDeJeu() {
			lesPersonnes = new List<Personnage>();
			etatMajor = new Organisation();
		}
	
		public void CreatePersonnagesDuJeu(FactoryPersonnage caserne) {
			if(caserne.GetType().Name.Equals("FactoryPersonnageMoyenAge")) {
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Archer, etatMajor, "mehdi"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Archer, etatMajor, "legolas"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Chevalier, etatMajor, "aragorn"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Chevalier, etatMajor, "frodon"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Fantassin, etatMajor, "york"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Fantassin, etatMajor, "naruto"));
                lesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Princesse, null, "fiona"));
			
				lesPersonnes.ElementAt(0).setComportementSon(new EmettreSonCrier());
				lesPersonnes.ElementAt(1).setComportementSon(new EmettreSonAuSecour());
				lesPersonnes.ElementAt(2).setComportementSon(new EmettreSonEtendard());
				lesPersonnes.ElementAt(3).setComportementSon(new EmettreSonCrier());
			
				EnvironnementDeJeuMoyenAge usa = new EnvironnementDeJeuMoyenAge();
				usa.CreerPlateauDeJeu(new FactoryDeJeuGuerre());
			}
			/*
			if(caserne.GetType().Name.Equals("FactoryPersonnageGuerreDuGolf")) {
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Soldat, etatMajor, "mehdi"));		
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Soldat, etatMajor, "legolas"));
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Soldat, etatMajor, "aragorn"));
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Marine, etatMajor, "frodon"));
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Marine, etatMajor, "york"));
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Chef, etatMajor, "naruto"));
				lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.Soldat, null, "fiona"));
			
	//			lesPersonnes.get(0).setComportementSon(new EmettreSonCrier());
	//			lesPersonnes.get(1).setComportementSon(new EmettreSonAuSecour());
	//			lesPersonnes.get(2).setComportementSon(new EmettreSonEtendard());
	//			lesPersonnes.get(3).setComportementSon(new EmettreSonCrier());
			}
		*/
		}
	
		public void FaireCrierToutLeMonde() {

			foreach(Personnage p in lesPersonnes) {
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
			foreach(Personnage p in lesPersonnes) {
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
			foreach(ObservateurAbstrait o in etatMajor.lesObservateurs) {
                //System.out.println(((Personnage)o).getEtat());
                Console.WriteLine(((Personnage)o).getEtat());
                text += ((Personnage)o).getEtat();
                text += "\n";
			}
            return text;
		}
	
		public void ChangeEtat(eMode mode) {
			etatMajor.setEMode(mode);
			etatMajor.Update();
		}

        public string ShowAllPersonnage()
        {
            string text = "";
			foreach(Personnage p in lesPersonnes) {
                //System.out.println(p.toString());
                Console.WriteLine(p.ToString());
                text += p.ToString();
                text += "\n";
			}
            return text;
		}
	}
}