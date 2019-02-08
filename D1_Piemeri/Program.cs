using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Piemeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            //tekstaIzvade();
            //tekstaIzvadeArParametru("teksts no funkcijas ar parametru");
            //tekstaIevade();
            vecumaIevade();


            Console.Read();

            //komentārs

            /* vairāku rindu 
             * komentārs
             */
        }

        static void tekstaIzvade()
        {
            Console.WriteLine("Funkcijas izvadīts teksts");
        }

        static void tekstaIzvadeArParametru(string teksts)
        {
            Console.WriteLine("Izvade: " + teksts);
        }

        static void tekstaIevade()
        {
            //izvada
            Console.Write("Ievadi savu vārdu: ");

            //ievada
            string vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu: ");
            string uzvards = Console.ReadLine();

            Console.Write("Tevi sauc " + vards + " " + uzvards);
        }

        static void vecumaIevade()
        {
            Console.Write("Ievadi savu vecumu: ");
            //string vecums = Console.ReadLine();
            // vai int skaitlis = Convert.ToInt32(vecums);
            // vai:
            //int skaitlis = int.Parse(Console.ReadLine());
            //skaitlis += 1;

            int skaitlis = int.Parse(Console.ReadLine()) + 1;

            Console.Write("Pēc gada tev būs " + skaitlis);
        }
        
    }
}


//om asatoma sad gamaja
// tamasoma jyutir gamaja
// mritjur ma amritam gamaja