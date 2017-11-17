using System;

namespace task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma kysyy lukuja käyttäjältä. Ohjelma päättyy antamalla kaksi samaa lukua peräkkäin. Syötä lukuja:");
            int userInput = 0;
            int sum = 0;
            int last = 0;

            while (last == userInput)
            {
                Console.Write("Syötä luku ");
                int.TryParse(Console.ReadLine(), out userInput);
     
                if  (userInput != last)
                {
                    sum = sum + userInput;
                    last = userInput;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Lukujen summa on {sum}");
            Console.ReadKey();
        }
    }
}
