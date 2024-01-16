using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova, te ćete definirati
sljedeće varijable:
• sVelika koja će sadržavati unešeni niz pretvoren u velika slova
• sMala koja će sadržavati unešeni niz pretvoren u mala slova
• sPrvaTri koja će sadržavati prva tri znaka unešenog niza
• sZadnjihPet koja će sadržavati zadnjih pet znakova unešenog niza
• s8_11 koja će sadržavati od 8. do 11. znaka unešenog niza
Na kraju i ispišite vrijednosti navedenih varijabli.*/
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu");
            string unos = Console.ReadLine();
            string sVelika = unos.ToUpper();
            string sMala = unos.ToLower();
            string sPrvaTri = unos.Substring(0, 2);
            string sZadnjihPet = unos.Substring(unos.Length - 5);
            string s8_11 = unos.Substring(7, 10);
            Console.WriteLine("sVelika: " + sVelika);
            Console.WriteLine("sMala: " + sMala);
            Console.WriteLine("sPrvaTri: " + sPrvaTri);
            Console.WriteLine("sZadnjihPet: " + sZadnjihPet);
            Console.WriteLine("s8_11: " + s8_11);
            Console.ReadKey();
        }
    }
}
