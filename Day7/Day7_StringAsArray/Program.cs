using System;

namespace Day7_StringAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abc@efghijklmnopqrstuvwxyz";
            char firstLetter = alphabet[0];
            Console.WriteLine(firstLetter);
            char fourthLetter = alphabet[3];
            Console.WriteLine(fourthLetter);

            string name = "John";
            name += fourthLetter;
            Console.WriteLine(name);

            // .ToString()
            //for any value of any data type, you can convert it to string
            int number = 1231232634;
            string numberText = number.ToString();
            Console.WriteLine($"This number {number} has {numberText.Length} digits");
        }
    }
}
