using System;

namespace Day12_method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] grades = { 10, 9, 8, 23, 44 };
            //string text = "Bobby Fischer";
            //GetInfo(grades);
            //GetInfo(text);
            string userNameSurname1 = GetNameSurname();
            Console.WriteLine($"Your full name is {userNameSurname1}");
            string name = "Ann";
            string userNameSurname2 = GetNameSurname(name);
            Console.WriteLine($"Your full name is {userNameSurname2}");
        }

        static string GetNameSurname()
        {
            Console.WriteLine("What is your name and surname?");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static string GetNameSurname(string name)
        {
            Console.WriteLine("What is your surname?");
            string userInput = Console.ReadLine();
            return name + " " + userInput;
        }

        //static method with string input parameter without return value
        public static void GetInfo(string promptText)
        {
            int textLength = promptText.Length;
            Console.WriteLine($"Text {promptText} length is {textLength}");
            Console.WriteLine($"Text {promptText} first letter is {promptText[0]}");
        }

        //static method with int input parameter without return value
        public static void GetInfo(int[] numbersArray)
        {
            int arrayLength = numbersArray.Length;
            Console.WriteLine($"Number array size is {arrayLength}");
            Console.WriteLine($"Number array first element is {numbersArray[0]}");
        }

    }
}
