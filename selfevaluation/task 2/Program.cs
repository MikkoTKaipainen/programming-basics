using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Anna ohjelmalle lause: ");
            string userInput = Console.ReadLine();
            int numberOfLetters = userInput.Length;
            userInput = userInput.Replace(" ", String.Empty);
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }

            Console.ReadKey();
        }
    }
}
