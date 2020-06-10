using System;

namespace Day3_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 16;
            if (age > 17)
            {
                Console.WriteLine("You can buy alcohol");

                if (age > 24)
                {
                    Console.WriteLine("You don't have to show ID on your own");
                }
                else 
                {
                    Console.WriteLine("You have to show ID on your own");
                }
            }
            else
            {
                Console.WriteLine("You are not allowed to drink!");
            }
            Console.WriteLine();

            if (age > 60)
            {
                Console.WriteLine("You can be a pope");
            }
            else if (age > 40)
            {
                Console.WriteLine("You can be the president");
            }
            else if (age > 17)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("Stay in school and study!");
            }

            bool sunny = true;
            if (sunny)
            {
                Console.WriteLine("sunny");
            }
            else
            {
                Console.WriteLine("NOT SUNNY");
            }
            

            //Console.WriteLine("Start");
            //int number = -67;
            //if (number > 5) 
            //{
            //    Console.WriteLine("Number was bigger than 5");
            //}

            //Console.WriteLine("End");
        }
    }
}
