using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Darbinieks
    {
        public string Vards;

        public string Uzvards;

        public Adrese Dzivesvieta;

        public Adrese Darbavieta;

        public void Info()
        {
            Console.WriteLine("Darbinieku sauc {0}", Vards, Uzvards);
            Console.WriteLine("Darbinieka dzivesvieta: {0}", Dzivesvieta.PilnaAdrese);
            Console.WriteLine("Darbinieka dzivesvieta: {0}, {1}, {2}", Dzivesvieta.Valsts, Dzivesvieta.Pilseta, Dzivesvieta.Iela);

        }
    }
}
