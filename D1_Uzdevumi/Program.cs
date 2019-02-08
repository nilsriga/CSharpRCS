using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ievade1();

            //toKelvin();

            //videjais();

            reizinajums();

            Console.Read();
        }

        static void videjais()
        {
            Console.Write("Skaitlis 1 : ");
            float sk1 = float.Parse(Console.ReadLine());

            Console.Write("Skaitlis 2 : ");
            float sk2 = float.Parse(Console.ReadLine());

            Console.Write("Skaitlis 3 : ");
            float sk3 = float.Parse(Console.ReadLine());

            Console.Write("Skaitlis 4 : ");
            float sk4 = float.Parse(Console.ReadLine());

            float videjais = (sk1 + sk2 + sk3 + sk4) / 4f;


            Console.WriteLine("Vidējais aritmētiskais ir: " + videjais);

        }

        static void toKelvin()
        {
            Console.Write("Temperatūra pēc Celsija: ");
            float celsijaTemp = float.Parse(Console.ReadLine());

            float kelvin = celsijaTemp + (float)273.15;
            // var arī (float)273.15 vietā rakstīt 273.15f.... Standartā C# uztver
            //ka tiek ievadīts double, un tāpēc, ka mainīgie ir float, tas nestrādā jo ir divi datu tipi

            float faren = celsijaTemp * (float)1.8 + 32;

            Console.WriteLine("Kelvina = " + kelvin);
            Console.WriteLine("Fārenheita = " + faren);

        }

        static void Ievade1()
        {
            Console.Write("Skaitlis 1 : ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Skaitlis 2 : ");
            int sk2 = int.Parse(Console.ReadLine());

            int summa = sk1 + sk2;
            int starpiba = sk1 - sk2;
            int reizinajums = sk1 * sk2;
            float dalijums = sk1 / (float)sk2;


            Console.WriteLine("Summa = " + summa);
            Console.WriteLine("Starpība = " + starpiba);
            Console.WriteLine("Reizinājums = " + reizinajums);
            Console.WriteLine("Dalījums = " + dalijums);

        }
        static void reizinajums()
        {
            Console.Write("Skaitlis 1: ");
            float sk1 = float.Parse(Console.ReadLine());

            Console.Write("Skaitlis 2: ");
            float sk2 = float.Parse(Console.ReadLine());

            Console.Write("Skaitlis 3: ");
            float sk3 = float.Parse(Console.ReadLine());

            float reizinajums = sk1 * sk2 * sk3;

            Console.Write("Reizinājums ir: " + reizinajums);

        }
    }
}
