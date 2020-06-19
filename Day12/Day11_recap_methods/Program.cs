using System;

namespace Day11_recap_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintStar();
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.Red;
            //PrintStar();
            //Console.ResetColor();
            //Console.WriteLine();
            //PrintStars(15);
            //Console.WriteLine();
            //PrintStarsWithLineBreak(9, 4);
            //PrintSentence("Ann is going to get married to John", 'i');
        }

        static void PrintSentence(string word, char excludeCharacter)
        {
            foreach (char letter in word)
            {
                if (letter != excludeCharacter)
                {
                    Console.WriteLine(letter); 
                }
            }
        }

        static void PrintStar()
        {
            Console.Write("* ");
        }

        static void PrintStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                PrintStar();
            }
        }

        static void PrintStarsWithLineBreak(int count, int breakLineCount)
        {
            int breaks = count / breakLineCount;

            for (int i = 0; i < breaks; i++)
            {
                PrintStars(breakLineCount);
                Console.WriteLine();
            }
        }
    }
}
