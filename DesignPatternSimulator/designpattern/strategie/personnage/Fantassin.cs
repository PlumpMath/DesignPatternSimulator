using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
	public class Fantassin : Personnage {
	
		public Fantassin(Organisation org, string sonNom)
			: base(org, sonNom, new ComportementDeFantassin())
		{

		}

		public override void Afficher() {
			//System.out.println("jay siu " + super.getNom() + " sol-da deux la gare-de roi ya-le");
		}

		public override string SeDeplacer() {
			// TODO Auto-generated method stub
			return "on est des tubes, on est pas des pots \nMais on a tout ce qu'il nous faut..";
		}

		public override void update() {
			base.update();
		}

	}
}