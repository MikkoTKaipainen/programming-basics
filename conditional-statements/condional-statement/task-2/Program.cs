using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syotetyn luvun ja kertoo parillinen tai pariton.");
            bool isNumber;
            do
            {

                Console.Write("Syota luku: ");
                string userInput;
                userInput = Console.ReadLine();

                isNumber = int.TryParse(userInput, out int evaluatedNumber);

                if (isNumber == true)
                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on parillinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on pariton");
                    }

                else
                {
                    Console.WriteLine("Ei oole numero tama!");
                }

            } while (isNumber == true);
            Console.ReadKey();
        }
    }
}