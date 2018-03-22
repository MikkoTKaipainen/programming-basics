using System;

namespace viitelaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa viitenumeron");
            string userInput = "1234561";
            string ch = userInput.Substring(userInput.Length - 1, 1);
            string refnumber = userInput.Substring(0, userInput.Length - 1);

            int[] multip = {7, 3, 1};
            int result = 0;
            for (int i = 0; i < refnumber.Length; i++)
            {
                int j = refnumber.Length - 1 - i;
                int number = int.Parse(refnumber[j].ToString()) * multip[i % 3];
                result += number;
            }
            int check = (result / 10 + 1) * 10 - result;
            Console.ReadLine();
            //ch = userInput[userInput.Legnth - 1].ToString();
            
        }
    }
}
