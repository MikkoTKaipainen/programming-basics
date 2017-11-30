using System;

namespace merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjoita sana ja kone tarkistaa onko sana palindromi!");
            Console.Write("Anna bala: ");
            string userInput = Console.ReadLine();
            string reverseUserInput = "";
            string userOutput = userInput.Replace(" ", "");
            for (int i = userOutput.Length - 1; i >= 0; i--)
            {
                reverseUserInput += userOutput[i];
            }
            if (userOutput == reverseUserInput)
            {
                Console.Write($"Sana {userInput} on palindromi!");
            }
            else
            {
                Console.Write($"Sana {userInput} ei ole palindromi!");
            }
            Console.ReadKey();
        }
    }
}
