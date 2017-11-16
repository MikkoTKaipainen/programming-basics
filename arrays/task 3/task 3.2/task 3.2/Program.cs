using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kyseessä on taulukko joka arpoo 10 lukua väliltä 0 - 100");
            Random rnd = new Random();
            string[ , ] numbers = new string[0,100];

            Console.WriteLine("[X , Y] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                int j = i + 10;
                numbers[i,i] = getNum(rnd.Next(1,101));
                Console.WriteLine($"[{i} , {j}] = {numbers[i,i]}");
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
