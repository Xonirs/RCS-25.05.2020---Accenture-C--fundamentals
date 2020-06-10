using System;

namespace Day2_ConsoleReadline
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string alphabet2 = "abcdefghijklmnoplkjdsafldsafhlkdsahfkjdsahfkjdsahflkdsahfqrstuvwxyz";
            // Substring - to get part of a text
            // 0 - the nr of letter we start to take the new string, 0 means the first
            // 1 - the count of letters we take from the start, 1 means 1
            string firstLetter = alphabet.Substring(0, 1); //a
            string first3Letters = alphabet.Substring(0, 3); //abc
            string middle3Letters = alphabet.Substring(10, 3); //klm

            // 3 - the nr of letter we start to take the new string, 3 means the 4th
            // if there is only one value passed, then part of text is till the end
            string everythingFrom4th = alphabet.Substring(3); //defghijklmnopqrstuvwxyz

            string lastLetter = alphabet.Substring(alphabet.Length - 1); //z

            Console.WriteLine(lastLetter);

            Console.WriteLine();
            Console.WriteLine("What is your name?");
            //from Console we ONLY read TEXT values
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}");
            int length = name.Length;
            Console.WriteLine($"Your name length is: {length} / {name.Length}");

            Console.Write("What is your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"Your surname is: {surname}");

            Console.WriteLine($"My magic number is: {name + 54321}");

            Console.WriteLine($"Your full name is: {name} {surname}");


            Console.WriteLine("FINISHED EXECUTION");
        }
    }
}
