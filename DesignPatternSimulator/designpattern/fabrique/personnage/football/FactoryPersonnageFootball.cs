using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.fabrique.personnage.football
{
    public class FactoryPersonnageFootball : FactoryPersonnage
    {
        public FactoryPersonnageFootball()
            : base()
        {

        }

        public override strategie.personnage.Personnage CreatePersonnage(football.eTypePersonnageF type, observateur.Organisation org, string nom)
        {
            switch (type)
            {
                case eTypePersonnageF.attaquant:
                    return new Attaquant(org,nom);
                case eTypePersonnageF.defenseur:
                    return new Defenseur(org, nom);
                case eTypePersonnageF.gardien:
                    return new Gardien(org, nom);
                case eTypePersonnageF.milieu:
                    return new Milieu(org, nom);
                default:
                    break;
            }

            return null;

        }

        public override Personnage CreatePersonnage(guerre.eTypePersonnage type, observateur.Organisation org, string nom)
        {
            throw new NotImplementedException();
        }
    }
}