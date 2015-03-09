using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.fabrique.personnage.guerre
{
    public class FactoryPersonnageDame : FactoryPersonnage
    {

        public FactoryPersonnageDame() : base()
        {

        }

        public override Personnage CreatePersonnage(personnage.eTypePersonnage type, Organisation org, string nom)
        {

                switch (type)
                {
                    case personnage.eTypePersonnage.PionBlanc:
                        return new PionBlanc(org,nom);
                    case personnage.eTypePersonnage.PionNoir:
                        return new PionNoir(org, nom);
                 
                    default:
                        break;
                }
         

            return null;
        }




        public override Personnage CreateObject(string type, string nom)
        {
            throw new System.NotImplementedException();
        }
    }
}