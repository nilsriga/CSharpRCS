using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            pokeSearch();
        }

        static void pokeSearch()
        {
            Console.WriteLine("Ievadiet pokemona nosaukumu angliski: ");
            string nosaukums = Console.ReadLine();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://pokeapi.co");
            client.GetAsync("/api/v2/pokemon/");
            


            Console.ReadLine();
        }
    }
}
