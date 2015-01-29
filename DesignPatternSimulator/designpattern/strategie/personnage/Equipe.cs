using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.strategie.personnage
{
    public class Equipe 
    {
        private string nom;
        private int niveauEquipe;

        public List<Personnage> listePersonnage;// = new List<Personnage>();
        public Equipe(string nom)
        {
            this.nom = nom;
            this.niveauEquipe = 0;
        }


    }
}
