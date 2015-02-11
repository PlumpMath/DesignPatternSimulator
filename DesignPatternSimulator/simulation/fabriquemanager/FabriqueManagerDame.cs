using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.dame;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.simulation.fabriquemanager
{
    public class FabriqueManagerDame
    {
        EnvironnementDame EspaceDeJeu;
        FactoryPersonnage LesPersonnages;

        private List<Personnage> lesPersonnes;
        public List<Personnage> LesPersonnes { get { return lesPersonnes; } set { lesPersonnes = value; } }
   
        public Organisation EtatMajor { get; set; }
        public EnvironnementDame Organisme { get; set; }

        TableLayoutPanel carre;
        int longueur;
        int largeur;

        
	
        public FabriqueManagerDame()
        {
            lesPersonnes = new List<Personnage>();
            EtatMajor = new Organisation();
        }
        
		public FabriqueManagerDame(EnvironnementDame monde, FactoryPersonnageDame persos)
        {
            EspaceDeJeu = monde;
            monde.CreerPlateauDeJeu(new FactoryDame());
            LesPersonnages = persos;

            carre = new TableLayoutPanel();

			lesPersonnes = new List<Personnage>();
			EtatMajor = new Organisation();
		}

      
		public void CreatePersonnagesDuJeu(FactoryPersonnageDame caserne)
        {
            //Creer pion blanc
            for (int i = 0; i < 20; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.PionBlanc, EtatMajor, (i+1).ToString()+"PionBlanc"));
            }

            //Creer pion noir
            for (int i = 0; i < 20; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.PionNoir, EtatMajor, (i + 1).ToString() + "PionNoir"));
            }
				Organisme = new EnvironnementDame();
				Organisme.CreerPlateauDeJeu(new FactoryDame());
			
		}
	

        public void PartirAuCombat()
        {
            foreach (Personnage p in LesPersonnes)
            {
				p.Combattre();
			}
		}

        public void SePresenter()
        {
            foreach (Personnage p in LesPersonnes)
            {
				p.Afficher();
			}
		}

        public string AfficherLesUploads()
        {
            string text = "";
            foreach (Personnage p in LesPersonnes)
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
			foreach(ObservateurAbstrait o in EtatMajor.lesObservateurs) {
                //System.out.println(((Personnage)o).getEtat());
                Console.WriteLine(((Personnage)o).getEtat());
                text += ((Personnage)o).getEtat();
                text += "\n";
			}
            return text;
		}
	
		public void ChangeEtat(eMode mode) {
			EtatMajor.setEMode(mode);
			EtatMajor.Update();
		}

        public string ShowAllPersonnage()
        {
            string text = "";
            foreach (Pion p in LesPersonnes)
            {
                this.toString(p);
                //System.out.println(p.toString());
                //Console.WriteLine(p.ToString());
                //text += p.ToString();
                //text += "\n";
			}
            return text;
		}



  

        public void   toString(Pion p)
        {
             Console.WriteLine("Position x {0} y {1} occupe {2}",p.Position.X,p.Position.Y,p.Position.Occupe);
        }

    }
}
