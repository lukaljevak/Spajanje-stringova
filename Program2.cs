using consoleapp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak
zamijeniti znakom '_'.*/
namespace consoleapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1;
            Console.WriteLine("Upisite recenicu");
            s1= Console.ReadLine();

            string zamijenjeniZnakovi = s1.Replace(" ", "_");

            Console.WriteLine("Niz znakova s zamijenjenim razmacima:");
            Console.WriteLine(zamijenjeniZnakovi);
            Console.ReadKey();
        }
    }
}
