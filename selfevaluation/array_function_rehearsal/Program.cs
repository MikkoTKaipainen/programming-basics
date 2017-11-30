using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa taulukon tähtien lukumäärän");
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{getNAsterisks(numbers[i])}");
            }
            Console.ReadKey();
        }

        static string getNAsterisks(int number)
        {
            string res = string.Empty;
            for (int i = 0; i < number; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}