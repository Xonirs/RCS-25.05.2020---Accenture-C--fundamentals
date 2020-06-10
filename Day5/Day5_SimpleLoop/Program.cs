using System;

namespace Day5_SimpleLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters number N. 
            //Output all the numbers from 1 to N except the number 5 and number 10.
            Console.Write("Please enter a number:");
            string numberInput = Console.ReadLine();
            int n = int.Parse(numberInput);

            //counter - is used to keep track of how many times we have executed the loop
            //          or any other count usage we want.
            //          When we count, we can start from any value, be it 0, 1, 15, 101, etc
            int counter = 1;
            //Loop is read: This loop will execute WHILE the COUNTER is LESS than or EQUAL to the N
            //meaning that all the values below N and N would satisfy this condition
            while (counter <= n)
            { 
                //If the counter is NOT equal to 5 AND is NOT equal to 10
                //Then we proceed with the printing the numbers
                if (counter != 5 && counter != 10)
                {
                    //Printing out the counter value
                    Console.WriteLine(counter); 
                }

                //increasing the counter value after each iteration
                counter++;
            }
        }
    }
}
