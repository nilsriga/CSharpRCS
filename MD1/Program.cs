using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1
{
    class Program
    {
        static void Main(string[] args)
        {
            majasUzdevums();
            Console.ReadLine();
        }

        static void majasUzdevums()
        {
            Skolens skolens1 = new Skolens();
            skolens1.Vards = "Egils";
            skolens1.Uzvards = "Skuja";
            skolens1.Epasts = "egils.skuja@epasts.com";
            skolens1.DzimsanasGads = 2009;
            skolens1.Klase = new Klase();
            skolens1.Klase.KlasesNosaukums = "Geografijas";
            skolens1.Klase.SkolenuSkaits = 20;
            skolens1.Klase.Telpa = new Telpa();
            skolens1.Klase.Telpa.Numurs = 1;
            skolens1.Klase.Telpa.Stavs = 2;
                       
            Macibu_Prieksmets prieksmets1 = new Macibu_Prieksmets();
            prieksmets1.Nosaukums = "Geografija";
            prieksmets1.Telpa = new Telpa();
            prieksmets1.Telpa.Numurs = 1;
            prieksmets1.Telpa.Stavs = 2;
            prieksmets1.Skolotajs = new Skolotajs();
            prieksmets1.Skolotajs.Vards = "Alfreds";
            prieksmets1.Skolotajs.Uzvards = "Trisvaidzins";
            prieksmets1.Skolotajs.Epasts = "alfreds.trisvadzins@epasts.com";


            Vertejums vertejums1 = new Vertejums();
            vertejums1.Macibu_Prieksmets = prieksmets1; // shita vajag ta vieta lai rakstitu new macibu prieksmets
            vertejums1.Skolens = skolens1;
            vertejums1.Atzime = 8;



            vertejums1.Info();

            Console.WriteLine("Skolnieks {0}, {1} saņēma {2} atzīmi {3} priekšmetā", skolens1.Vards, skolens1.Uzvards, vertejums1.Atzime, prieksmets1.Nosaukums);





        }

    }
}
