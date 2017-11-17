using System;

namespace task_3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Kyseessä on taulukko joka arpoo 10 lukua väliltä 0 - 100");
            Random rnd = new Random();
            int[ , ] numbers = new int[10,20];

            Console.WriteLine("[ X ,  Y] = Arvo");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (numbers[i,j] < 10 )
                    {
                        numbers[i, j] = int.Parse(getNum());
                        Console.WriteLine($"[{i:00} , {j:00}] = {numbers[i, j]:00}");
                    }
                }
            }
            Console.ReadKey();
        }    

        static string getNum()
        {
            
            int X = rnd.Next(0, 100 + 1);
            string res = "";

            if (X < 10)
            {
                res = X.ToString();
            }
            else
            {
                res = X.ToString();
            }
            return res;
        }
    }
}
