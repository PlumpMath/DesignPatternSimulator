using DesignPatternSimulator.designpattern.observateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class PionNoir : Personnage
    {
        public int Position { get; set; }
        public PionNoir(Organisation org, String nom)
            : base(org, nom)
        {

        }
    }
}
