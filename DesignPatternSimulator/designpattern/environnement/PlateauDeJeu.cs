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
        private List<AbstractZone> accesZones = null;

        public PlateauDeJeu() { }    

        public override AbstractZone CreerZone()
        {
            return new Zone();
        }

        public override AbstractZone CreerZone(int i, int j)
        {
			return new Zone(i, j);
		}

        public override void AjouterZone(AbstractZone z)
        {
            accesZones.Add(z);
        }

        public override AbstractAcces CreerAcces()
        {
			return new Acces(null, null);
		}

        public override void setZonesAcces(List<AbstractZone> acces)
        {
            accesZones = acces;
        }

        /*
        public override void setZonesAcces(List<Acces> acces)
        {
			accesZones = acces;
		}
        */

		public override List<AbstractZone> getZonesAcces() {
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