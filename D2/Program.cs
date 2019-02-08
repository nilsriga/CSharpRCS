using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD5();
            //vaiVienadi();
            //dienasMenesi();
            //galvaspilseta();
            //kalku();
            gradi();

            Console.ReadLine();
        }

        static void gradi()
        {
            Console.WriteLine("Ievadiet gradus: ");
            float sk1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet gradu mervienibu: ");
            string mer1 = Console.ReadLine().ToLower();

            Console.WriteLine("Izvelieties mervienibu uz kadu parverst gradus");
            string mer2 = Console.ReadLine().ToLower();

            var mesh = mer1 + mer2;


            switch (mesh)
            {
                case "cf":
                    Console.WriteLine(sk1 * (float)1.8 + 32);
                    break;
                case "ck":
                    Console.WriteLine(sk1 + (float)273.15);
                    break;
                case "fc":
                    Console.WriteLine(sk1 - 32 * (float)(9/5));
                    break;
                case "fk":
                    Console.WriteLine(sk1 - (float)32 * (9/5) + 273.1);
                    break;
                case "kc":
                    Console.WriteLine(sk1 - (float)273.15 * (9/5) + 32);
                    break;
                case "kf":
                    Console.WriteLine((sk1 - 273.15) * ((float)9/5) + 32);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            gradi();

        }

        static void kalku()
        {
            Console.WriteLine("Ievadiet 1. skaitli: ");
            float sk1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet 2. skaitli: ");
            float sk2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Izvelieties darbibu: +, -, * vai / ");
            string darbiba = Console.ReadLine();


            switch (darbiba)
            {
                case "+":
                    Console.WriteLine(sk1 + sk2);
                    break;
                case "-":
                    Console.WriteLine(sk1 - sk2);
                    break;
                case "*":
                    Console.WriteLine(sk1 * sk2);
                    break;
                case "/":
                    Console.WriteLine(sk1 / sk2);
                    break;
            }

            kalku();

        }

        static void galvaspilseta()
        {
            Console.WriteLine("Ievadiet valsti: ");
            string valsts = Console.ReadLine().ToLower();

            switch (valsts)
            {
                case "danija":
                    Console.WriteLine("Kopenhagena");
                    break;
                case "amerika":
                    Console.WriteLine("Vasingtona");
                    break;
                case "kenija":
                    Console.WriteLine("Nairobi");
                    break;
                case "kina":
                    Console.WriteLine("Sanhaja");
                    break;
                case "polija":
                    Console.WriteLine("Varsava");
                    break;
                default:
                    Console.WriteLine("Tada {0} {1}", valsts, "neeksiste!");
                    break;

            }
            galvaspilseta();

        }

        static void dienasMenesi()
        {
            Console.Write("Ievadiet menesa pirmos 3 burtus: ");
            string menesis = Console.ReadLine().ToLower();

            if (menesis == "jan")
            {
                Console.Write(DateTime.DaysInMonth(2018, 01) + " Dienas");
            }                                                    
            else if (menesis == "feb")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 02) + " Dienas");
            }                                                    
            else if (menesis == "mar")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 03) + " Dienas");
            }                                                    
            else if (menesis == "apr")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 04) + " Dienas");
            }                                                    
            else if (menesis == "mai")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 05) + " Dienas");
            }
            else if (menesis == "jun")
            {
                Console.Write(DateTime.DaysInMonth(2018, 06) + " Dienas");
            }                                                    
            else if (menesis == "jul")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 07) + " Dienas");
            }                                                    
            else if (menesis == "aug")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 08) + " Dienas");
            }                                                    
            else if (menesis == "sep")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 09) + " Dienas");
            }                                                    
            else if (menesis == "okt")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 10) + " Dienas");
            }                                                    
            else if (menesis == "nov")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 11) + " Dienas");
            }                                                    
            else if (menesis == "dec")                           
            {                                                    
                Console.Write(DateTime.DaysInMonth(2018, 12) + " Dienas");
            }

            //3. variants

            switch(menesis)
            {
                case "apr":
                case "jun":
                case "sep":
                case "nov":
                    Console.WriteLine(" 30 Dienas");
                    break;                 
                case "feb":                
                    Console.WriteLine(" 28 Dienas");
                    break;                 
                default:                   
                    Console.WriteLine(" 31 Dienas");
                    break;              
            }

        }

        static void vaiVienadi()
        {
            Console.Write("Pirmais skaitlis: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Otrais skaitlis: ");
            int sk2 = int.Parse(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.WriteLine("Skaitli ir vienadi");
            }
            else
            {
                Console.WriteLine("Skaitli nav vienadi");
            }

            //vai
            // Console.Write(sk1 == sk2 ? "Skaitli ir vienadi!" : "Skaitli nav vienadi");

        }

        static void MD5()
        {
            Console.Write("Ievadi savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());

            if (vecums >18)
            {
                Console.WriteLine("Ir Pāri 18, jā");
            }
            else if ( vecums == 18)
            {
                Console.Write("Ir 18");
            }
            else
            {
                Console.Write("Nav 18");
            }

        }

    }
}
