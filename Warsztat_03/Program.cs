using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZagadkaCoffeiny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 6;
            Console.WindowWidth = 55;
            Console.WriteLine("ZAGADKA:");
            Console.WriteLine("Ile gatunków zwierząt zabrał Mojżesz na arkę?");
            Console.ReadKey();
            Console.WriteLine("Zero, Mojżesz nie miał Arki.");
            Console.ReadKey();
        }
    }
}
