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

        public string GetName()
        {
            return base.Name;
        }

        public int GetImpact()
        {
            return base.Impact;
        }
}
}