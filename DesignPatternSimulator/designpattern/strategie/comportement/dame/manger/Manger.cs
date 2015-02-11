using DesignPatternSimulator.designpattern.environnement;
using DesignPatternSimulator.designpattern.environnement.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.comportement.dame.manger
{
    public class Manger : MangerAbstract
    {
        public override void MangerPion(personnage.Pion pmangeur, personnage.Pion pAManger, EnvironnementDame environnementDame)
        {
            pmangeur.AvancerManuellement(pAManger.Position.X, pAManger.Position.Y);
            pmangeur.PionManger += 1;
            environnementDame.Plateau.getZoneForFree().Single(c=>c.X == pAManger.Position.X && c.Y == pAManger.Position.Y).Occupe = false;
            pAManger.Position.Occupe = false;
            pAManger.Position = null;
        }
    }
}
