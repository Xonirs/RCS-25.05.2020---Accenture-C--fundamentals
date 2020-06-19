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
            int someMagicNumber = GetSomeMagicNumber(4);
            Console.WriteLine(someMagicNumber);
            someMagicNumber = GetSomeMagicNumber2(someMagicNumber);
            Console.WriteLine(someMagicNumber);
        }

        static int GetSomeMagicNumber(int number)
        {
            int magic = number * number;

            if (magic % 3 == 0)
            {
                magic += 1000;
            }
            else
            {
                magic += 500;
            }

            magic *= number / 2;

            return magic;
        }

        static int GetSomeMagicNumber2(int number)
        {
            int magic = number * number;

            if (magic % 3 == 0)
            {
                magic += 1000;
            }
            else if (magic % 2 == 0)
            {
                return magic + 47;
            }
            else
            {
                magic += 500;
            }

            magic *= number / 2;

            return magic;
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
