using System;

namespace task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma laskee parillisten ja parittomien lukujen summat. Syota luku: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int evenSum = 0;
            int oddSum = 0;

            for (int j = 0; j >= number; j--)
            {
                if (j % 2 == 0)
                    evenSum += j;
                else
                    oddSum += j;
            }
            for (int j = 1; j <= number; j++)
            {
                if (j % 2 == 0)
                    evenSum += j;
                else
                    oddSum += j;
            }
            Console.WriteLine($"Parittomien vastaus on {oddSum}");
            Console.WriteLine($"Parillisten vastaus on {evenSum}");
            Console.ReadKey();
        }
    }
}
