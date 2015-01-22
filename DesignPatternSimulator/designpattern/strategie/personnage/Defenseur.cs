using DesignPatternSimulator.designpattern.observateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Defenseur : Personnage
    {
        public Defenseur(Organisation org, string nom) : base( org, nom)
        {

        }
    }
}
