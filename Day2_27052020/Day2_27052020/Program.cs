using System;

namespace Day2_27052020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jānis";
            int age = 50;
            double salary = 430.43;
            char myFirstLetter = 'J';
            bool holiday = false;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(myFirstLetter);
            Console.WriteLine(holiday);
            Console.WriteLine();

            age = 100 - age + (87 * 2);
            Console.WriteLine(age);

            string myFavoriteFood;
            Console.WriteLine("We will now assign our favorite food:");
            myFavoriteFood = "pasta";
            Console.WriteLine(myFavoriteFood);
            Console.WriteLine();

            Console.WriteLine("Test value");
            Console.WriteLine(1234);
            Console.WriteLine(1234 + 4321);
            Console.WriteLine("1234 + 4321");
            
        }
    }
}
