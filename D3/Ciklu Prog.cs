using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CikluPiemers();
            //cikluSumma();
            //cikGadi();
            //paraSumma();
            //nSkSumma();
            //zimejums();
            //trijssturis();
            //pariVecums();
            //vaiIeksa();
            //vaiPara();
            //minMax();


            Console.ReadLine();

        }
        
        



        static void vaiPara()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            
            if (sk % 2 == 0)
            {
                Console.WriteLine("Ir para skaitlis.");
            } else
            {
                Console.WriteLine("Nav para skaitlis.");
            }
        }

        static void vaiIeksa()
        {
            Console.WriteLine("Ievadiet skaitli no -50 lidz 50: ");
            float sk = float.Parse(Console.ReadLine());

            if (sk >= -50 && sk <= 50)
            {
                Console.WriteLine("Skaitlis ir starp -50 un 50");
            } else
            {
                Console.WriteLine("Skaitlis ir arpus -50 un 50");
            }

            vaiIeksa();
        }

        static void pariVecums()
        {
            Console.WriteLine("Ievadiet savu vecumu: ");
            int vec = int.Parse(Console.ReadLine());

            if (vec > 50)
            {
                Console.WriteLine("Vecums parsniedz 50 gadus.");
            } else
            {
                Console.WriteLine("Vecums neparsniedz 50 gadus.");
            };

            pariVecums();
        }

        static void trijssturis()
        {
            Console.Write("Kādas dimensijas?: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);

                }

                Console.WriteLine();
            }
            for (int rinda = N-1; rinda >= 1; rinda--)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);

                }

                Console.WriteLine();
            }
            trijssturis();
        }

        static void zimejums()
        {
            Console.Write("Kādas dimensijas?: ");
            int N = int.Parse(Console.ReadLine());
            
            for(int rinda = 1; rinda <= N; rinda++)
            {

                for (int kolona = 0; kolona <= N; kolona++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }

            zimejums();

        }


        static void nSkSumma()
        {

            Console.Write("Cik skaitlu ievadisi? ");
            int N = int.Parse(Console.ReadLine());

            int summa = 0;

            for(int i = 1; i <= N; i++)
            {
                Console.Write("Ievadiet {0}. skaitli: ", i);
                //int sk = int.Parse(Console.ReadLine());
                //summa += sk;
                summa += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summa = {0}:", summa);

            Console.WriteLine("Videja vertiba = {0}:", (summa / (float)N));
    

        }


        static void paraSumma()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i < sk+1; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                Console.WriteLine(i);
                summa += i;
            
            }

            Console.WriteLine(summa);

            paraSumma();

        }

        static void cikGadi()
        {
            Console.Write("Ievadiet gadu XXXX: ");
            int gads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            /*
            for (; gads <= robeza; gads++)
            {
                Console.WriteLine(gads);

            }
            */

            while(gads <= robeza)
            {
                Console.WriteLine(gads);
                gads++;
            }

            cikGadi();
        }
        static void CikluPiemers()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i < 11; i++)
            {
                // šitais liek visam kas ir aiz continune tapt izlaistam un pāriet uz nākamo iterāciju.
                if (i == 10)
                {
                    continue;
                }

                Console.WriteLine(i);

                /*if (i == 5)
                {
                    break;
                }*/


            }
            CikluPiemers();
        }
    }
}
