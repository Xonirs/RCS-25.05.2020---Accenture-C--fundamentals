using System;

namespace Day8_percentageSign
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - / *

            // %
            // When we do a division then we can get the value of division and the number which is the remainder
            // % gives us this remainder
            // Example, 15 divided by 4 equals 3 (because 4 * 3 = 12) and the remainder is 3
            // Example2, 17 / 5 = 3, remainder is 2
            int remainder1 = 100 % 3; // equals to 1, because 100 / 3 = 33, 33 * 3 = 99 and 100 - 99 = 1
            Console.WriteLine($"100 % 3 = {remainder1}");
            Console.WriteLine($"55 % 16 = {55 % 16}");
        }
    }
}
