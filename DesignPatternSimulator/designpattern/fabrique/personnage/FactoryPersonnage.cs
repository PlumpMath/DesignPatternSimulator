using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.fabrique.personnage
{
	public abstract class FactoryPersonnage {
	
		public FactoryPersonnage() {}

		public abstract Personnage CreatePersonnage(DesignPatternSimulator.designpattern.factory.personnage.eTypePersonnage type, Organisation org, string nom);

    }
}