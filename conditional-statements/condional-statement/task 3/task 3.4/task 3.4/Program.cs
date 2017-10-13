using System;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee lisayksen Anna luku, jonka lisays laskee: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int f = 0;
            int i = 0;

            if(number > 0)
            {
                do
                    f = f + 1;
                while (number < 0) ;
            }
            else
            {
                do
                {
                    f = f - 1;
                }
                while (number > 0) ;
            }
            Console.WriteLine($"Vastaus on {f}");
            Console.ReadKey();
        }
    }
}
