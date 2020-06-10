using System;

namespace Day7_breakcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    break; // exit the loop
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 7 || i == 8)
                {
                    continue; // goes to the next loop iteration
                }

                Console.WriteLine(i);                
            }
        }
    }
}
