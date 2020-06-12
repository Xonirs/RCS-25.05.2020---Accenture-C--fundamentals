using System;

namespace Day9_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "Marry", "Peter", "Angela", "Tom" };

            //name - a variable which will represent all of the names array values
            //names - is the data set we are going through
            foreach (string cuteLittlePuppies in names)
            {
                Console.WriteLine(cuteLittlePuppies);
            }
            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                string cuteLittlePuppies = names[i];
                Console.WriteLine(cuteLittlePuppies);
            }
        }
    }
}
