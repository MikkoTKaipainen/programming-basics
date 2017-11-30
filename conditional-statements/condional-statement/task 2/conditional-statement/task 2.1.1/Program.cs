using System;

namespace task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysytään asiakkaan tiedot
            Console.WriteLine("Kerro kuka olet. Ohjelma tulostaa lipun hinnan!");
            Console.WriteLine($"Kerro nimesi:");
            string name = Console.ReadLine();

            float price = 16;
            float discount = 0;
            bool discounted = false;
            
            //Ikä
            Console.WriteLine($"Kerro ikasi: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15)
            {
                discount = 50;
                discounted = true;
            }
            else if (age >= 65)
            {
                discount = 50;
                discounted = true;
            }
            
            //Varusmies
            Console.WriteLine($"Oletko varusmees?: k/e ");
            String conscriptAnswer = Console.ReadLine().ToUpper();

            if (conscriptAnswer == "K" && discounted == false)
            {
                discount = 50;
            }
            else
            {
                //MTk Jäsen
                Console.WriteLine($"Oletko Mtk jasen: k/e?");
                String mtkAnswer = Console.ReadLine().ToUpper();

                //Opiskelija
                Console.WriteLine($"Oletko opiskelija?: k/e");
                String studentAnswer = Console.ReadLine().ToUpper();

                if (mtkAnswer == "K" && discounted == false)
                {
                    discount = 15;
                }
                else
                {
                    if (studentAnswer == "K" && discounted == false)
                    {
                        discount = 45;
                    }
                else if (studentAnswer == "K" && mtkAnswer == "K" && discounted == false)
                {
                    discount = 60;
                }
                }

            }
            //Tulostaa lipun hinnan
            float pricefinal = price - (price * (discount / 100));
            Console.WriteLine($"Lipun hintasi on: {pricefinal}");
            Console.ReadLine();
        }

    }

}
