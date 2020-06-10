using System;

namespace Day6_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[] { 100, 200, 300, 0 };
            Console.WriteLine(grades[2]);
            grades[2] = 444;
            Console.WriteLine(grades[2]);
            Console.WriteLine($"The length of array: {grades.Length}");

            int number = grades[0];
            Console.WriteLine($"Number:{number}, array[0]:{grades[0]}");
            grades[0] = 999;
            Console.WriteLine($"Number:{number}, array[0]:{grades[0]}");
            grades[0] = 88;
            Console.WriteLine($"Number:{number}, array[0]:{grades[0]}");


            //Console.Write("Guess a movie: ");
            //string input = Console.ReadLine();
            //bool loopContinues = input != "avatar";
            //while (loopContinues)
            //{
            //    Console.Write("Incorrect movie! guess again: ");
            //    input = Console.ReadLine();
            //    loopContinues = input != "avatar";
            //}

            //Console.WriteLine("You guessed correctly");

            //bool loopContinues = true;
            //int counter = 0;
            //while (loopContinues)
            //{
            //    Console.WriteLine(counter);

            //    if (counter == 1000)
            //    {
            //        loopContinues = false;
            //    }

            //    counter++;
            //}
        }
    }
}
