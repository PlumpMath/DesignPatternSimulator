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
            return base.GetNumberOfRecharge();
        }

        public override int getNumberOfBullet()
        {
            return base.GetNumberOfBullet();
        }

        public override string getName()
        {
            return base.GetName();
        }

        public override int getImpact()
        {
            return base.GetImpact();
        }

    }
}