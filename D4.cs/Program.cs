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
            // Piemers();
            //aplaReikins();
            Uzdevums23();

            Console.ReadLine();
        }

        static void Uzdevums23()
        {
            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Vards = "Aigars";
            darbinieks.Uzvards = "Liepa";
            darbinieks.Dzivesvieta = new Adrese();
            darbinieks.Dzivesvieta.Valsts = "Latvija";
            darbinieks.Dzivesvieta.Pilseta = "Riga";
            darbinieks.Dzivesvieta.Iela = "Republikas Laukums";
            darbinieks.Darbavieta = new Adrese();
            darbinieks.Darbavieta.Valsts = "Latvija";
            darbinieks.Darbavieta.Pilseta = "Riga";
            darbinieks.Darbavieta.Iela = "Brivibas iela";

            darbinieks.Info();
                
        }

        static void aplaReikins()
        {
            Aplis ap1 = new Aplis(4);
            ap1.KonsolesIzvade();

        }

        static void Piemers()
        {
            Kvadrats kv1 = new Kvadrats(5);

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums = {0}", laukums);
            Console.WriteLine("Perimentrs = {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);
            kv2.KonsolesIzvade();

            Kvadrats kv3 = new Kvadrats()
            {
                malasGarums = 5
            };

            Kvadrats.FigurasNosaukums();

            Math.Round(3.1423245);

            // tas pats, kas:
            // Kvadrats kv3 = new Kvadrats();
            //kv3.malasGarums = 5;
        }
    }
}
