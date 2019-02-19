using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            Karatavas k = new Karatavas();

            string spelesi = "y";
            while (spelesi == "y")
            {
                k.SaktSpeli();
                Console.WriteLine(k.Vards());

                while (!k.IrAtminets())
                {
                    Console.Write("Ievadi burtu: ");
                    string burts = Console.ReadLine();

                    if (k.Minet(burts))
                    {
                        Console.WriteLine(k.Vards());
                    }
                    else
                    {
                        Console.WriteLine("Burts nav saja varda!");
                    }
                }

                Console.WriteLine("Vards ir atminets, tu uzvareji! Spelesi velreiz? (y vai n)");
                spelesi = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Paldies par speli");

        }
    }
}
