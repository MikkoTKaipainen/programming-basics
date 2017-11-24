using System;

namespace merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjoita lause ja kone kääntää e kirjaimet euron merkeiksi!");
            Console.Write("Anna bala: ");
            string userInput = Console.ReadLine();
            string userOutput = userInput.Replace("e", "€");
            Console.Write($"{userOutput}");
            Console.ReadKey();
        }
    }
}
