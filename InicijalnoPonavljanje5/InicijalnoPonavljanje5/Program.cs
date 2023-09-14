using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pojednostavljena provjera ispravnosti URL adrese registrirane u hrvatskom internetskom prostoru bila bi:
                • mora počinjati s www
                • mora završavati s hr
                • mora sadržavati točku nakon www i prije hr
                Napišite program koji će zatražiti od korisnika da unese URL adresu, te će provjeriti je li adresa napisana u ispravnom formatu.
            */
            Console.WriteLine("Unesi hipervezu: ");
            string link = Console.ReadLine();
            if(link[0] == 'w' && link[1] == 'w' && link[2] == 'w' && link[3] == '.' && link[link.Length-1] == 'r' && link[link.Length - 2] == 'h' && link[link.Length - 3] == '.')
            {
                Console.WriteLine("Hiperveza poštuje propisani format!");
            }
            else
            {
                Console.WriteLine("Hiperveza NE poštuje propisani format!");
            }
            Console.ReadKey();
        }
    }
}
