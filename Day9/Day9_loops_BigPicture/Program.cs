using System;

namespace Day9_loops_BigPicture
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 50, 99, 188, 186, 1003, 15, 7 };
            //while - use when you have some kind of complicated condition
            int counter = 0;
            string userInput = "";
            Console.WriteLine("While loop:");
            while (counter < numbers.Length && userInput != "STOP")
            {
                Console.Write(numbers[counter] + ", do you want to STOP? - ");
                userInput = Console.ReadLine();
                counter++;
            }
            Console.WriteLine();

            //do while - use when you have some kind of complicated condition, similar to while except condition check afterwards
            Console.WriteLine("Do..While loop:");
            do
            {
                Console.Write("Guess my favorite color: ");
                userInput = Console.ReadLine();
            } while (userInput != "green");
            Console.WriteLine();

            //for - use when you know EXACT count of iterations AND you CARE about (are going to use) the indexes
            Console.WriteLine("For loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            //foreach - use when need to iterate set of data AND you DON'T CARE about (not going to use) the indexes
            Console.WriteLine("Foreach loop:");
            foreach (int singleNumber in numbers)
            {
                Console.WriteLine(singleNumber);
            }
            
            //FUN EXAMPLES
            string anotherUserInput = "";
            while (anotherUserInput != "STOP")
            {
                Console.WriteLine("Do you want to STOP or ???");
                anotherUserInput = Console.ReadLine();

                Console.WriteLine("You typed:");
                foreach (char userChar in anotherUserInput)
                {
                    Console.WriteLine(userChar);
                }
            }
        }
    }
}
