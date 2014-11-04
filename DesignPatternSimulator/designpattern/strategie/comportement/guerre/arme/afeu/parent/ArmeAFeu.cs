using DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme;
namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme.afeu.parent
{
    public abstract class ArmeAFeu : Arme
    {

 

        public int nbOfBulllet { get; set; }
        public int nbOfRecharge { get; set; }
 
         public ArmeAFeu(string nom, int imp, int nbBullet, int nbRecharge)
             : base(nom, imp)
         {
             this.nbOfBulllet = nbBullet;
             this.nbOfRecharge = nbRecharge;
         }
        public override int getNumberOfRecharge()
        {
            this.nbOfRecharge;
        }

        public override int getNumberOfBullet()
        {
            this.nbOfBulllet;
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