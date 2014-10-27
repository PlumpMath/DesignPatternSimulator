
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.style;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class Acces : AbstractAcces
    {

        public Zone zone1;
        public Zone zone2;

        public Acces() { }

        public Acces(AbstractZone z1, AbstractZone z2)
        {
            zone1 = (Zone)z1;
            zone2 = (Zone)z2;
        }

        public override AbstractAcces CreerAcces(AbstractZone aZone1, AbstractZone aZone2)
        {
            return new Acces(aZone1, aZone2);
        }

        public string FirstZoneName()
        {
            return zone1.getName();
        }

        public string SecondZoneName()
        {
            return zone2.getName();
        }
    }
}
