using System;

namespace merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kirjoita lause ja kone kertoo e-kirjainten määrän!");
            Console.Write("Anna bala: ");
            string userInput = Console.ReadLine().ToUpper();
            int count = 0;
            foreach (char letter in userInput)
            {
                if (letter == 'E')
                    count++;
            }
            Console.Write($"Syötteessä on {count} e-kirjainta");
            Console.ReadKey();
        }
    }
}
