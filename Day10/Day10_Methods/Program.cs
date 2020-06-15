using System;

namespace Day10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
            PrintName();
            //PrintMyName("John Table");
            //Console.WriteLine("What is your name");
            //string userInput = Console.ReadLine();
            //PrintMyName(userInput);

            //string userInput2 = GetUserValue();
            //Console.WriteLine($"Your input length was:{userInput2.Length}");
        }

        //method with no parameters but with a return value
        public static string GetUserValue()
        {
            Console.Write("Please type something: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        //method with no parameters
        public static void PrintName()
        {
            Console.WriteLine("Name MiddleName Surname");
        }

        //method with a single parameter
        public static void PrintMyName(string name)
        {
            Console.WriteLine($"Your name is: {name}");
        }
    }
}
