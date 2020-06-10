using System;

namespace Day8_rainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 1000000)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(16);
                
                //text
                var color = (ConsoleColor)randomNumber;
                Console.ForegroundColor = color;
                
                //background
                randomNumber = rand.Next(16);
                Console.BackgroundColor = (ConsoleColor)randomNumber;

                Console.Write("a");
                n++;
            }
        }
    }
}
