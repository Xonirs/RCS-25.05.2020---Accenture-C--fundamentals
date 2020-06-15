using System;

namespace Day10_multiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            //outer loop - for rows
            //array2Da.GetLength(0) - gets the value for 1st dimension
            for (int i = 0; i < array2Da.GetLength(0); i++)
            {
                //inner loop - for columns
                //array2Da.GetLength(1) - gets the value for 2nd dimension
                for (int j = 0; j < array2Da.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}]={array2Da[i, j]}");
                }
            }
            //changing all the elements to the same value
            //for (int i = 0; i < array2Da.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2Da.GetLength(1); j++)
            //    {
            //        array2Da[i, j] = 99;
            //    }
            //}
            //changing just 1 values
            array2Da[1, 1] = 87888;
            Console.WriteLine("After change:");
            for (int i = 0; i < array2Da.GetLength(0); i++)
            {
                for (int j = 0; j < array2Da.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}]={array2Da[i, j]}");
                }
            }

            //task: find all values which are greater than 5, print them
            Console.WriteLine("Task result output:");
            for (int i = 0; i < array2Da.GetLength(0); i++)
            {
                for (int j = 0; j < array2Da.GetLength(1); j++)
                {
                    if (array2Da[i, j] > 5)
                    {
                        Console.WriteLine($"[{i},{j}]={array2Da[i, j]}");
                    }
                }
            }
        }
    }
}
