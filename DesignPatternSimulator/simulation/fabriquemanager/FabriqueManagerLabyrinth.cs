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
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.labyrinth;

namespace DesignPatternSimulator.simulation.fabriquemanager
{
    class FabriqueManagerLabyrinth
    {
        EnvironnementLabyrinth EspaceDeJeu;
        FactoryPersonnage LesPersonnages;

        Hamtaro Hamster = new Hamtaro("Hamtaro");
        List<Rocher> LesRochers = new List<Rocher>();
        Tresor gain = new Tresor();

        List<Zone> world = new List<Zone>();
        List<Zone> ZonesOccupees = new List<Zone>();

        //public List<Personnage> LesPersonnes {get;set;}
        public Organisation EtatMajor { get; set; }
        public EnvironnementDeJeu Organisme { get; set; }

        CustomTableLayoutPanel carre;
        //int longueur;
        //int largeur;
        
	
        public FabriqueManagerLabyrinth()
        {
            EspaceDeJeu = new EnvironnementLabyrinth(Hamster);
            EspaceDeJeu.CreerPlateauDeJeu(new FactoryLabyrinth());
            world = EspaceDeJeu.PlacerLesObjectsDansLabyrinth17x8();
            //world = EspaceDeJeu.GetTerrain();

            //LesPersonnes = new List<Personnage>();
            //CreatePersonnagesDuJeu();
            //LesPersonnes.Add(new Hamtaro("Hamtaro"));

            //EtatMajor = new Organisation();
        }
        
		public FabriqueManagerLabyrinth(EnvironnementDeJeu monde, FactoryPersonnage persos)
		//public FabriqueManager(AbstractFabriqueDeJeu jeu, FactoryPersonnage persos)
        {
            EspaceDeJeu = (EnvironnementLabyrinth) monde;
            EspaceDeJeu.CreerPlateauDeJeu(new FactoryLabyrinth());
            LesPersonnages = persos;

            //carre = new CustomTableLayoutPanel();

			//LesPersonnes = new List<Personnage>();

		}

        public List<Zone> GetLesZones()
        {
            return world;
        }

        public CustomTableLayoutPanel InitTableLayout(int h, int l)
        {
            PictureBox pics = new PictureBox();
            pics.ImageLocation = "C:\\Users\\Mamadou\\GitHub\\DesignPatternSimulator\\DesignPatternSimulator\\designpattern\\strategie\\personnage\\pictures\\white.png";
            pics.SizeMode = PictureBoxSizeMode.StretchImage;
            
            carre.ColumnCount = l;
            carre.RowCount = h;

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

            
            //for (int i = 0; i < maxCount; i++)
            //{
            for (int i = 0; i < carre.RowCount; i++)
            {
                carre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, percentRow));
            }
            for (int i = 0; i < carre.ColumnCount; i++)
            {
                carre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percentColumn));
            }

            for (int i = 0; i < carre.ColumnCount; i++)
            {
                for (int j = 0; j < carre.RowCount; j++)
                {
                    AbstractZone zon;
                
                    /*if ((i == 8 && j == 6) || (i == 8 && j == 14)) {
                        zon = EspaceDeJeu.CreateZone(i, j);
                        //z = creerZone(CaseTypes.fort, new Position(i, j));
                    } else {
                        zon = EspaceDeJeu.CreateZone(i,j)
                        //z = creerZone(CaseTypes.plaine, new Position(i, j));
                    }*/
                    zon = EspaceDeJeu.GetPlateauDeJeu().CreerZone(i, j);
                    //carre.Controls.Add(pics, i, j);
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

        public CustomTableLayoutPanel deplacerPersonnage(CustomTableLayoutPanel pan)
        {
            //carre.Controls.Add(pic, 0, 3);
            Control c = pan.GetControlFromPosition(0, 3);
            pan.SetCellPosition(c, new TableLayoutPanelCellPosition(2, 3));
            Console.Out.WriteLine("marche");

            return pan;
        } 
    }
}
