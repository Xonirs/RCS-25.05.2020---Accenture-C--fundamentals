using System;

namespace Day4_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            string ageInput = Console.ReadLine();

            //ageInput - the string value user inputs in console
            //isTheInputAnInt - a bool value which tells us whether "ageInput" conversion to int was successful
            //      true - means that ageInput CAN be converted to int
            //      false - means that ageInput CANNOT be converted to int
            //age - an int value which will have the converted value IF the conversion was successful
            //      "conversion was successful" - means that the "isTheInputAnInt" is TRUE
            int age;
            bool isTheInputAnInt = int.TryParse(ageInput, out age);
            if (isTheInputAnInt)
            {
                Console.WriteLine("Your input was a whole number!");
                Console.WriteLine($"Your age is {age}!");
            }
            else
            {
                Console.WriteLine("Your input was NOT a whole number!");
                Console.WriteLine($"Your input is {ageInput}!");
            }

            //example of double
            Console.WriteLine("Please enter your salary:");
            string salaryInput = Console.ReadLine();
            double salary;
            bool isTheInputAnDouble = double.TryParse(salaryInput, out salary);
            if (isTheInputAnDouble)
            {
                Console.WriteLine("Your input was a double value!");
                Console.WriteLine($"Your age is {salary}!");
            }
            else
            {
                Console.WriteLine("Your input was NOT a double value!");
                Console.WriteLine($"Your input is {salaryInput}!");
            }
        }
    }
}
