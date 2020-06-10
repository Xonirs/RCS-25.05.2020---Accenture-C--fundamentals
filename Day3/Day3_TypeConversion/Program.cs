using System;

namespace Day3_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            string ageInput = Console.ReadLine();
            //In order to create an int value, we have to convert the string to int

            //1st way
            //Convert.ToInt32
            //ageInput - that is the value which we will try to CONVERT
            int age1 = Convert.ToInt32(ageInput);
            Console.WriteLine($"Your age is {ageInput}, so that means you were born in {2020 - age1}");

            //2st way
            //int.Parse
            //ageInput - that is the value which we will try to PARSE
            int age2 = int.Parse(ageInput);
            Console.WriteLine($"Your age is {ageInput}, so that means you were born in {2020 - age2}");

            
        }
    }
}
