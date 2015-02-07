﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class Epee : ArmeAbstraite
    {
        public Epee()
        {
            base.Nom = EnumArme.Epee.ToString();
            base.PAtk = 2000;
            base.MAtk = 500;
        }
    }
}
