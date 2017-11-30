using System;

namespace vovelcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kyseessä ohjelma joka laskee vokaalit käyttäjän syöttämästä lauseesta");
            string userInput = Console.ReadLine().ToUpper();
            int total = 0;

            foreach (char letter in userInput)
            {
                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    total++;
                }
            }
            Console.WriteLine($"Vokaalien määrä on: {total}");
            Console.ReadKey();

        }
    }
}
