using System;

namespace Day10_recap_2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i = 0; i < array2Da.GetLength(0); i++)
            {
                for (int j = 0; j < array2Da.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}]={array2Da[i, j]}");
                }
            }

        }
    }
}
