using System;

namespace Day3_IfUsage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get a number from a user. 
            Console.Write("Please enter a number:");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);

            //If the number is between 0 and 10 then 
            if (0 < number && number < 10)
            {
                //print out “A” and 
                Console.WriteLine("A");
            }
            //if the value is larger than 10, 
            else if (number > 10)
            {
                //then print out “B”.
                Console.WriteLine("B");
            }
        }
    }
}
