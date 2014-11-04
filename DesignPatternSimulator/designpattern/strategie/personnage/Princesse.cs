using DesignPatternSimulator.designpattern.observateur;
namespace DesignPatternSimulator.designpattern.strategie.personnage
{
	public class Princesse : Personnage {

		public Princesse(Organisation org, string sonNom)
			: base(null, sonNom, null)
		{

		}

        public override void Afficher()
        {
			//System.out.println("je suis la princesse " + super.getNom() + " prosterne toi devant ma beauté");
		}

        public override string SeDeplacer()
        {
			// TODO Auto-generated method stub
			return "quelle est belle ma demarche !";
		}

		public override void update() {
		}

	}
}