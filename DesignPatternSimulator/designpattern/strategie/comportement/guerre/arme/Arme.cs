namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.arme
{
    public abstract class Arme
    {
        public string Name { get; set; }
        public int Impact { get; set; }

        public Arme(string nom, int imp)
        {
            this.Name = nom;
            this.Impact = imp;
        }
    }
}