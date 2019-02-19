using System;
using System.Collections.Generic;
using System.Text;

namespace D9
{
    public class Aplis : IGeometriskaFigura
    {
        public double Radius;

        public double Laukums(double radius)
        {
            Radius = radius;
            return (radius * radius) * Math.PI;
        }

        public string nosaukums()
        {
            return "Aplis";
        }

        public double Perimetrs(double radius)
        {
            Radius = Radius;

            return 2 * Math.PI * Radius;

        }

        public double Perimetrs()
        {
            throw new NotImplementedException();
        }
    }
}
