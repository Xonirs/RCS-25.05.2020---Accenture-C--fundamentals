using System;

namespace Day16
{
    class Park
    {
        public Tree Tree1;
        public Tree Tree2;
        public string Name;
    }

    class Tree
    {
        public string Type;
        public int Age;
        public string Id;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Park park = new Park();
            if (park.Tree1 != null)
            {
                Console.WriteLine(park.Tree1.Age); 
            }
            Tree tree; //here, the value is null. Hence, we can't work with this variable in any way
            Tree tree2 = null;
            Console.WriteLine(tree2.Age);
        }
    }
}
