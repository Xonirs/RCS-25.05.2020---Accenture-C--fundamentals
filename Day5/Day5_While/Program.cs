using System;

namespace Day5_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First loop begins");
            int n = 37;
            while (n < 45)
            {
                Console.WriteLine(n);
                n++;
            }

            Console.WriteLine("Second loop begins");
            string text = "";
            while (text != "tatatata")
            {
                Console.WriteLine($"Value of text:'{text}'");
                text = text + "ta";
            }
            Console.WriteLine("Third loop begins");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter += 3;
            }

            Console.WriteLine("Fourth loop begins");
            int counter1 = 0;
            int counter2 = 0;
            while (counter1 < 100 && counter2 < 50)
            {
                Console.WriteLine($"Counter1:{counter1}, counter2:{counter2}");
                counter1 += 3;
                counter2 += 13;
            }

            Console.WriteLine("Fivth loop begins");
            bool sunny = true;
            //the code executes while it is sunny
            while (sunny)
            {
                Console.WriteLine("Is it still sunny?");
                string answer = Console.ReadLine();
                sunny = answer == "yes";
            }

            Console.WriteLine("Sixth loop begins");
            bool rainy = false;
            int rainCounter = 1;
            //the code executes while it is NOT rainy
            while (!rainy)
            {
                Console.WriteLine($"Loop has executed for {rainCounter} times");
                Console.WriteLine("Did it start to rain?");
                string answer = Console.ReadLine();
                rainy = answer == "yes";
                rainCounter++;
            }
        }
    }
}
