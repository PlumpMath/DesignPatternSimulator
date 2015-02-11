using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.strategie.personnage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.manger
{
    public abstract class MangerAbstract
    {
       public abstract void MangerPion(Pion pmangeur, Pion pAManger, EnvironnementDame plateau);
    }
}
