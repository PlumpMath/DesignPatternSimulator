using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    internal class Adaptateur : Cible
    {
        private readonly Adapte unAdapte = new Adapte();

        public void Operation()
        {
            unAdapte.OperationSpécifique();
        }
    }
}
