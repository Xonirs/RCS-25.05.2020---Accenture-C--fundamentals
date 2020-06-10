using System;

namespace Day4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //which will ask for 2 numbers and for some kind of mathematical action (+,-,*,/). 
            //Print the result of this action in Console. For example, 5+3=8
            Console.Write("Please enter first number:");
            string numberInput1 = Console.ReadLine();
            int number1 = int.Parse(numberInput1);

            Console.Write("Please enter second number:");
            string numberInput2 = Console.ReadLine();
            int number2 = int.Parse(numberInput2);

            Console.Write("Please enter an action:");
            string action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("We can't process this kind of action.");
                    break;
            }
        }
    }
}
