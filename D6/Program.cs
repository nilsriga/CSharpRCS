using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6
{
    class Program
    {
        static void Main(string[] args)
        {
            //piemers();
            //vaiIrSk();
            //pretejaSeciba();
            //pretejaSeciba2();
            cikPieci();

            Console.ReadLine();
        }



        static void cikPieci()
        {
            List<int> skaitli = new List<int>();
            while (true)
            {
                Console.Write("Ievadi skaitli:");
                string vertiba = Console.ReadLine();
                if (string.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                skaitli.Add(int.Parse((vertiba)));
            }

            int cikPieci = 0;

            //Console.WriteLine(saraksts.Count(p => p.5 == true))

            foreach(int vertiba in skaitli)
            {
                if (vertiba == 5)
                {
                    cikPieci++;
                }
            }

            Console.WriteLine("saraksta ir {0}", cikPieci );

            cikPieci = skaitli.Count(sk => sk == 5);
            Console.WriteLine("saraksta ir {0}", cikPieci);
            
        }

        
        static void pretejaSeciba()
        {
            
            int[] masivs = new int[5];

            for (int i = 0; i<masivs.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli {0}: ", i);
                masivs[i] = int.Parse(Console.ReadLine());
            }

            for( int i = masivs.Length-1; i>=0; i--)
            {
                Console.Write("{0}, ", masivs[i]);
            }
        }

        static void pretejaSeciba2()
        {
            List<int> saraksts = new List<int>();

            while (true) {
                Console.Write("Ievadi skaitli:");
                string vertiba = Console.ReadLine();
                if(string.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int skaitlis = int.Parse(vertiba);

                if(skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);

            }

            //int elementuSkaits = saraksts.Count;
            saraksts.Reverse();

            Console.WriteLine(string.Join(", ", saraksts));

        }

        static void vaiIrSk()
        {

            Console.WriteLine("Pārbaudiet vai skaitlis x ir masīvā? Kāds ir skaitlis x: ");
            int sk = int.Parse(Console.ReadLine());
            int[] masivs = { 0, 10, 20, 30, 40, 50 };

            bool irAtrasts = false;
            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == sk)
                {
                    Console.WriteLine("Skaitlis ir atrasts pozicijā {0}", i);
                    irAtrasts = true;
                    break;
                }

                if (!irAtrasts)
                {
                    Console.WriteLine("Skaitlis nav masiva!");
                }

                irAtrasts = masivs.Contains(sk);
            }
        }
            
        static void piemers()
        {
            int sk1;
            int sk2;

            int[] skaitli = new int[5]; // masivs ar 5 elementiem - int
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            // izmetīs kļudu - IndexOutOfRange
           // skaitli[5] = 6;

            int skaitlis = skaitli[3]; //4

            for (int i = 0; i < skaitli.Length; i++)
            {
                int vertiba = skaitli[i];
                Console.WriteLine(vertiba);
            }

            foreach(int vertiba in skaitli)
            {
                Console.WriteLine(vertiba);
            }


        }
    }
}
