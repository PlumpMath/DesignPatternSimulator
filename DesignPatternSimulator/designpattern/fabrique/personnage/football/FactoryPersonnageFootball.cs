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

        public override strategie.personnage.Personnage CreatePersonnage(eTypePersonnage type, observateur.Organisation org, string nom)
        {
            switch (type)
            {
                case eTypePersonnage.attaquant:
                    return new Attaquant(org,nom);
                case eTypePersonnage.defenseur:
                    return new Defenseur(org, nom);
                case eTypePersonnage.gardien:
                    return new Gardien(org, nom);
                case eTypePersonnage.milieu:
                    return new Milieu(org, nom);
                default:
                    break;
            }

            return null;

        }


    }
}