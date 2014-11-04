using DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent;
namespace com.designpattern.strategie.comportement.guerre.arme.afeu
{
    public class Pistolet : ArmeAFeu
    {
        public Pistolet(string nom, int imp, int nbBullet, int nbRecharge)
            : base(nom, imp, nbBullet, nbRecharge)
        {

        }

        public override int getNumberOfRecharge()
        {
            return base.getNumberOfRecharge();
        }

        public override int getNumberOfBullet()
        {
            return base.getNumberOfBullet();
        }

        public override string getName()
        {
            return base.getName();
        }

        public override int getImpact()
        {
            return base.getImpact();
        }

    }
}