using System;

namespace Day5_CantConvertToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application which will read 4 text values from user and prints out only those, 
            //who can’t be converted as a number of data type int.
            Console.WriteLine("Please enter a number:");
            string numberInput = Console.ReadLine();
            int number;
            bool conversionSuccess = int.TryParse(numberInput, out number);
            if (!conversionSuccess)
            {
                Console.WriteLine($"This is not a number {numberInput}");
            }
        }
    }
}
