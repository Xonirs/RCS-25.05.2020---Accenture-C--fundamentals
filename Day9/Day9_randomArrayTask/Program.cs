using System;

namespace Day9_randomArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an int array with size of 10.
            var numberArray = new int[10];

            //Assign all the elements with Random values. 
            for (int i = 0; i < numberArray.Length; i++)
            {
                Random random = new Random();
                int a = random.Next(100); //random values until 100
                numberArray[i] = a;
            }

            //In a new loop, print all the values.
            foreach (int number in numberArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
