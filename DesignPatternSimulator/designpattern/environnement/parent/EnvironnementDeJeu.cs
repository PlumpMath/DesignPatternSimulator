using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.environnement.parent
{
    public abstract class EnvironnementDeJeu
    {
	    public abstract AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique);
    }
}
