using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syota kolme lukua ja ohjelma tulostaa syotetyt luvut ja tulostaa ne suuruusjarjestykseen.");

                Console.WriteLine($"Syota ensimmainen luku: ");
                string numero1 = Console.ReadLine();
                int numx = int.Parse(numero1);

                Console.WriteLine($"Syota toinen luku: ");
                string numero2 = Console.ReadLine();
                int numy = int.Parse(numero2);

                Console.WriteLine($"Syota kolmas luku: ");
                string numero3 = Console.ReadLine();
                int numz = int.Parse(numero3);

                if(numx < numy)
                {
                if (numx < numz)
                    {
                    if (numy < numz)
                    {
                            Console.WriteLine($"Jarjestys on seuraava: {numx}, {numy}, {numz}");
                        }
                        else
                        {
                            Console.WriteLine($"Jarjestys on seuraava: {numx}, {numz}, {numy}");
                        }
                    
                    }
                    else
                    {
                        Console.WriteLine($"Jarjestys on seuraava: {numz}, {numx}, {numy}");
                    }
                }
                else
                {
                if (numx < numz)
                {
                    if (numy < numz)
                    {
                        Console.WriteLine($"Jarjestys on seuraava: {numy}, {numz}, {numx}");
                    }
                    else
                    {
                        Console.WriteLine($"Jarjestys on seuraava: {numz}, {numy}, {numx}");
                    }

                }
                else
                {
                    Console.WriteLine($"Jajestys on seuraava: {numy}, {numx}, {numz}");
                }

                }
            Console.ReadKey();
        }
    }
}
