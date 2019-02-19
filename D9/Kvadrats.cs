using System;
using System.Collections.Generic;
using System.Text;

namespace D9
{
    class Kvadrats : Taisnsturis
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
