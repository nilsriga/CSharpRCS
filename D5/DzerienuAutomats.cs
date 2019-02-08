using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    class DzerienuAutomats
    {
        private double IemaksataSumma;

        public DzerienuAutomats()
        {
            IemaksataSumma = 0;
        }

        public void SanemAtlikumu()
        {
            Console.WriteLine("Tu sanemi EUR {0}", IemaksataSumma);
            IemaksataSumma = 0;
        }
    }
}
