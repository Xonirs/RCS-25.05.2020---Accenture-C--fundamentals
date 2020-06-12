using System;

namespace Day9_MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define an int array with at least 5 values. Find the max and min values and print them out.
            int[] numbers = { 5, 68, 10, 16, 100, 4 };
            int max = numbers[0];
            int min = numbers[0];

            //Since we already examined the first element, we can continue from the second
            //thus, i = 1
            for (int i = 1; i < numbers.Length; i++)
            {
                Console.WriteLine($"Loop i value: {i}, current array element: {numbers[i]}, previous max: {max}");

                //if the current number in array is greater than the previous max
                if (numbers[i] > max)
                {
                    // we change it
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Max:{max}, Min:{min}");
        }
    }
}
