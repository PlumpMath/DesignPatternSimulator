using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.environnement
{
	public class Labyrinthe : AbstractPlateauDeJeu {

		public override AbstractZone CreerZone() {
			return new Case();
		}

		public override AbstractAcces CreerAcces() {
			return new Adjacent(null, null);
		}

		public override void SetZonesAcces(List<Acces> acces) {
			// TODO Auto-generated method stub
		
		}

		public override List<Acces> GetZonesAcces() {
			// TODO Auto-generated method stub
			return null;
		}

	}
}