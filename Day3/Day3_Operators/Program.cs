using System;

namespace Day3_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (name == "John" || name != "Gerber")
            {
                Console.WriteLine("All good, welcome!");
            }

            //if (name == "John")
            //{
            //    Console.WriteLine("Welcome, John!");
            //}
            //else if (name != "Gerber")
            //{
            //    Console.WriteLine("Thank god, Gerber's not here!");
            //}

            string color = "red";
            string gColor = "green";
            int age = 50;
            if (gColor == "green" && age > 30)
            {
                Console.WriteLine("This is a green grown up");
            }

            if (color.Length >= 3 || age < 40)
            {
                Console.WriteLine("Mystical combination of data");
            }

        }
    }
}
