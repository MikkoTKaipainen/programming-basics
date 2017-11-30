using System;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma lasketaan:");
            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

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

            } while (i < number);


            Console.WriteLine($"Syotit: {number} \nVastaus: {f} ");
            Console.ReadKey();
        }
    }
}
