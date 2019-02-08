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
            Console.WriteLine("Darbinieku sauc {0} {1}", Vards, Uzvards);

            Console.WriteLine("darbinieka dzvesvieta: {0}", Dzivesvieta.PilnaAdrese());
            Console.WriteLine("darbinieka darbavieta: {0}", Darbavieta.PilnaAdrese());
        }



    }


}
