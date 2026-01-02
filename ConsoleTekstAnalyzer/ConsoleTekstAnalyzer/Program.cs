using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTekstAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int removeAantal;
            string zin;
            char karakter;
            Console.WriteLine("geef een zin in");
            input = Console.ReadLine();
            zin = input;
            Console.WriteLine("Geef één karakter in:");
             input = Console.ReadLine().Trim();
             
            while (input.Length != 1)
            {
                Console.WriteLine("Fout: je moet exact één karakter invoeren. Probeer opnieuw:");
                input = Console.ReadLine().Trim();
                
            }
            karakter = Convert.ToChar(input);
            char zoekKarakter = Convert.ToChar(input);
            Console.WriteLine("Je hebt het karakter: " + zoekKarakter);

            int positie = input.IndexOf(zoekKarakter);

            if (positie >= 0)
            {
                Console.WriteLine("het karakter" + zoekKarakter + "komt op positie " + positie);
            }
            else
            {
                Console.WriteLine("het karakter " + zoekKarakter + "komt niet voor in deze zin.");
            }
            
            Console.WriteLine("hoeveel karakters wil je van het einde verwijderen?");
            input = Console.ReadLine();
            while (!int.TryParse(input, out removeAantal) || removeAantal < 0 || removeAantal > zin.Length)
            {
                Console.WriteLine(" dat is fout , hoeveel karakters wil je van het einde verwijderen?");
            }
            removeAantal = int.Parse (input);
            zin = zin.Remove(zin.Length - removeAantal);

            if (removeAantal > 0) 
            {
                zin = zin.Remove(zin.Length - removeAantal);
            }
            Console.WriteLine(zin);
            int klinkers = 0;
            int medeklinkers = 0;

            string klinkersz = "aeiouAEIOU";       // alle klinkers
            string medeklinkersz = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"; // alle medeklinkers

            for (int i = 0; i < zin.Length; i++) 
            {
                char c = zin[i];

                if (klinkersz.Contains(c))
                {
                    klinkers++;
                }
                else if (medeklinkersz.Contains(c))
                {
                    medeklinkers++;
                }
            }

            Console.WriteLine("aantal klinkers: " + klinkers);
            Console.WriteLine("aantal medeklinkers: " + medeklinkers);







        }
    }
}
