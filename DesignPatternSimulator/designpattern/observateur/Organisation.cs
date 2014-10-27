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

        public eMode GetEMode()
        {
            return this.etatFonctionnement;
        }

        public void SetEMode(eMode etat)
        {
            this.etatFonctionnement = etat;
            this.Update();
        }

    }
}