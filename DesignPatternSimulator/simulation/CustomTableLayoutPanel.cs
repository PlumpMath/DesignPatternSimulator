using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternSimulator.simulation
{
    class CustomTableLayoutPanel : TableLayoutPanel
    {
        private List<Personnage> LesPersonnages;
        private List<Rocher> LesRochers;

        public CustomTableLayoutPanel()
        {
            LesPersonnages = new List<Personnage>();
            LesRochers = new List<Rocher>();
        }

        public List<Personnage> GetPersonnages()
        {
            return LesPersonnages;
        }

        public List<Rocher> GetLesRochers()
        {
            return LesRochers;
        }
    }
}
