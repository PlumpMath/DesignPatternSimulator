﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSimulator
{
    class Bague : BijouAbstrait
    {
        public Bague()
        {
            base.Nom = EnumBijou.Bague.ToString();
            base.MDef = 1000;
        }
    }
}
