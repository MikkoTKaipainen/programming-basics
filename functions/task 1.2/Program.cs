using System;

namespace task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Funktio palauttaa kaksi annettua arvoa ja kertoo kumpi on pienempi");
            //Muutetaan stringit intiksi
            int num1 = 0;
            int num2 = 0;
            bool userInput = int.TryParse(Console.ReadLine(), out num1);
            bool userInput2 = int.TryParse(Console.ReadLine(), out num2);

            if (userInput == true && userInput2 == true)
            {
                Console.WriteLine($"{minimum(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Vain numerot ovat hyväksyttäviä");
            }
            Console.ReadKey();
            
        }
        //Funktio joka hakee luvut ja kertoo järjestyksen
        static string minimum(int num1, int num2)
        {
            string answer;

            if(num1 < num2)
            {
                answer = $"Luku {num1} on pinempi kuin {num2}";
            }

            else
            {
                answer = $"Luku {num2} on pienempi kuin {num1}";
            }

            return answer;
        }
    }
}
