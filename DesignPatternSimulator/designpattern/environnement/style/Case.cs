using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.environnement.style
{
	public class Case : AbstractZone {
	
		private string name;
	
		public Case() {}
	
		public Case(string nom, int x, int y) {
			name  = nom;
		}

		public override AbstractZone CreerZone() {
			return new Case();
		}

		public override AbstractZone CreerZone(string s, int x, int y) {
			return new Case(s, x, y);
		}

	}
}