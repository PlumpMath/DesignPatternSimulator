using DesignPatternSimulator.designpattern.environnement.style.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    class Rocher : Zone
    {
        public static string image = @"C:\Users\Mamadou\GitHub\DesignPatternSimulator\DesignPatternSimulator\designpattern\strategie\personnage\pictures\roc.jpg";
        private Position position;

        public Rocher(Position p)
        {
            position = p;
        }

        public void changePosition(Position p)
        {
            position = p;
        }
    }
}
