using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat.parent;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat
{
	public class ComportementDeChevalier : ComportementDeCombat {

		public override string combattre() {
			return "je me bats à cheval";
		}

	}
}