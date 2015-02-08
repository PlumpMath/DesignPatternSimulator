using DesignPatternSimulator.designpattern.fabrique.personnage;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.fabrique.personnage.guerre
{
    public class FactoryPersonnageMoyenAge : FactoryPersonnage
    {

        public FactoryPersonnageMoyenAge() : base()
        {

        }

        public override Personnage CreatePersonnage(personnage.eTypePersonnage type, Organisation org, string nom)
        {

            //if (com.designpattern.factory.personnage.moyenage.eTypePersonnage.valueOf(type.toString()) != null)
            //{
                switch (type)
                {
                    case personnage.eTypePersonnage.Indefini:
                        return null;
                    case personnage.eTypePersonnage.Archer:
                        return new Archer(org, nom);
                    case personnage.eTypePersonnage.Chevalier:
                        return new Chevalier(org, nom);
                    case personnage.eTypePersonnage.Fantassin:
                        return new Fantassin(org, nom);
                    case personnage.eTypePersonnage.Princesse:
                        return new Princesse(null, nom);
                    default:
                        break;
                }
            //}

            return null;
        }




    
    }
}