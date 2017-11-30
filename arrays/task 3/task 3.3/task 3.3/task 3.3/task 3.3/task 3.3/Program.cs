using System;

namespace task_3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taulukko määrittelee kolme kokonaislukutaulukkoa, joista jokaisessa on 10 kokonaislukua.");
            Random rnd = new Random();
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];

            //tulostetaan numerot 1- 10 tulostusta varten sekä - - - - - - numeroiden alapuolelle
            Console.Write("         ");
            for (int i = 0; i < 10; i++)
            {
                if (i < 10)
                {
                    Console.Write($"0{i} ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }

            Console.WriteLine();

            // tulostetaan taulukoiden arvot
            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(50);
                arrT_2[i] = rnd.Next(50);
            }
            for (int i = 0; i < 10; i++)
            {
                if(arrT_1[i] < arrT_2[i])
                {
                    arrT_3[i] = arrT_2[i];
                }
                else
                {
                    arrT_3[i] = arrT_1[i];
                }
            }
            Console.WriteLine("         - - - - - - - - - - - - - - - ");
            Console.WriteLine($"arrT_1: {getPrint(arrT_1)}");
            Console.WriteLine($"arrT_2: {getPrint(arrT_2)}");
            Console.WriteLine($"arrT_3: {getPrint(arrT_3)}");
            
            Console.ReadKey();
        }

        //funktio jolla poimitaan taulukkoon 3 suurimmat arvot taulukosta 1 ja 2
        public static string getPrint(int[] arrayx)
        {
            string res = " ";
            
            for (int i = 0; i < arrayx.Length; i++)
            {
                res += $"{arrayx[i]:00} ";
            }

            return res;

        }
    }
}
