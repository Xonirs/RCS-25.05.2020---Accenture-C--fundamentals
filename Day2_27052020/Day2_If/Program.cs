using System;

namespace Day2_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endOfLecture = false;
            if (endOfLecture)
            {
                Console.WriteLine("End of lecture is near");
            }
            else
            {
                Console.WriteLine("End of lecture IS NOT near");
            }

            int x = 3;
            bool condition = x > 2;
            if (condition)
            {
                Console.WriteLine("X greater than 3");
            }

            Console.WriteLine();

            Console.WriteLine("Start!");
            int salary = 150;
            int minimumWage = 430;
            if (salary > minimumWage)
            {
                //this code will only execute if the first condition above is TRUE
                Console.WriteLine("Your salary is bigger than the minimum wage");
            }
            else if (salary < 100)
            {
                //this code will only execute if the SECOND condition above is TRUE AND the FIRST is FALSE
                Console.WriteLine("Your salary is smaller than 100");
            }
            else if (salary < 200)
            {
                //this code will only execute if the SECOND condition above is TRUE AND the FIRST is FALSE
                Console.WriteLine("Your salary is smaller than 200");
            }
            else
            {
                //this code will only execute if BOTH conditions above are FALSE
                Console.WriteLine("Your salary is smaller than the minimum wage but bigger than 100");
            }
            
            Console.WriteLine("END");
        }
    }
}
