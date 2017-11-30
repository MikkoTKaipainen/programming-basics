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
            Console.Write("");
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

            Console.WriteLine("");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine();

            // tulostetaan taulukoiden arvot
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if
                    {
                        numbers[i, j] = int.Parse(getNum());
                        Console.WriteLine($"[{i:00} , {j:00}] = {numbers[i, j]:00}");
                    }
                //    if (arrT_1[i] < 10)
                //    {
                //        arrT_1[i] = int.Parse(getNum());
                //        Console.WriteLine($"arrT_1: {arrT_1} ");
                //    }
                //    if (arrT_2[j] < 10)
                //    {
                //        arrT_2[j] = int.Parse(getNum());
                //        Console.WriteLine($"arrT_2: {arrT_2} ");
                //    }
                }
            }

            Console.ReadKey();
        }
        //funktio jolla arvotaan luvut taulukoihin 1 ja 2
        static string getNum()
        {
            int X = rnd.Next(0, 50 + 1);
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
        //funktio jolla poimitaan taulukkoon 3 suurimmat arvot taulukosta 1 ja 2
        static string getArr()
        {
            int getArr = ;
            string res = "";

            for (int i = 0; i < 50; i++)
            {
                if ()
            }

            return res = "";
        }
    }
}
