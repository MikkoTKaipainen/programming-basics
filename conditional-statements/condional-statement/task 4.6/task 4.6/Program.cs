using System;

namespace task_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi nopan heittoa 1000 kertaa ja tulostaa lisaksi kuutosen esiintymiskerrat");
            Random rnd = new Random();
            int dice = 1;
            int six = 0;
            for (int i = 1; i <= 1000; i++)
            {
                dice = rnd.Next(1,7);
                Console.WriteLine($"{i} {dice}");
                if(dice == 6)
                {
                    six++;
                }
            }


                Console.WriteLine($"Kutonen ilmestyy {six} kertaa");

            Console.ReadKey();
        }
    }
}
