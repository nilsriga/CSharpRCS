using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfeisPiemers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.// vel jāuztaisa ievade

            Taisnsturis t1 = new Taisnsturis(10.5, 20);
            Console.WriteLine("Taisnstura laukums = {0}", t1.Laukums());
            Console.WriteLine("Taisnstura perimetrs = {0}", t1.Perimetrs());
            Aprekini(t1);


            Aplis a1 = new Aplis(5.7);

            Console.WriteLine("Apla laukums = {0}", a1.Laukums());
            Console.WriteLine("Apla perimetrs = {0}", a1.Perimetrs());
            Aprekini(a1);

            Kvadrats k = new Kvadrats(10.55);
            Aprekini(k);

            Console.ReadLine();
        }

        static void Aprekini (IGeometriskaFigura f)
        {
            Console.WriteLine("{1} laukums = {0}", f.Laukums(), f.Nosaukums());
            Console.WriteLine("{1} perimetrs = {0}", f.Perimetrs(), f.Nosaukums());

        }

        static void Aprekini(Taisnsturis t)
        {
            Console.WriteLine("Taisnstura laukums = {0}", t.Laukums());
            Console.WriteLine("Taisnstura perimetrs = {0}", t.Perimetrs());

        }

        static void Aprekini(Aplis a)
        {
            Console.WriteLine("Apla laukums = {0}", a.Laukums());
            Console.WriteLine("Apla perimetrs = {0}", a.Perimetrs());

        }
    }
}
