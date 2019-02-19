using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfeisPiemers
{
    public class Aplis : IGeometriskaFigura
    {
        public double Radius;

        public Aplis(double radius)
        {
            Radius = radius;
        }

        public Aplis()
        {
        }

        public double Laukums()
        {
            return Radius * Radius * Math.PI;
        }

        public double Perimetrs()
        {
            return 2 * Math.PI * Radius;
        }

        public string Nosaukums()
        {
            return "Aplis";
        }
    }
}
