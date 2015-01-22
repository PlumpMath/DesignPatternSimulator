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

        public override Personnage CreatePersonnage(eTypePersonnage type, Organisation org, string nom)
        {

            //if (com.designpattern.factory.personnage.moyenage.eTypePersonnage.valueOf(type.toString()) != null)
            //{
                switch (type)
                {
                    case eTypePersonnage.Indefini:
                        return null;
                    case eTypePersonnage.Archer:
                        return new Archer(org, nom);
                    case eTypePersonnage.Chevalier:
                        return new Chevalier(org, nom);
                    case eTypePersonnage.Fantassin:
                        return new Fantassin(org, nom);
                    case eTypePersonnage.Princesse:
                        return new Princesse(null, nom);
                    default:
                        break;
                }
            //}

            return null;
        }


        public override Personnage CreatePersonnage(football.eTypePersonnageF type, Organisation org, string nom)
        {
            throw new System.NotImplementedException();
        }
    }
}