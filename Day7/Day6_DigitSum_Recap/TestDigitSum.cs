using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_DigitSum_Recap
{
    class TestDigitSum
    {
        static void asdsada(string[] args)
        {
            //Create a program which calculates the sum of digits of the entered number 
            //(e.g. 245 sum of digits is 2 + 4 + 5 = 11).
            Console.Write("Please enter number: ");
            string numberInput = Console.ReadLine();
            int sum = 0;
            int counter = 0;
            while (counter < numberInput.Length) //condition must have a bool value
            {
                sum += int.Parse(numberInput.Substring(counter, 1)); //sum = sum + {value}
                counter++; // counter = counter + 1
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
