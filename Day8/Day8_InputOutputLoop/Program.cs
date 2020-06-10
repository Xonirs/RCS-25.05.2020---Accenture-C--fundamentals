using System;

namespace Day8_InputOutputLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number N. Define a string array with the size of N. 
            Console.Write("How many relatives do you have: ");
            var numberInput = Console.ReadLine();
            var relativeCount = int.Parse(numberInput);
            string[] relatives = new string[relativeCount];

            //Then create a loop, which will ask the user to input your relative names for N times and 
            for (int i = 0; i < relativeCount; i++)
            {
                Console.Write($"What is your relative nr.{i + 1} name:");
                //the names are saved in the array.
                relatives[i] = Console.ReadLine();
            }

            //Then in a NEW loop look at all the names and 
            for (int i = 0; i < relativeCount; i++)
            {
                //print those whose length is greater than 5.
                if (relatives[i].Length > 5)
                {
                    Console.WriteLine(relatives[i]);
                }
            }

        }
    }
}
