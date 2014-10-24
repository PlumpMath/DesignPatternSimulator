namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme
{
    public abstract class Arme
    {
        private string name;
        private int impact;

        public Arme(string nom, int imp)
        {
            this.name = nom;
            this.impact = imp;
        }

        public abstract string getName();
        public abstract int getImpact();
    }
}