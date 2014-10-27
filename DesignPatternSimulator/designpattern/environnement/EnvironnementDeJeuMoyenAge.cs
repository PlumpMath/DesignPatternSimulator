using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre;

namespace DesignPatternSimulator.designpattern.environnement
{
	public class EnvironnementDeJeuMoyenAge : EnvironnementDeJeu {

		public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique) {
			PlateauDeJeu winterfell = new PlateauDeJeu();
			FactoryDeJeuGuerre factory = new FactoryDeJeuGuerre();
		
			List<Acces> casesWinterfell = new List<Acces>();
			casesWinterfell = factory.CreateCarre(10, 10);
		
			//int sizeCarre = Integer.valueOf(casesWinterfell.get(casesWinterfell.size()).secondZoneName().split(":")[1]);
		
			winterfell.SetZonesAcces(casesWinterfell);
			return winterfell;
		}

	}
}