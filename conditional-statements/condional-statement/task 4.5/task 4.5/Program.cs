using System;

namespace task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin");
            Random rnd = new Random();


            for (int i = 1; i <= 13; i++)
            {
                double j = rnd.NextDouble();
                if(j <= 0.4)
                {
                    Console.WriteLine($"{i}. 1");
                }
                else if(j >= 0.8)
                {
                    Console.WriteLine($"{i}. X");
                }
                else
                {
                    Console.WriteLine($"{i}. 2");
                }

            }


            Console.ReadKey();
        }
    }
}
