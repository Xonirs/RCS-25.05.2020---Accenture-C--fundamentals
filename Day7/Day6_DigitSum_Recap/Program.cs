using System;

namespace Day6_DigitSum_Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program which calculates the sum of digits of the entered number 
            //(e.g. 245 sum of digits is 2 + 4 + 5 = 11).
            Console.Write("Please enter number: ");
            string numberInput = Console.ReadLine();

            //Solution:
            //We have a number. We take this number and look at it's each digit
            //In order to look at each digit we are using a loop - while
            //Loop setup:
            //In this loop we will examine each digit. In order to do that
            //Loop has to execute for each digit - so if we input a number in format of string
            //then loop will execute that input string length times. 
            //meaning:245, loop executes 3 times, because "245" value Length is 3
            //Inside of the loop:
            //We have to get a digit from the input string. In this case we can take a part of string
            //since the input value is in string data type, that means 
            //In order to do this, we can use Substring and each time take only 1 letter/digit
            //Then with this string digit, we convert the value to int data type
            //Then we have this number value with correct data type, 
            //so we can add this to the result sum. after the loop, print the sum.
            int sum = 0;
            int counter = 0;
            while (counter < numberInput.Length) //condition must have a bool value
            {
                string digitText = numberInput.Substring(counter, 1);
                Console.WriteLine($"Loop counter: {counter}, the symbol postion: {counter}, digit: {digitText}");
                int number = int.Parse(digitText);
                sum += number;
                counter++;
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
