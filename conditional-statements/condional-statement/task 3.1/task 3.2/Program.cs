using System;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma laskee");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int f = 0;
            if (number < 0)
            {
                Console.WriteLine("Arvo on virheellinen");
                Console.ReadLine();
                return;
            }

            for (int j = 1; j <= number; j++)
            {
                f = f + j;
                Console.WriteLine($"{j}!={f}");
            }
            Console.WriteLine($"Vastaus on {f}");
            Console.ReadKey();
        }
    }
}
