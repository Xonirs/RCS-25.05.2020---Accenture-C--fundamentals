using System;

namespace Day9_recap_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Ann", "Bob", "Marry" };
            Console.WriteLine("For loop:");
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
                if (name == "Ann")
                {
                    names[i] = "NEW ANN";
                }
            }

            Console.WriteLine("For loop nr.2:");
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                Console.WriteLine(name);
            }

            Console.WriteLine("Foreach loop:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (name == "Ann")
                {
                    //names[i] = "NEW ANN"; //will not work
                    //name = "NEW ANN"; //will not work
                }
            }
        }
    }
}
