using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            mekletFilmas();

            Console.ReadLine();
        }
        static void mekletFilmas()
        {
            Console.WriteLine("Ievadi Filmas nosaukumu");
            string nosaukums = Console.ReadLine();


            using (HttpClient client = new HttpClient())
            {
                int page = 0;

                client.BaseAddress = new Uri("http://www.omdbapi.com");

                while(true)
                {

                    var response = client.GetAsync(String.Format("?page={1}&s={0}&apikey=33974359", nosaukums, page)).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        
                        SearchResult result = response.Content.ReadAsAsync<SearchResult>().Result;
                        int pageCount = result.totalResults / 10;
                        if (page > pageCount)
                        {
                            break;
                        } else
                        {
                            page++;
                        }

                        if (result.Response == "False")
                        {
                            Console.Write("Tāda filma netika atrasta!");
                        }
                        else
                        {

                            foreach (Movie movie in result.Search)
                            {
                                Console.WriteLine("Nosaukums = {0}, Gads = {1}", movie.Title, movie.Year);
                            }
                        }


                    }
                    else
                    {
                        Console.Write("Notika neparedzēta kļūda!");
                    }
                }
            }
            mekletFilmas();

        }

    }
    }

