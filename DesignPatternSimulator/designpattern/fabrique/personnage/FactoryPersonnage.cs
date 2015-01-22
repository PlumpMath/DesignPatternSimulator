using DesignPatternSimulator.designpattern.fabrique.personnage.football;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.fabrique.personnage
{
	public abstract class FactoryPersonnage {
	
		public FactoryPersonnage() {}

        //public abstract Personnage CreatePersonnage(eTypePersonnage type, Organisation org, string nom);
        public abstract Personnage CreatePersonnage(DesignPatternSimulator.designpattern.fabrique.personnage.guerre.eTypePersonnage type, Organisation org, string nom);
        public abstract Personnage CreatePersonnage(eTypePersonnageF type, Organisation org, string nom);

    }
}