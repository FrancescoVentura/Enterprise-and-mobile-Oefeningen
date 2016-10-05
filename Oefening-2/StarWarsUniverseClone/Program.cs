using StarWarsUniverseClone.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverseClone
{
    public class Program
    {

        static void Main(string[] args)
        {
            using (StarWarsContext context = new StarWarsContext())
            {
                var list = context.SWMovie.Include("Planets");
                var orderedList = from item in list orderby item.Episode_ID select item;
                Console.WriteLine("=== Star Wars Movies ===");
                foreach (var item in orderedList)
                {
                    Console.WriteLine(item.Title + "\n\t Released: " + item.ReleaseDate.ToShortDateString());
                    Console.Write("[");
                    foreach (var planet in item.Planets)
                    {
                        Console.Write("( " + planet + " ) ");
                    }
                    Console.Write("]\n");
                }
                Console.WriteLine("========================");
                Console.ReadLine();
            }
        }
    }
}
