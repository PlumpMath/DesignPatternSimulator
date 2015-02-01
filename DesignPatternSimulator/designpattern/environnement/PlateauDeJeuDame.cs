using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement
{
    public class PlateauDeJeuDame : AbstractPlateauDeJeu
    {
              //private List<Acces> accesZones = null;
        private List<ZonePion> accesZones = new List<ZonePion>();

        public PlateauDeJeuDame() { }    
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
            
            //accesZones.Add(z);
        }
        public override AbstractAcces CreerAcces()
        {
			return new Acces(null, null);
		}

        public override void setZonesAcces(List<AbstractZone> acces)
        {
            //accesZones = acces;
        }

        /*
        public override void setZonesAcces(List<Acces> acces)
        {
			accesZones = acces;
		}
        */

        //récupérer les zones du plateau
		public override List<AbstractZone> getZonesAcces() {
            return new List<AbstractZone>();
		}

        public void  setZoneFree(List<ZonePion> acces)
        {
            accesZones = acces;

        }

        public List<ZonePion> getZoneForFree()
        {
            return accesZones;
        }

        public IEnumerable<AbstractZone> getZoneFree()
        {
            IEnumerable<AbstractZone> t = accesZones;
            return t;
        }
    }
}
