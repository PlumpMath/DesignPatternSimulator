using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class Zone : AbstractZone {

	    private string name;
	
	    public Zone() {}
	
	    public Zone(string nom, int x, int y) {
		    name = nom;
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