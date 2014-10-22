using DesignPatternSimulator.designpattern.observateur.parent;

namespace DesignPatternSimulator.designpattern.observateur
{
    public class Organisation : SujetObserveAbstrait
    {

        public eMode etatFonctionnement;

        public Organisation()
            : base()
        {
            this.etatFonctionnement = eMode.NON_DEFINI;
        }

        public eMode getEMode()
        {
            return this.etatFonctionnement;
        }

        public void setEMode(eMode etat)
        {
            this.etatFonctionnement = etat;
            this.Update();
        }

    }
}