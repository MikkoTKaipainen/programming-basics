using System;

namespace task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä");
            Random rnd = new Random();
            int userInput = 0;
            int counter = 0;
            int number = rnd.Next(100);
            while (number != userInput)
            {
                Console.Write("Arvaa luku: ");
                int.TryParse(Console.ReadLine(), out userInput);
                counter = counter + 1;
                if (userInput > 100)
                {
                    Console.WriteLine("Anna luku väliltä 1-100!");
                }
                else if (userInput < 1)
                {
                    Console.WriteLine("Anna luku väliltä 1-100!");
                }
                else if (userInput < number)
                {
                    Console.WriteLine("Lukuni on isompi!");
                }
                else if (userInput > number)
                {
                    Console.WriteLine("Lukuni on pienempi!");
                }
                else
                {

                    Console.WriteLine($"Oikein! Arvauksia {counter}");
                }
            }
            Console.ReadKey();
        }
    }
}
