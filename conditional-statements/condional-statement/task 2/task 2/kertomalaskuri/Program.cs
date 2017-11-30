using System;

namespace conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //lasketaan kertoma ja minne asti kertoma lasketaan
            Console.WriteLine("Ohjelma laskee kertoman. Anna luku, jonka kertoma laskee");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;
            do
            {
                i = i + 1;
                f = f * i;
                //Console.WriteLine($"{i} !={f}"); //5! = 120

            }
            while (i < number);
            Console.WriteLine($"Syotit {i}\nvastaus {f}"); //5! = 120
            Console.ReadKey();










        }

    }
}
