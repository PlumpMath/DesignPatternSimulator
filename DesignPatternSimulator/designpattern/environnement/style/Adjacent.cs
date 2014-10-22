
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.style;

namespace DesignPatternSimulator.designpattern.environnement.style
{
    public class Adjacent : AbstractAcces {

	    private Case case1;
	    private Case case2;
	
	    public Adjacent(AbstractZone c1, AbstractZone c2) {
		    this.case1 = (Case) c1;
		    this.case2 = (Case) c2;
	    }
	
	    public override AbstractAcces CreerAcces(AbstractZone premiereZone, AbstractZone deuxiemeZone) {
		    return new Adjacent(premiereZone, deuxiemeZone);
	    }

    }
}
