using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using DesignPatternSimulator.designpattern.factory.personnage.guerredugolf.FactoryPersonnageGuerreDuGolf;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.observateur;

namespace DesignPatternSimulator.designpattern.strategie.main
{
    public class Application
    {

		public static void main(String[] args)
		{
			SimulationDeJeu sdj = new SimulationDeJeu();
			sdj.CreatePersonnagesDuJeu(new FactoryPersonnageMoyenAge());
			//sdj.CreatePersonnagesDuJeu(new FactoryPersonnageGuerreDuGolf());
			//sdj.FaireCrierToutLeMonde();
			Console.WriteLine("--------");
			sdj.showAllPersonnage();
			Console.WriteLine("--------");
			//sdj.PartirAuCombat();
			sdj.AfficherLesUploads();
			Console.WriteLine("--------");
			sdj.changeEtat(eMode.EN_GUERRE);
			sdj.AfficherLesUploadsObservateur();
            Console.WriteLine("--------");
            sdj.changeEtat(eMode.EN_PAIX);
			sdj.AfficherLesUploadsObservateur();
		
		}

    }
}