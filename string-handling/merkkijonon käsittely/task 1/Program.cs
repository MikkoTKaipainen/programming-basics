using System;

namespace merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjoita lause ja kone kertoo monta merkkiä syötteessä on!");
            Console.Write("Anna bala: ");
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
            }
            Console.Write($"Syötteessä on {userInput.Length} merkkiä");
            Console.ReadKey();


        }
    }
}
