using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syota kolme lukua ja ohjelma tulostaa syotetyt luvut ja tulostaa ne suuruusjarjestykseen.");
            Console.Write("Syota luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int numero1 = int.Parse(userInput);
            Console.WriteLine($"Syota ensimmainen luku: ");

            int numero2 = int.Parse(userInput);
            Console.WriteLine($"Syota toinen luku: ");

            int numero3 = int.Parse(userInput);
            Console.WriteLine($"Syota kolmas luku: ");

            if (numero1 < numero2 < numero3);
            {
            else 
            }

            Console.ReadKey();
        }
    }
}
