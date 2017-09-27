using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)

        {
                Console.WriteLine("Ohjelma tulostaa syotetyn luvun ja kertoo parillinen tai pariton.");
                Console.Write("Syota luku: ");
                string userInput;
                userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int evaluatedNumber);
                    string isEven;
                    string isPositive;
            
                    if(evaluatedNumber % 2 == 0)
                    {
                        isEven = "Parillinen";
                    }
                    else
                    {
                        isEven = "Pariton";
                    }


                    if(evaluatedNumber > 0)
                    {
                        isPositive = "Positiivinen";
                    }
                    else if(evaluatedNumber < 0)
                    {
                        isPositive = "Negatiivinen";
                    }

                    else
                    {
                    isPositive = "Nolla";
                    }

                    Console.WriteLine($"Luku on {isEven} ja {isPositive}");

                Console.ReadKey();
        }
    }
}
