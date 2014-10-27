using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator.designpattern.observateur.parent
{
    public abstract class SujetObserveAbstrait
    {

        public List<ObservateurAbstrait> lesObservateurs;

        protected SujetObserveAbstrait() {
        lesObservateurs = new List<ObservateurAbstrait>();
	}

        public void Attach(ObservateurAbstrait unObservateur)
        {
            lesObservateurs.Add(unObservateur);
        }

        public void DeAttach(ObservateurAbstrait unObservateur)
        {
            lesObservateurs.Remove(unObservateur);
        }

        public void Update() {
		foreach(ObservateurAbstrait observateur in lesObservateurs) {
			observateur.Update();
		}
	}

    }
}