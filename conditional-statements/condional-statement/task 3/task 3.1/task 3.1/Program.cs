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
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;
            if (number < 0)
            {
                Console.WriteLine("Arvo on virheellinen");
                Console.ReadLine();
                return;
            }
            do
            {
                i = i + 1;
                f = f * i;
            }
            while (i < number);
            for (int j = 1; j < number; j++)
            {
                f = f * j;
                Console.WriteLine($"{j}!={f}"); //5! = 120
            }
            Console.WriteLine($"Syotit {number}\nvastaus {f}"); //5! = 120
            Console.ReadKey();
        }
    }
}
