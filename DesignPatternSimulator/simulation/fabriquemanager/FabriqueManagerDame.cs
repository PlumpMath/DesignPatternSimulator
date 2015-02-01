using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style.parent;
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
        
		public FabriqueManagerDame(EnvironnementDame monde, FactoryPersonnage persos)
		//public FabriqueManager(AbstractFabriqueDeJeu jeu, FactoryPersonnage persos)
        {
            EspaceDeJeu = monde;
            monde.CreerPlateauDeJeu(new FactoryDame());
            LesPersonnages = persos;

            carre = new TableLayoutPanel();

			lesPersonnes = new List<Personnage>();
			EtatMajor = new Organisation();
		}

      
		public void CreatePersonnagesDuJeu(FactoryPersonnage caserne)
        {
            //Creer pion blanc
            for (int i = 0; i < 20; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.PionBlanc, EtatMajor, (i+1).ToString()+"B"));
            }

            //Creer pion noir
            for (int i = 0; i < 20; i++)
            {
                lesPersonnes.Add(caserne.CreatePersonnage(eTypePersonnage.PionNoir, EtatMajor, (i + 1).ToString() + "N"));
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


            //TextBox text = new TextBox();
            //text.Enabled = false;
            //TextBox text2 = new TextBox();
            //text2.Enabled = false;
            //text.Text = "début";
            //carre.Controls.Add(text, 2, 1);
            //text2.Text = "fin";
            //carre.Controls.Add(text2, 0, 3);

            //Panel zone = tlp.GetControlFromPosition(5, 9) as Panel;
            PictureBox black = new PictureBox();
            //black.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png";
            //pic.ImageLocation = "C:\\Users\\Mamadou\\GitHub\\DesignPatternSimulator\\DesignPatternSimulator\\designpattern\\strategie\\personnage\\pictures\\eliwood_critique45.png";
            //black.SizeMode = PictureBoxSizeMode.StretchImage;
            //carre.Controls.Add(black, 0, 3);
            
            RemplirGrille(black, 10, 10, carre,LesPersonnes);

            return carre;
        }


        public void RemplirGrille(PictureBox pic, int column, int row,TableLayoutPanel tab, List<Personnage> lesPerso)
        {

            int po = 0;
            foreach (var p in LesPersonnes)
            {   
            }
            //tab = new TableLayoutPanel();
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    //pion noir placé en bas
                    if (j > 5 && (j%2==0) && (i%2!=0))
                    { 
                        pic = new PictureBox();
                        pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png";
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        tab.Controls.Add(pic, i, j);
                        po++;
                    }

                    //pion noir placé en bas
                    else if (j > 5 && (j % 2 != 0) && (i % 2 == 0))
                    {
                        pic = new PictureBox();
                        pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\black.png";
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;

                        tab.Controls.Add(pic, i, j);
                        po++;
                    }

                    //pion blanc placé en haut
                    else if(j < 4 && (j % 2 != 0) && (i % 2 == 0))
                    {
                        pic = new PictureBox();
                        pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png";
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        tab.Controls.Add(pic, i, j);
                        po++;
                    }

                    //pion blanc placé en haut
                    else if (j < 4 && (j % 2 == 0) && (i % 2 != 0))
                    {
                        pic = new PictureBox();
                        pic.ImageLocation = @"C:\Users\SI\Documents\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\white.png";
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        tab.Controls.Add(pic, i, j);
                        po++;
                    }

                }
            }
        }


        public void   toString(Pion p)
        {
             Console.WriteLine("Postion x {0} y {1} occupe {2}",p.Position.X,p.Position.Y,p.Position.Occupe);
        }

    }
}
