using System;

namespace Day8_rainbow_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintRainbowBoard();
            PrintRainbowBoardWithWave(20);
        }

        static void PrintRainbowBoard()
        {
            int n = 0;
            while (n < 1000000)
            {
                Random rand = new Random();
                int randomSkaitlis = rand.Next(15);
                var krasa = (ConsoleColor)randomSkaitlis;
                Console.ForegroundColor = krasa;
                Console.Write("a");
                n++;
            }
        }

        static void PrintRainbowBoardWithWave(int waveWidth)
        {
            int wavePositionCounter = 0;
            int n = 0;
            bool goForward = true;
            while (n < 1000000)
            {
                if (wavePositionCounter == waveWidth)
                {
                    goForward = false;
                }
                else if (wavePositionCounter == 0)
                {
                    goForward = true;
                }

                for (int i = 0; i < waveWidth; i++)
                {
                    if (i == wavePositionCounter)
                    {
                        PrintColorMethod();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                if (goForward)
                {
                    wavePositionCounter++;
                }
                else
                {
                    wavePositionCounter--;
                }

                Console.WriteLine();
                n++;

                //Pauses the program for 10 miliseconds, so the printing is not so fast.
                System.Threading.Thread.Sleep(10);
            }
        }

        private static void PrintColorMethod()
        {
            Random rand = new Random();
            int randomSkaitlis = rand.Next(15);
            var krasa = (ConsoleColor)randomSkaitlis;
            Console.ForegroundColor = krasa;
            Console.Write("a");
        }
    }
}
