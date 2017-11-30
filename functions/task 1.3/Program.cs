using System;

namespace task_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Funktio pyytää käyttäjää kirjoittamaan kaksi lukua väliltä 30 - 40 ja tarkistaa onko luku tältä väliltä. Syötä luku: ");
            int retNumber = numberFromRange(30, 40);
            Console.WriteLine($"Syöttämäsi luku {retNumber} on sallittu");
            Console.ReadKey();
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input = 0;
            int ret = 0;

            do
            {
                Console.WriteLine("Syötä numero väliltä 30-40: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

                if (input >= lowerBound && input <= upperBound)
                {
                    ret = input;
                    break;
                }
                else
                {
                    isNumber = false;
                }
            }
            while (isNumber == false);

            return ret;
        }
    }
}
