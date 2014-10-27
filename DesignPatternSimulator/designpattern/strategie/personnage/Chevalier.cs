using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Chevalier : Personnage
    {

        public Chevalier(Organisation org, string sonNom)
            : base(org, sonNom, new ComportementDeChevalier())
        {

        }

        public override void Afficher()
        {
            //System.out.println("je me prenomme " + super.getNom() + " chevalier nommé par le roi fou \n\tet heritier du chateau fort");
        }

        public override string SeDeplacer()
        {
            // TODO Auto-generated method stub
            return "je galope, je galope";
        }

        public override void Update()
        {
            base.Update();
        }

    }
}