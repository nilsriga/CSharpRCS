using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Piemers();
            Uzdevums22();

            Console.ReadLine();
        }

        static void Uzdevums22()
        {
            Aplis a = new Aplis();
            a.Radiuss = 5;
            a.Krasa = "Sarkans";



            Console.WriteLine("Krasa ir {0}", Krasa);

            a.Laukums();
            a.Perimetrs();
            a.KrasasNosaukums();
        }





        static void Piemers()
        {
            Kvadrats kv1 = new Kvadrats(5);

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums = {0}", laukums);

            Kvadrats kv2 = new Kvadrats(10);
            Console.WriteLine("Perimetrs = {0}", kv2.laukums());

            Kvadrats kv3 = new Kvadrats()
            {
                malasGarums = 5,
                //
            };

            //tas pats, kas:
            //kvadrats kv3 = new kvadrats();
            //kv3.malasGarums = 5;

            Kvadrats.FigurasNosaukums();


            Math.Round(5.1231233);
        }

    }
}
