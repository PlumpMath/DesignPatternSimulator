using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;


namespace DesignPatternSimulator.designpattern.environnement.parent
{
    public abstract class AbstractPlateauDeJeu
    {

        public abstract AbstractZone CreerZone();
        public abstract AbstractZone CreerZone(int i, int j);
        public abstract void AjouterZone(AbstractZone zone);
        public abstract AbstractAcces CreerAcces();
        //public abstract void setZonesAcces(List<Acces> acces);
        public abstract void setZonesAcces(List<AbstractZone> acces);
        //public abstract List<Acces> getZonesAcces();
        public abstract List<AbstractZone> getZonesAcces();

    }
}