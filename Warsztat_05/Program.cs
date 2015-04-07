using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program__warsztat_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekstDoObrobki;
            string tekstDoZamiany; 
            string tekstZastepujacy;
         

            Console.Write("Podaj tekst do obróbki: ");
            tekstDoObrobki = Console.ReadLine();
            Console.Write("Podaj tekst do zamiany: ");
            tekstDoZamiany = Console.ReadLine();
            Console.Write("Podaj tekst ktorym chcesz zastąpić tekst do zamiany: ");
            tekstZastepujacy = Console.ReadLine();

            Console.WriteLine("\nDługość tekstu do obróbki to: " + (tekstDoObrobki.Length));
            Console.Write("Treść tekstu po obróbce: " + tekstDoObrobki.Replace(tekstDoZamiany,tekstZastepujacy));
            Console.ReadLine();
        }
    }
}
