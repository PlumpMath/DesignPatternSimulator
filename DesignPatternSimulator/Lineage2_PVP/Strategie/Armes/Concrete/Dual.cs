﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class Dual : ArmeAbstraite
    {
        public Dual()
        {
            base.Nom = EnumArme.DualHache.ToString();
            base.PAtk = 2500;
            base.MAtk = 500;
        }
    }
}
