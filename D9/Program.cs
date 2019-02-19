using System;

namespace D9
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplis a1 = new Aplis(23);
            Console.WriteLine("Apla laukums = {0}", a1.Laukums());
            Console.WriteLine("Apla perimetrs = {0}", a1.Perimetrs());

            Console.ReadLine();
        }

        static void Aprekini(IGeometriskaFigura f)
        {
            try
            {
                Console.Write("ievadi apla radiusu: ");
                double r = double.Parse(Console.ReadLine());

                Aplis a1 = new Aplis(r);
                Aprekini(a1);
            }
            catch(FormatException)
            {
                Console.WriteLine("Ieadita nekorekta vertiba");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Notika neparedzeta kluda!");
                Console.Write(ex.Message);
            }

            Console.Write("Ievadi apla radiusu:");
            double r = double.Parse(Console.ReadLine());

            string nosaukums = "";
            if (f is Taisnsturis)
            {
                nosaukums = "Taisnstura";
            }
            else if (f is Aplis)
            {
                nosaukums = "Apla";
            }
            Console.WriteLine("{1} laukums = {0}", f.Laukums(), f.Nosaukums);
            Console.WriteLine("{1} perimetrs = {0}", f.Perimetrs(), f.Nosaukums);
        }
    }
}
