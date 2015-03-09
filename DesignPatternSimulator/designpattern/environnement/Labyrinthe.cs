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

        List<Zone> accesZones;

		public override AbstractZone CreerZone() {
			return new Case();
        }

        public override AbstractZone CreerZone(int i, int j)
        {
            return new Case(i, j);
        }

        public override void AjouterZone(AbstractZone z)
        {
            accesZones.Add((Zone)z);
        }

		public override AbstractAcces CreerAcces() {
			return new Adjacent(null, null);
		}
        
		//public override void setZonesAcces(List<Acces> acces) {
        public void setZones(List<Zone> acces)
        {
            accesZones = acces;
		}
        
		//public override List<Acces> getZonesAcces() {
        public List<Zone> getZones()
        {
			// TODO Auto-generated method stub
            return accesZones;
		}

        public Rocher CreerRocher(int x, int y)
        {
            return new Rocher(x, y);
        }


        public override void setZonesAcces(List<AbstractZone> acces)
        {
            throw new NotImplementedException();
        }

        public override List<AbstractZone> getZonesAcces()
        {
            throw new NotImplementedException();
        }
    }
}