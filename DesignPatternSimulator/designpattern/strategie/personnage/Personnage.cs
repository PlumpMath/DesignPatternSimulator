using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son.parent;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
	public abstract class Personnage : ObservateurAbstrait {


        //*[0] Rating in his position
        protected int rate;
        //*[1] Speed
        protected int speed;
        //*[2] Power
        protected int power;
        //*[3] Jump Strength
        protected int jumpStrength;
        //*[4] Shot Strength
        protected int shotStrength;
        //*[5] Passing Accuracy
        protected int passAccuracy;
        //*[6] Long Pass Accuracy
        protected int longPassAccuracy;
        //*[7] Shot Accuracy
        protected int shotAccuracy;
        //*[8] Stamina
        protected int stamina;
        //*[9] Risk of injury/Sturdiness
        protected int riskInjury;
        //*[10] Goalkeeping
        protected int goalKeeping;
        //*[11] Defending
        protected int defending;
        //*[12] Left/Right Foot (0 is right, 1 is left, 2 is both
        protected int foot;



		private string nom;
		public ComportementDeCombat comportementCombat = null;
		public ComportementEmettreSon comportementSon = null;
		private Organisation etatMajor = null;
		private eMode etatFonctionnement = eMode.NON_DEFINI;

        public string PictureLocation { get; set; }
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


        internal AbstractZone GetEmplacement()
        {
            return this.Emplacement;
        }
    }
}