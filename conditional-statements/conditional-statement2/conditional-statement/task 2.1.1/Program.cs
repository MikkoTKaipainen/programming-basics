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

            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age > 7 && age < 15)
            {
                discount = 50;
                discounted = true;
            }
            else if (age < 65)
            {
                discount = 50;
                discounted = true;
            }
            else
            {
                discount = 0;
                discounted = false;
            }
            
            //Varusmies
            Console.WriteLine($"Oletko varusmees?: k/e ");
            String conscriptAnswer = Console.ReadLine().ToUpper();

            if (conscriptAnswer == "Y" && discounted == false)
            {
                discount = 50;
            }
            else
            {
                //MTk Jäsen
                Console.WriteLine($"Oletko Mtk jasen: k/e?");
                String mtkAnswer = Console.ReadLine().ToUpper();

                if (mtkAnswer == "Y" && discounted == false)
                {
                    discount = 15;
                }
                else
                {
                    //Opiskelija
                    Console.WriteLine($"Oletko opiskelija?: k/e");
                    String studentAnswer = Console.ReadLine().ToUpper();

                    if (studentAnswer == "Y" && discounted == false)
                    {
                        discount = 45;
                    }
                    else if (studentAnswer == "Y" && mtkAnswer == "Y" && discounted == false)
                    {
                        discount = 60;
                    }
                }


            }
            //Tulostaa lipun hinnan
            float hinta = price *discount / 100;
            Console.WriteLine($"Lipun hintasi on: {hinta}");





            Console.ReadLine();
        }

    }

}
