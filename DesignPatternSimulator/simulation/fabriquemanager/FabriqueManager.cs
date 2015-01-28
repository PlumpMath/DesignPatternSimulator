using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.observateur.parent;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.son.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System.Windows.Forms;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.simulation.fabriquemanager
{
    class FabriqueManager
    {
        //AbstractFabriqueDeJeu EspaceDeJeu;
        EnvironnementDeJeu EspaceDeJeu;
        FactoryPersonnage LesPersonnages;

        public List<Personnage> LesPersonnes {get;set;}
        public Organisation EtatMajor { get; set; }
        public EnvironnementDeJeu Organisme { get; set; }

        TableLayoutPanel carre;
        int longueur;
        int largeur;

        
	
        public FabriqueManager()
        {
            LesPersonnes = new List<Personnage>();
            EtatMajor = new Organisation();
        }
        
		public FabriqueManager(EnvironnementDeJeu monde, FactoryPersonnage persos)
		//public FabriqueManager(AbstractFabriqueDeJeu jeu, FactoryPersonnage persos)
        {
            EspaceDeJeu = monde;
            monde.CreerPlateauDeJeu(new FactoryDeJeuGuerre());
            LesPersonnages = persos;

            carre = new TableLayoutPanel();

			LesPersonnes = new List<Personnage>();
			EtatMajor = new Organisation();
		}

        /*public void CreatePersonnagesDuJeu(FactoryPersonnage caserne)
        {
            if (caserne.GetType().Name.Equals("FactoryPersonnageMoyenAge"))
            {
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Archer, EtatMajor, "mehdi"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Archer, EtatMajor, "legolas"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Chevalier, EtatMajor, "aragorn"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Chevalier, EtatMajor, "frodon"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Fantassin, EtatMajor, "york"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Fantassin, EtatMajor, "naruto"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage.Princesse, null, "fiona"));

                LesPersonnes.ElementAt(0).setComportementSon(new EmettreSonCrier());
                LesPersonnes.ElementAt(1).setComportementSon(new EmettreSonAuSecour());
                LesPersonnes.ElementAt(2).setComportementSon(new EmettreSonEtendard());
                LesPersonnes.ElementAt(3).setComportementSon(new EmettreSonCrier());

                Organisme = new EnvironnementDeJeuMoyenAge();
                Organisme.CreerPlateauDeJeu(new FactoryDeJeuGuerre());
                
            }
        }*/
	
		public void CreatePersonnagesDuJeu(FactoryPersonnage caserne)
        {
			//if(caserne.GetType().Name.Equals("FactoryPersonnageMoyenAge")) {
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Archer, EtatMajor, "mehdi"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Archer, EtatMajor, "legolas"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Chevalier, EtatMajor, "aragorn"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Chevalier, EtatMajor, "frodon"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Fantassin, EtatMajor, "york"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Fantassin, EtatMajor, "naruto"));
                LesPersonnes.Add(caserne.CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.eTypePersonnage.Princesse, null, "fiona"));
			
				LesPersonnes.ElementAt(0).setComportementSon(new EmettreSonCrier());
				LesPersonnes.ElementAt(1).setComportementSon(new EmettreSonAuSecour());
				LesPersonnes.ElementAt(2).setComportementSon(new EmettreSonEtendard());
				LesPersonnes.ElementAt(3).setComportementSon(new EmettreSonCrier());
			
				Organisme = new EnvironnementDeJeuMoyenAge();
				Organisme.CreerPlateauDeJeu(new FactoryDeJeuGuerre());
			//}
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

			foreach(Personnage p in LesPersonnes) {
				p.EmettreUnSon();
			}
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
			foreach(Personnage p in LesPersonnes) {
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
			foreach(Personnage p in LesPersonnes) {
                //System.out.println(p.toString());
                Console.WriteLine(p.ToString());
                text += p.ToString();
                text += "\n";
			}
            return text;
		}

        public TableLayoutPanel InitTableLayout(int h, int l)
        {
            carre.ColumnCount = l;
            carre.RowCount = h;

            /*float percent = 100 / carre.RowCount;
            for (int i = 0; i < carre.ColumnCount; i++)
            {
                carre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, percent));
            }

            percent = 100 / carre.ColumnCount;
            for (int j = 0; j < carre.ColumnCount; j++)
            {
                carre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percent));
            }*/


            float percentRow = 100 / carre.RowCount;
            float percentColumn = 100 / carre.ColumnCount;
            int maxCount = 0;
            if (carre.RowCount == carre.ColumnCount)
            {
                maxCount = carre.RowCount;
            }
            else
            {
                if (carre.RowCount > carre.ColumnCount)
                {
                    maxCount = carre.RowCount;
                }
                else
                {
                    maxCount = carre.ColumnCount;
                }
            }

            
            for (int i = 0; i < maxCount; i++)
            {
                if (carre.RowCount <= maxCount)
                {
                    carre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, percentRow));
                }
                if (carre.ColumnCount <= maxCount)
                {
                    carre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percentColumn));
                }
            }
            for (int i = 0 ; i < 20 ; i++) {
                for (int j = 0 ; j < 20; j++) {
                    AbstractZone zon;
                
                    /*if ((i == 8 && j == 6) || (i == 8 && j == 14)) {
                        zon = EspaceDeJeu.CreateZone(i, j);
                        //z = creerZone(CaseTypes.fort, new Position(i, j));
                    } else {
                        zon = EspaceDeJeu.CreateZone(i,j)
                        //z = creerZone(CaseTypes.plaine, new Position(i, j));
                    }*/

                    zon = EspaceDeJeu.GetPlateauDeJeu().CreerZone(i, j);
                    EspaceDeJeu.GetPlateauDeJeu().AjouterZone(zon);
                }
            }
            

            // Set the BorderStyle to Inset
            carre.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            // If grid is full add extra cells by adding column
            carre.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            // Padding (pixels)within each cell (left, top, right, bottom)
            carre.Padding = new Padding(1, 1, 1, 1);
            carre.Dock = DockStyle.Fill;


            TextBox text = new TextBox();
            text.Enabled = false;
            TextBox text2 = new TextBox();
            text2.Enabled = false;
            text.Text = "début";
            carre.Controls.Add(text, 2, 1);
            text2.Text = "fin";
            carre.Controls.Add(text2, 0, 3);

            //Panel zone = tlp.GetControlFromPosition(5, 9) as Panel;
            PictureBox pic = new PictureBox();
            pic.ImageLocation = "C:\\Users\\Mamadou\\GitHub\\DesignPatternSimulator\\DesignPatternSimulator\\designpattern\\strategie\\personnage\\pictures\\eliwood_critique45.png";
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            carre.Controls.Add(pic, 0, 3);

            return carre;
        }




/*
    {
    for (int i = 0 ; i < 20 ; i++) {
            for (int j = 0 ; j < 20; j++) {
                AbstractZone z;
                /*
                if ((i == 8 && j == 6) || (i == 8 && j == 14)) {
                    z = creerZone(CaseTypes.fort, new Position(i, j));
                } else {
                    z = creerZone(CaseTypes.plaine, new Position(i, j));
                }
                *//*
                z = creerZone(CaseTypes.plaine, new Position(i, j));
                plateauDeJeu.ajouterZone(z);
            }
        }
        for (ZoneAbstract zone : plateauDeJeu.getZones()) {
            Case c1 = (Case) zone;
            for (ZoneAbstract zone2 : plateauDeJeu.getZones()) {
                Case c2 = (Case) zone2;
                if (c2.getPosition().equals(new Position(c1.getPosition().getPositionX()+1, c1.getPosition().getPositionY())) ||
                        c2.getPosition().equals(new Position(c1.getPosition().getPositionX()-1, c1.getPosition().getPositionY())) ||
                        c2.getPosition().equals(new Position(c1.getPosition().getPositionX(), c1.getPosition().getPositionY()+1)) ||
                        c2.getPosition().equals(new Position(c1.getPosition().getPositionX(), c1.getPosition().getPositionY()-1))) {
                    AccessAbstract acces = creerAcces(zone, zone2);
                    plateauDeJeu.ajouterAcces(acces);
                    AccessAbstract acces2 = creerAcces(zone2, zone);
                    plateauDeJeu.ajouterAcces(acces2);
                }
            }
        }
    }
*/

    }
    
}
