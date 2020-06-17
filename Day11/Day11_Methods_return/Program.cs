using System;

namespace Day11_Methods_return
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            int sum = CalculateSum(number, 48);
            Console.WriteLine(sum);
            Console.WriteLine(CalculateSum(sum, sum - number));
            int newSum = CalculateSum(17, 8);
            Console.WriteLine(newSum);

            Console.WriteLine(CalculateSubtraction(sum, 14, number));
            int sub1 = CalculateSubtraction(100, number, 5);
            Console.WriteLine($"Subtraction was {sub1}");

            string foodValue1 = GetFoodCritism("burger"); Console.WriteLine(foodValue1);
            string foodValue2 = GetFoodCritism("cookies"); Console.WriteLine(foodValue2);
            string foodValue3 = GetFoodCritism("pasta"); Console.WriteLine(foodValue3);

            string drinkValue1 = GetDrinkCritism("coke"); Console.WriteLine(drinkValue1);
            string drinkValue2 = GetDrinkCritism("water"); Console.WriteLine(drinkValue2);
            string drinkValue3 = GetDrinkCritism("juice"); Console.WriteLine(drinkValue3);
        }

        static int CalculateSum(int x, int y)
        {
            Console.WriteLine($"we are about to sum parameters x: {x} and y: {y}!");
            int greeenBananananas = x + y;
            return greeenBananananas;
        }

        static int CalculateSubtraction(int number1, int number2, int number3)
        {
            return number1 - number2 - number3;
        }

        static string GetFoodCritism(string food)
        {
            string result = "";

            if (food == "burger")
            {
                result = "you don't like burgers";
            }
            else if (food == "cookies")
            {
                result = "you love cookies!";
            }
            else
            {
                result = $"you have no preference on {food}";
            }

            return result;
        }

        //if you want to use multiple returns in a method, you must obey the golden rule:
        //Golden rule - every path flow of the method MUST have a keyword return if return type specified
        static string GetDrinkCritism(string drink)
        {
            if (drink == "coke")
            {
                return "you don't like coke";
            }
            else if (drink == "water")
            {
                return "you love water!";
            }
            else
            {
                return $"you have no preference on {drink}";
            }
        }
    }
}
