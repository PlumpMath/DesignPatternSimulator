using DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent
{
    public abstract class ArmeAFeu : Arme
    {

        private int nbOfBulllet;
        private int nbOfRecharge;

        public ArmeAFeu(string nom, int imp, int nbBullet, int nbRecharge)
            : base(nom, imp)
        {
            this.nbOfBulllet = nbBullet;
            this.nbOfRecharge = nbRecharge;
        }
        public abstract int getNumberOfRecharge();
        public abstract int getNumberOfBullet();
    }
}