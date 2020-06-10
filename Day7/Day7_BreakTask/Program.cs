using System;

namespace Day7_BreakTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array of values 1,1,1,0,1,1,1, 1. 
            var values = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            //Print all the values until you find 0, once 0 is found, exit the loop. Use break;
            int counter = 0;
            while (counter < values.Length)
            {
                Console.WriteLine(values[counter]);
                if (values[counter] == 0)
                {
                    break;
                }

                counter++;
            }
            Console.WriteLine();

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
                if (values[i] == 0)
                {
                    break;
                }
            }
        }
    }
}
