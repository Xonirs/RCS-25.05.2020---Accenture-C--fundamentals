using System;

namespace Day7_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 3; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = -25; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Please input beginning of i:");
            string beginningInput = Console.ReadLine();
            int beginning = int.Parse(beginningInput);

            Console.WriteLine("Please input count:");
            string countInput = Console.ReadLine();
            int count = int.Parse(countInput);

            Console.WriteLine("Please input incremental value of i:");
            string incrementInput = Console.ReadLine();
            int increment = int.Parse(incrementInput);
            for (int i = beginning; i < count; i += increment)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            var grades = new int[] { 10, 9, 5, 6, 8, 4, 10 };
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
