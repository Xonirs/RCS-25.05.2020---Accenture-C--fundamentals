using System;
using System.Collections.Generic;

namespace Day10_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //adding numbers
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(1000);

            //we can treat them in a way as arrays with indexes
            Console.WriteLine("All values");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            numbers[1] = 999;

            Console.WriteLine("All values after change");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            //we can get the count of how many elements do we have
            Console.WriteLine($"List has {numbers.Count} elements");

            //printing elements
            Console.WriteLine("For loop:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"nr.{i+1} elements is {numbers[i]}");
            }

            Console.WriteLine("Foreach loop:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //removing elements
            //1st way - to remove without knowing if it was successful
            numbers.Remove(100);
            numbers.Remove(123);

            Console.WriteLine("Foreach loop after removal:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //2nd way - to remove by checking whether removal was successful
            bool removing100 = numbers.Remove(100); 
            Console.WriteLine($"Removal of 100 - {removing100}");
            bool removing10 = numbers.Remove(10); 
            Console.WriteLine($"Removal of 10 - {removing10}");

            Console.WriteLine("Foreach loop after 2nd removal:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
