using DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent;
namespace com.designpattern.strategie.comportement.guerre.arme.afeu
{
    public class Colt45 : ArmeAFeu
    {

        private string nameOfGun;
        private int nbOfRecharge;
        private int nbOfBullet;
        private int impact;

        public Colt45(string nom, int imp, int nbBullet, int nbRecharge)
            : base(nom, imp, nbBullet, nbRecharge)
        {
            nameOfGun = nom;
            impact = imp;
            nbOfRecharge = nbRecharge;
            nbOfBullet = nbBullet;

        }

        public override int getNumberOfRecharge()
        {
            return this.nbOfRecharge;
        }

        public override int getNumberOfBullet()
        {
            return this.nbOfBullet;
        }

        public override string getName()
        {
            return this.nameOfGun;
        }

        public override int getImpact()
        {
            return this.impact;
        }

    }
}