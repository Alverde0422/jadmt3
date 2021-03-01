using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_mind_tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            Dictionary<string, int> people = new Dictionary<string, int>
            {
                // Opgave 2
                { "mark", 18 },
                { "skayrunner", 88 }
            };
            people["jammy"] = 18;

            // ??
            Console.WriteLine(people.First() + "\n");

            people.Remove("skayrunner");


            foreach (var p in people)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}