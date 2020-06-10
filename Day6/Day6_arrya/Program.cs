using System;

namespace Day6_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //INT ARRAY
            Console.WriteLine("INT ARRAY:");
            int[] grades = new int[] { 10, 5, 8, 7, 8 };
            //first element of array
            int firstGrade = grades[0];
            Console.WriteLine(firstGrade + " " + grades[0]);

            //third element of array
            int thirdGrade = grades[2];
            Console.WriteLine(thirdGrade + " " + grades[2]);

            //array length
            int arrayLength = grades.Length;
            Console.WriteLine(arrayLength + " " + grades.Length);
            Console.WriteLine();

            //STRING ARRAY
            Console.WriteLine("STRING ARRAY:");
            string[] foods = new string[] { "banana","ice cream", "kiwi", "chicken", "pasta" };
            //first element of array
            string firstFood = foods[0];
            Console.WriteLine(firstGrade + " " + foods[0]);

            //third element of array
            string thirdFood = foods[2];
            Console.WriteLine(thirdGrade + " " + foods[2]);

            //array length
            int arrayFood = foods.Length;
            Console.WriteLine(arrayFood + " " + foods.Length);

            //second element of array
            Console.WriteLine($"Second food is:{foods[1]}");
            //changing second foood to a new value
            foods[1] = "chocolate";
            Console.WriteLine($"Second food is:{foods[1]}");

        }
    }
}
