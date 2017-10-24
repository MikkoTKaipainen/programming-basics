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
            Console.WriteLine("Ohjelma tulostaa tähtien lukumäärän");

            int number;
            while (true)
            {
                Console.Write("Tähtien lukumäärä: ");
                number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine($"Luku {0} ei ole sallittu luku", number);
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(number);
            Console.WriteLine(asterisks);
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
