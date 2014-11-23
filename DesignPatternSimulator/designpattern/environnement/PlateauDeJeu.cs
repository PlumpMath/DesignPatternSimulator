using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.parent;

namespace DesignPatternSimulator.designpattern.environnement
{
	public class PlateauDeJeu : AbstractPlateauDeJeu {

        //private List<Acces> accesZones = null;
        private List<Zone> accesZones = null;

        public override AbstractZone CreerZone()
        {
			return new Zone();
		}

        public override AbstractAcces CreerAcces()
        {
			return new Acces(null, null);
		}

        public override void setZonesAcces(List<Zone> acces)
        {
            accesZones = acces;
        }

        /*
        public override void setZonesAcces(List<Acces> acces)
        {
			accesZones = acces;
		}
        */

		public override List<Zone> getZonesAcces() {
			return accesZones;
		}

        /*
        public override List<Acces> getZonesAcces()
        {
            return accesZones;
        }
        */

	}
}