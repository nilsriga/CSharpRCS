using System;
using System.Collections.Generic;
using System.Text;

namespace D9
{
    public class Taisnsturis : IGeometriskaFigura
    {
        public double Mala1;

        public double Mala2;

        public Taisnsturis(double mala1, double mala2)
        {
            Mala1 = mala1;
            Mala2 = mala2;
        }

        public double Perimetrs(mala1, mala2)
        {
            Mala1 = Mala1;

            Mala2 = Mala2;

            return (Mala1 + Mala2) * 2;
        }

        public double Laukums()
        {
            return Mala1 * Mala2
        }

        public virtual string Nosaukums()
        {
            return "Taisnsturis";

        }
    }
}
