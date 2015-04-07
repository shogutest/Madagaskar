using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CwiczeniaNaReadLine
    {
        static void Main(string[] args)
        {
            string ImieUzytkownika;

            Console.WindowHeight = 10;
            Console.WindowWidth = 70;

            Console.Write("Przedstaw się proszę: ");
            ImieUzytkownika = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Cześć " +ImieUzytkownika + " !");
            Console.WriteLine("Aktualna data to " 
                + DateTime.Now.Year 
                + "-" 
                + DateTime.Now.Month 
                + "-"
                + DateTime.Now.Day
                + ", "
                + DateTime.Now.Hour
                + ":"
                + DateTime.Now.Minute
                + ":"
                + DateTime.Now.Second);

            Console.WriteLine("Aktualna data to "
             + DateTime.Now.Year
             + "-"
             + DateTime.Now.Month
             + "-"
             + DateTime.Now.Day
             + ", "
             + DateTime.Now.Hour
             + ":"
             + DateTime.Now.Minute
             + ":"
             + DateTime.Now.Second);
           Console.ReadLine();

        }
    }
}
