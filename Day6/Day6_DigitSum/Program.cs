using System;

namespace Day6_DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which calculates the sum of digits of the entered number 
            //(e.g. 245 sum of digits is 2 + 4 + 5 = 11).
            Console.Write("Please enter number: ");
            string numberInput = Console.ReadLine();

            //Substring - text values, taking part of the text, for string data type
            //Length - the value of how many letters in the text, for string data type
            int sum = 0;
            int counter = 0;
            while (counter < numberInput.Length)
            {
                Console.WriteLine($"Iteration:{counter}");
                //digitInput - a single letter, in this case a digit
                string digitInput = numberInput.Substring(counter, 1);
                //digit - a parsed string to an int data type
                int digit = int.Parse(digitInput);
                //adding a digit value to the sum
                sum += digit;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }
}
