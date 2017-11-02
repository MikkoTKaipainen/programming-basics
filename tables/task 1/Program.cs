using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 100 lukua väliltä 0 - 50 sekä tulostaa lukujen keskiarvon");
            Random rnd = new Random();
            int[] number = new int[100];
            double sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rnd.Next(50 + 1);
                Console.WriteLine($"{i + 1}. {number[i]}");       
            }

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine($"Lukujen yhteissumma on: {sum} ja keskiarvo on {sum / 100}");

            

            Console.ReadKey();
            











            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } = new int [5];
            //Console.WriteLine(number[2]);
            //Random rnd = new Random();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = rnd.Next(0, 10);
            //}
           
            //string[,] arrTable =  new string[2,3];
        }
    }
}
