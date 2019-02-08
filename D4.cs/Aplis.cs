using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Aplis
    {

        public float radius;

        //konstruktos apakšā

        public Aplis(float radius)
        {
            this.radius = radius;
        }

        public float laukums()
        {
            return (float)3.14 * radius * radius;
        }

        public float perimetrs()
        {
            return 2 * (float)3.14 * radius;
        }

        public void KonsolesIzvade()
        {
            Console.WriteLine("Perimetrs = {0}", perimetrs());
            Console.WriteLine("Laukums = {0}", laukums());

        }

        public static void FigurasNosaukums()
        {
            Console.WriteLine("Šis ir Aplis");
        }
    }
}
