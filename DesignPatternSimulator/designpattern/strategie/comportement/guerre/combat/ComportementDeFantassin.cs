using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat.parent;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat
{
    public class ComportementDeFantassin : ComportementDeCombat
    {

        public override string Combattre()
        {
            return "je me bats avec une hache";
        }

    }
}