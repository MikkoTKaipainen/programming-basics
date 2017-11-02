using System;

namespace task_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä 10 positiivista lukua");

            int userInput;
            Console.WriteLine("Syötä luku: ");
            userInput = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }