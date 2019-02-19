using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1
{
    class Vertejums
    {

        public Macibu_Prieksmets Macibu_Prieksmets;

        public Skolens Skolens;

        public int Atzime; 


        public void Info()
        {
            Console.WriteLine("Skolens {0}{1}, mācību priekšmetā {2} saņēma {3}", Skolens.Vards, Skolens.Uzvards, Macibu_Prieksmets, Atzime);

        }
    }
}
