using DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent
{
    public abstract class ArmeAFeu : Arme
    {

        public int NbOfBulllet { get; set; }
        public int NbOfRecharge { get; set; }

        public ArmeAFeu(string nom, int imp, int nbBullet, int nbRecharge)
            : base(nom, imp)
        {
            this.NbOfBulllet = nbBullet;
            this.NbOfRecharge = nbRecharge;
        }

        public override int GetNumberOfRecharge()
        {
            return NbOfRecharge;
        }

        public override int GetNumberOfBullet()
        {
            return NbOfBulllet;
        }

        public override string GetName()
        {
            return base.Name;
        }

        public override int GetImpact()
        {
            return base.Impact;
        }
    }
}