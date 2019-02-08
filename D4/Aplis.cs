using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Aplis
    {
        /// <summary>
        /// Apļa krāsa
        /// </summary>
        public string Krasa;

        /// <summary>
        /// Apļa radiuss
        /// </summary>
        public int Radiuss;

        public void Perimetrs()
        {
            Console.WriteLine("Apla perimetrs = {0}", 2 * Math.PI * Radiuss);
        }

        public void Laukums()
        {
            Console.WriteLine("Apla laukums = {0}", Math.PI * Radiuss * Radiuss);
        }

        public void KrasasNosaukums() // jeb KrasasIzvade piemeram
        {
            Console.WriteLine("Krasa = {0}", Krasa);
        }

    }
}
