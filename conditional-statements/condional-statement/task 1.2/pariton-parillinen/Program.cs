using System;

namespace pariton_parillinen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa parillinen tai pariton");
            bool isNumber;
            do
            {

                Console.Write("Syota luku: ");
                string userInput;
                userInput = Console.ReadLine();

                isNumber = int.TryParse(userInput, out int evaluatedNumber);
                int x = 0;
                if (x % 10 == 0);
                if (isNumber == true)

                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on pariton");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on parillinen");
                    }
                Console.WriteLine($"Syotit arvon {userInput}");

            } while (isNumber == false);
        }
    }
}
