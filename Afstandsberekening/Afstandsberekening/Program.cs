namespace Afstandsberekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2 = 0;
            double distance = 0;
            string input = "";
            bool isStopped = false;

            Console.Write("Geef het x-coordinaat van het eerste punt: ");
            input = Console.ReadLine();
            while (!double.TryParse(input, out x1))
            {
                Console.Write("Foutieve invoer, geef opnieuw. Geef het x-coordinaat van het eerste punt: ");
                input = Console.ReadLine();
            }

            Console.Write("Geef het y-coordinaat van het eerste punt: ");
            input = Console.ReadLine();
            while (!double.TryParse(input, out y1))
            {
                Console.Write("Foutieve invoer, geef opnieuw. Geef het y-coordinaat van het eerste punt: ");
                input = Console.ReadLine();
            }

            while (!isStopped)
            {
                Console.WriteLine("Het is eerste coordinaat is: " + "(" + x1 + "," + y1 + ")");
                Console.Write("Geef het x-coordinaat van het tweede punt: ");
                input = Console.ReadLine();
                while (!double.TryParse(input, out x2))
                {
                    Console.Write("Foutieve invoer, geef opnieuw. Geef het x-coordinaat van het tweede punt: ");
                    input = Console.ReadLine();
                }

                Console.Write("Geef het y-coordinaat van het tweede punt: ");
                input = Console.ReadLine();
                while (!double.TryParse(input, out y2))
                {
                    Console.Write("Foutieve invoer, geef opnieuw. Geef het y-coordinaat van het tweede punt: ");
                    input = Console.ReadLine();
                }

                double distance_now = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("De totale afstand tussen de 2 punten is " + distance_now);

                distance += distance_now;

                Console.WriteLine("De totale afgelegde afstand is " + distance);

                x1 = x2;
                y1 = y2;

                Console.Write("Wil je stoppen met meten? (j/n): ");
                input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    isStopped = true;
                    continue;
                }
            }
        }
    }
}
