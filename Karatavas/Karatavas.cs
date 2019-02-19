using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karatavas
{
    public class Karatavas
    {
        private string minamaisVards;
        private string[] atminetaisVards;
        private string[] vardnica =
        {
            "sokolade",
            "maiznica",
            "teorija",
            "mukene",
            "krokodils"
        };

        public Karatavas()
        {

        }

        public void SaktSpeli()
        {
            Random rnd = new Random();
            int pozicija = rnd.Next(vardnica.Length);

            minamaisVards = vardnica[pozicija];

            atminetaisVards = new string[minamaisVards.Length];

            for (int i = 0; i <= minamaisVards.Length-1; i++)
            {
                atminetaisVards[i] = "*";
            }
            

            // 1. Aizpilda minamaisVards ar izveleto vardu
            // 2. atminetaisVards aizpilda ar * tik, cik varda burtu

        }

        public bool IrAtminets()
        {
            // 1. Nosaka un atgriez vai vārds ir atminēts 
            // atgriež true/false
            foreach (string burts in atminetaisVards)
            {
                if (burts == "*")
                {
                    return false;
                }
            }
            return true;

            //2. var
            //return !atminamaisVards.Contains("*");
        }


        public bool Minet(string burts)
        {

            if (String.IsNullOrEmpty(burts))
            {
                return false;
            }
            if (!minamaisVards.Contains(burts))
            {
                return false;
            }
            burts = burts.ToLower();
            int pozicija = minamaisVards.IndexOf(burts);
            while(pozicija != -1)
            {
                atminetaisVards[pozicija] = burts;
                pozicija = minamaisVards.IndexOf(burts, pozicija + 1);
            }
            //1. Atgriež false, ja burts nav vārdā
            //2. atgriež true, ja vurts ir vārdā.
            // aizvieto minamaisVards ar simbolu * ar burtu konkrētajā pozicija
            // ... minamaisVards.indwxOF()

            return true;
        }

        public string Vards ()
        {
            string result = string.Join("", atminetaisVards);
            Console.WriteLine(result);
            // 1. atgriež minamaisVards kā tekstu (string)
            // Kristapa variants:
            /*string teksts = "";
            foreach(string burts in atminetaisVards)
            {
                teksts += burts;
            }
            return teksts;
            */
            // 3. variants

            return string.Join("", atminetaisVards);
        }
    }
}
