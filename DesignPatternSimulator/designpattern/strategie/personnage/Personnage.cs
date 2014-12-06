using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son.parent;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
	public abstract class Personnage : ObservateurAbstrait {

		private string nom;
		public ComportementDeCombat comportementCombat = null;
		public ComportementEmettreSon comportementSon = null;
		private Organisation etatMajor = null;
		private eMode etatFonctionnement = eMode.NON_DEFINI;

        public AbstractZone Emplacement { get; set; }

		public Personnage (Organisation unitedStateOfAmerica, string sonNom) {
			this.nom = sonNom;
			comportementCombat = null;
			comportementSon = null;
			etatMajor = unitedStateOfAmerica;
		
			if(etatMajor != null) {
				etatMajor.Attach(this);
			}
		}

		public override void update() {
			etatFonctionnement = etatMajor.etatFonctionnement;
		}

		public Personnage (Organisation unitedStateOfAmerica, string sonNom, object o) {
			this.nom = sonNom;
			if(o != null) {
				//if(o.getClass().tostring().equals("ComportementDeCombat")) {
				if(o.GetType().Name.Equals("ComportementDeCombat")) {
					comportementCombat = (ComportementDeCombat)o;
				}
                else if (o.GetType().Name.Equals("ComportementEmettreSon"))
                {
					comportementSon = (ComportementEmettreSon)o;
				}
			}
			etatMajor = unitedStateOfAmerica;
		
			if(etatMajor != null) {
				etatMajor.Attach(this);
			}
		}

	//	public Personnage (string sonNom, ComportementEmettreSon blabla) {
	//		this.nom = sonNom;
	//		comportementSon = blabla;
	//	}

		public Personnage (string sonNom, ComportementDeCombat style, ComportementEmettreSon blabla) {
			this.nom = sonNom;
			comportementCombat = style;
			comportementSon = blabla;
		}

		public virtual void Afficher() {
			//System.out.println("Je suis " + this.nom );
		}
	
		public void Combattre() {
			if(this.comportementCombat != null) {
				//System.out.println("Je suis " + this.nom + " et " + comportementCombat.combattre());
			}
		}
	
		public void EmettreUnSon() {
			if(this.comportementSon != null) {
				//System.out.println("Je suis " + this.nom + " et " + comportementSon.Parler());
			}
		}
	
		public virtual string SeDeplacer() {
			return "je marche";
		}
	
		public string getNom() {
			return nom;
		}

		public void setNom(string nom) {
			this.nom = nom;
		}

		public ComportementDeCombat getComportementCombat() {
			return comportementCombat;
		}

		public void setComportementCombat(ComportementDeCombat comportementCombat) {
			this.comportementCombat = comportementCombat;
		}

		public ComportementEmettreSon getComportementSon() {
			return comportementSon;
		}

		public void setComportementSon(ComportementEmettreSon comportementSon) {
			this.comportementSon = comportementSon;
		}
	
		public string getEtat() {
			if(etatMajor != null)
				return etatMajor.etatFonctionnement.ToString();
			return etatFonctionnement.ToString();
		}
	
	}
}