﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfeisPiemers
{
    public class Kvadrats : Taisnsturis
    {
        public Kvadrats(double mala) : base(mala, mala)
        {
            
        }

        public override string Nosaukums()
        {
            return "Kvadrats";
        }
    }
}
