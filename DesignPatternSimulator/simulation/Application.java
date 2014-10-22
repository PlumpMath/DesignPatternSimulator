package com.designpattern.strategie.main;

import com.designpattern.factory.personnage.guerredugolf.FactoryPersonnageGuerreDuGolf;
import com.designpattern.factory.personnage.moyenage.FactoryPersonnageMoyenAge;
import com.designpattern.observater.eMode;

public class Application {

	public static void main(String[] args) {
		SimulationDeJeu sdj = new SimulationDeJeu();
		//sdj.CreatePersonnagesDuJeu(new FactoryPersonnageMoyenAge());
		sdj.CreatePersonnagesDuJeu(new FactoryPersonnageGuerreDuGolf());
		//sdj.FaireCrierToutLeMonde();
		System.out.println("--------");
		sdj.showAllPersonnage();
		System.out.println("--------");
		//sdj.PartirAuCombat();
		sdj.AfficherLesUploads();
		System.out.println("--------");
		sdj.changeEtat(eMode.EN_GUERRE);
		sdj.AfficherLesUploadsObservateur();
		System.out.println("--------");
		sdj.changeEtat(eMode.EN_PAIX);
		sdj.AfficherLesUploadsObservateur();
		
	}
}
