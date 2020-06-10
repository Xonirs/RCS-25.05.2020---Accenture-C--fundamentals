using System;

namespace Day7_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            //do..while loop will ALWAYS execute at least once
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);
        }
    }
}
