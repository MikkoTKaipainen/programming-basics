using System;

namespace task_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kaksikymmenta klaavan ja kruunan heittoa ja tulostaa kuinka monta klaavaa ja kruunaa tulee.");
            Console.WriteLine("Anna luku, kuinka monta kertaa kolikkoa heitetaan: ");
            string userInput;
            userInput = Console.ReadLine();
            Random rnd = new Random();
            int heads = 1;
            int tails = 2;

            
            
            Console.Write($"Klaavoja:{tails}, Kruunia:{heads} ");
            Console.ReadKey();
        }
    }
}
