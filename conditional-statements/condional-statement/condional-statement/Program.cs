using System;

namespace condional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.Write("Syota luku: ");
            string userInput;
            userInput = Console.ReadLine();

            int.TryParse(userInput, out int evaluatedNumber);
            if (evaluatedNumber < 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on negatiivininen");
            }
            else if(evaluatedNumber > 0)
            {
                Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
            }
            else
            {
                Console.WriteLine($"Numero {evaluatedNumber} on nolla");
            }
            Console.WriteLine($"Syotit arvon {userInput}");
            Console.ReadKey();
        }
    }
}
