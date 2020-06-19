using System;

namespace Day12_method_differentFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your age");
            int age = int.Parse(Console.ReadLine());
            TestClass.PrintBirthYear(age);
        }
    }
}
