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
	
	    public Zone(string nom) {
		    name = nom;
	    }
	
	    public override AbstractZone CreerZone() {
		    return new Zone();
	    }

	    public override AbstractZone CreerZone(string s) {
		    return new Zone(s);
	    }

	    public string getName() {
		    return name;
	    }

    }
}