using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.simulation.fabriquemanager
{
    class WinFormManager
    {
        private List<Personnage> PersonnagesDuJeu;
        private List<AbstractZone> ZoneLibre;

        public WinFormManager(CustomTableLayoutPanel panel)
        {
            PersonnagesDuJeu = panel.GetPersonnages();
        }

        public List<AbstractZone> whichZonesAreFree()
        {
            ZoneLibre = new List<AbstractZone>();
            foreach (Personnage p in PersonnagesDuJeu)
            {
                ZoneLibre.Add(p.GetEmplacement());

            }
            return ZoneLibre;
        }

        public void deplacerPersonnage(Personnage perso)
        {

        }
    }
}
