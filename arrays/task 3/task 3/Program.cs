using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kyseessä on taulukko joka arpoo 10 lukua väliltä 0 - 20");
            Random rnd = new Random();
            string[] numbers = new string[10];

            Console.WriteLine("[X] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = getNum(rnd.Next(1, 21));
                Console.WriteLine($"[{i}] = {numbers[i]}");
            }
            Console.ReadKey();
        }

        static string getNum(int N)
        {
            string num = "";

            if (N < 10)
            {
                num = "0" + N.ToString();
            }
            else
            {
                num = N.ToString();
            }
            return num;
        }
    }
}
