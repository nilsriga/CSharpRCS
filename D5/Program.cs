using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class Program
    {
        static void Main(string[] args)
        {

            //vaiDalas();
            //noSk();
            //lidzSk();
            //modinatajs();
            //fizzBuzz();
            //DzerienuAutomats();
            spele();


            Console.ReadLine();
        }

       /* static void DzerienuAutomats()
        {
            Console.WriteLine("Pieejamas Darbibas:");
            Console.WriteLine("1 - Iemaksat");
            Console.WriteLine("2 - pirkt");
            Console.WriteLine("3 - sanemt atlikumu");
            Console.WriteLine("e - partraukt");

            while(true)
            {
                Console.Write("Ievadi darbibu:");
                string darbiba = Console.ReadLine();

                switch(darbiba)
                {
                    case "e":
                        return; // partrauc darbibu
                    case "1":
                        Console.Write("Ievadi summu: ");
                        double summa = double.Parse(Console.ReadLine());
                        dzerienu.Iemaksat(summa);
                        break;
                    case "2":
                        dzerienu.PirktDzerienu();
                        break;
                    case "3":
                        dzerienu.SanemtAtlikumu();
                        break;
                }
            }
        }
        */

        static void spele()
        {
            Console.WriteLine("Uzminiet kas par vardu spiezot atsevistus burtus.");

            string[] vardi = { "kaja", "skurstenis", "ilze", "dators", "mezgines", "masina", "lego", "glomerofiltracija", "anatomija", "aka", "udens"};

            Random random = new Random();

            int randomSkaitlis = random.Next(0, 10);

            string randomVards = vardi[randomSkaitlis];

            string atminVards = "";

            for (int i = 0; i <= randomVards.Length - 1; i++)
            {
                atminVards += "*";
            }

            while (atminVards.Contains("*"))
            {


                Console.WriteLine(atminVards);

                    Console.Write("Uzrakstiet iespejamo burtu: ");
                    string burts = Console.ReadLine();
                    burts.ToLower();
                    if (randomVards.Contains(burts))
                    {
                        int burtsIndex = 0;

                        while (burtsIndex != -1)
                        {

                            burtsIndex = randomVards.IndexOf(burts, burtsIndex);
                            if (burtsIndex != -1)
                        {
                            atminVards = atminVards.Remove(burtsIndex, 1);
                            atminVards = atminVards.Insert(burtsIndex, burts);
                            Console.WriteLine(atminVards);
                            burtsIndex++;
                        }
                            
                        }

                    }

                

            }




            spele();

        }

        static void fizzBuzz()
        {
            Console.WriteLine("Ievadiet sakuma skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet beigu skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            for (int i = sk1; i <= sk2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("{0}, ", "FizzBuzz");
                    continue;
                } else if (i % 3 == 0)
                {
                    Console.Write("{0}, ", "Fizz");
                    continue;
                }else if (i % 5 == 0)
                {
                    Console.Write("{0}, ", "Buzz");
                    continue;
                } else
                {
                    Console.Write("{0}, ", i);

                }


            }

            Console.WriteLine("");

            fizzBuzz();

        }


        static void modinatajs()
        {
            Console.WriteLine("Ievadiet nedelas dienu (P, O, T, C, Pk, S, Sv): ");
            string diena = Console.ReadLine();

            Console.WriteLine("Vai ir atvalinajums (\"J\" vai \"N\"): ");
            string atvalinajums = Console.ReadLine();

            string dienaSk = "";

            string state = "";


            switch (diena)
            {
                case "P":
                    dienaSk = "D";
                    break;
                case "O":
                    dienaSk = "D";
                    break;
                case "T":
                    dienaSk = "D";
                    break;
                case "C":
                    dienaSk = "D";
                    break;
                case "Pk":
                    dienaSk = "D";
                    break;
                case "S":
                    dienaSk = "B";
                    break;
                case "Sv":
                    dienaSk = "B";
                    break;
            }

            state = dienaSk + atvalinajums;

            switch (state)
            {
                case "DN":
                    Console.WriteLine("7:00");
                    break;
                case "DJ":
                    Console.WriteLine("10:00");
                    break;
                case "BN":
                    Console.WriteLine("10:00");
                    break;
                case "BJ":
                    Console.WriteLine("Modinatajs Izslegts");
                    break;

            }

            modinatajs();
        }



        static void lidzSk()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sk; i++)
            {
                if (i == 5)
                {
                    continue;
                } else
                {
                    Console.Write("{0}, ", i);
                }

            }

            lidzSk();
        }

        static void noSk()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            for (int i = sk; i > 0; i--)
            {
                Console.Write("{0}, ", i);
            }

            noSk();
        }

        static void vaiDalas()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            if (sk % 3 == 0)
            {
                Console.WriteLine("Skaitlis dalās ar 3");
            } else
            {
                Console.WriteLine("Skaitlis nedalās ar 3");
            }

            vaiDalas();
            
        }

    }
}
