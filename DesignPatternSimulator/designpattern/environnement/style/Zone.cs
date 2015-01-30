using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using System.Drawing;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class Zone : AbstractZone {

	    private string name;
        private int x;
        private int y;
        private Color color;

        public Zone()
        {
            this.x = 0;
            this.y = 0;
        }

        public Zone(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
	
	    public Zone(string nom, int x, int y) {
		    name = nom;
            this.x = x;
            this.y = y;
	    }

        public Zone(Position p)
        {
            this.x = p.getPositionX();
            this.y = p.getPositionY();
        }
	
	    public override AbstractZone CreerZone() {
		    return new Zone();
	    }

	    public override AbstractZone CreerZone(string s, int x, int y) {
		    return new Zone(s, x, y);
	    }

	    public string getName() {
		    return name;
	    }

    }
}