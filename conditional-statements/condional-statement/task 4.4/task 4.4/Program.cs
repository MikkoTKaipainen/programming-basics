using System;

namespace task_4._4
{
    class Program
    {
        static void Main(string[] args)
        {   //4. Tee ohjelma, joka simuloi rahan heittoa seuraavasti: 
            //Ohjelma kysyy ensin heittojen lukumäärän i ja simuloi
            //sitten rahan heittoa i kertaa(0 = klaava, 1 = kruuna).
            //Lopuksi ohjelma tulostaa saatujen klaavojen ja kruunien määrän.
            //Vastaus:
            //Rahaa on heitetty 20 kertaa.
            //Klaavoja tuli 6 ja kruunuja 14.
            Console.WriteLine("Ohjelma tulostaa klaavan ja kruunan heittoja ja tulostaa kuinka monta klaavaa ja kruunaa tulee.");
            Console.WriteLine("Anna luku, kuinka monta kertaa kolikkoa heitetaan: ");
            string userInput;
            userInput = Console.ReadLine();
            int userThrow = int.Parse(userInput);
            Random rnd = new Random();
            int heads = 0;
            int tails = 0;

            for (int i = 0; i < userThrow; i++)
            {
                int j = rnd.Next(2);
                if (j == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            
            Console.Write($"Klaavoja:{tails}, Kruunia:{heads} ");
            Console.ReadKey();
        }
    }
}
