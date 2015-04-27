using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_wieku
{
    class Program
    {
        static void Main(string[] args)
        {   /* 2015
             * Kalkulator wieku uztkownika
             * Program ma za zadanie obliczac rok urodzenia uzytwkonika, na podstawie podanego wieku.
             * Program jest prosty.
            */
            int WiekUzytkownia, AktualnyCzas, WyliczenieWieku;
            Console.WriteLine("KALKULATOR WIEKU");
            Console.Write("Podaj swoj wiek: ");
            try
            {
                WiekUzytkownia = Convert.ToByte(Console.ReadLine());
                AktualnyCzas = DateTime.Now.Year;          // pobieranie aktualnej daty 
                WyliczenieWieku = AktualnyCzas - WiekUzytkownia; // wyliczanie roku urodzenia użytkownika

                Console.WriteLine("Cześć! Urodziłeś się w " + WyliczenieWieku);  
                
            }
            catch(System.FormatException)  // wyjątek obsługujący nieprawidłowy format ciagu wejściowego 
            {
                Console.WriteLine("Błąd: nie podałeś liczby!");
            }
            catch(OverflowException) //  wyjatek oslugujacy OverflowException
            {
                Console.WriteLine("Liczba jest spoza zakresu od"
                    + short.MinValue
                    + " do "
                    + short.MaxValue);
            }
            Console.ReadKey();
        }
    }
}
