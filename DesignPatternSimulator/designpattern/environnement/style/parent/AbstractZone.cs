namespace DesignPatternSimulator.designpattern.environnement.style.parent
{
    public abstract class AbstractZone
    {

        public abstract AbstractZone CreerZone();
        public abstract AbstractZone CreerZone(string s);

       //doit �tre utilis�
        public abstract AbstractZone CreerZone(string s, int x, int y);
    }
}