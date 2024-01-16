using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Napišite program u kojem ćete definirati sljedeće dvije varijable tipa string:
• s1 sa sadržajem "Hrvatska ima more"
• s2 sa sadržajem "Italija je prvak svijeta"
Definirajte i ispišite string s3 čiji će sadržaj biti prvih 8 znakova stringa s1 plus svi znakovi od
sedmog do kraja niza s2.*/

namespace Klasa_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0,7) + s2.Substring(6);

            Console.WriteLine(s3);

            Console.ReadLine();
        }
    }
}
