using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Lottokone arpoo seitsemän lukua, lisänumeron ja tuplausnumeron");
            Random rnd = new Random();
            int i = 0;
            int[] lotto = new int[40];
            int doubleNumber;
            int extraNumber = 0;
            //Arvotaan lottonumerot
            while (i < 7)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 1;
                    i++;
                }
            }
            //Arvotaan lisänumero
            while (true)
            {
                int rndIndex = rnd.Next(0, 39 + 1);
                if (lotto[rndIndex] == 0)
                {
                    lotto[rndIndex] = 2;
                    break;
                }
            }
            //Tulostus lottonumeroille
            string lottonumbers = "";

            for (i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 1)
                    lottonumbers += $"{i + 1} ";
            }
            //Tulostus lisänumerolle
            for (i = 0; i < lotto.Length; i++)
            {
                if (lotto[i] == 2)
                {
                    extraNumber = i + 1;
                    break;
                }
            }
            //Tulostus tuplausnumerolle
            doubleNumber = rnd.Next(0, 39 + 1);

            //Tulostetaan numerot ja teksti
            Console.WriteLine($"Lottonumerot {lottonumbers} Lisänumerot {extraNumber} tuplausnumero {doubleNumber}");
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