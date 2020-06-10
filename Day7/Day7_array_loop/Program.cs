using System;

namespace Day7_array_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Tom", "Bob", "Angela", "Ann" };
            Console.WriteLine($"First value:{names[0]}");
            Console.WriteLine($"Second value:{names[1]}");

            Console.WriteLine($"This is an array of string, with {names.Length} values:");
            int counter = 0;
            while (counter < names.Length)
            {
                Console.WriteLine($"Counter: {counter}, array element: {names[counter]}");
                counter++;
            }


            // var
            //you can define any variable of ANY DATA TYPE with the keyword "var"
            var number = 10;
            var name = "John";
            var salary = 100.01;
            var isRainingLikeCrazy = true;
            var testArray = new int[] { 1, 2, 3 };
            //when using "var", you MUST set a value;
            //var count;  //will not work            
        }
    }
}
