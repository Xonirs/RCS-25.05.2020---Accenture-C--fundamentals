using System;

namespace Day17_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = GetStringValues(5);
            PrintArray(names);
        }

        //starting array {"", "Bob", "Tony", "", "", "Ann"}
        //result array { "Bob", "Tony","Ann" }

        public static string[] GetStringValues(int number)
        {
            string[] names = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Please input a name:");
                names[i] = Console.ReadLine();
            }

            return names;
        }

        public static void PrintArray(string[] array)
        {
            Console.WriteLine("Array values:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
