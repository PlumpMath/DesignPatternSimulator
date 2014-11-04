using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Archer : Personnage
    {

        public Archer(string sonNom)
            : base(null, sonNom, new ComportementDeArcher())
        {
			
        }
        public Archer(Organisation org, string sonNom)
            : base(org, sonNom, new ComportementDeArcher())
        {
 
        }

        public override void Afficher()
        {
		    //System.out.println("je suis " + super.getNom() + " arché de MontGennevieve");
	    }

        public override string SeDeplacer()
        {
            // TODO Auto-generated method stub
            return "je suis plus fort que l'elf, Legolas";
        }

        public override void update()
        {
            base.update();
        }

    }
}