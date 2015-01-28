using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    class Rocher : Case
    {
        private static string image = "";
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
