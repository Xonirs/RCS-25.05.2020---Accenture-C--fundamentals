using System;
using System.Collections.Generic;

namespace Day12_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Method Usage
            ////argument - is the actual value of this variable which gets passed in/to method
            ////in this case - argument is {"Test text value"}
            //TestMethod("Test text value");

            //int numberOfPets = 5;
            //string[] petNames = CreatePetArray(numberOfPets);
            //Console.WriteLine("These are your pets:");
            //foreach (var pet in petNames)
            //{
            //    Console.WriteLine(pet);
            //}
            #endregion
            #region Overload usage
            Console.WriteLine(GetText());
            Console.WriteLine(GetText(6));
            Console.WriteLine(GetText(6, "is real"));
            Console.WriteLine(GetText(4, "is not real"));
            #endregion

            PrintSum(10, 5);
            PrintSum(10);
            IsAllGood(true, true, true);
            IsAllGood(true, true);
            IsAllGood(true);
            PrintAllInfo("Nokia", 999.85, "Developer");
            PrintAllInfo("Nokia", 999.85);
            PrintAllInfo("Nokia");
            PrintAllInfo("Nokia", jobTitle: "CEO");
        }

        #region Class questions methods

        private static string[] CreatePetArray(int numberOfPets)
        {
            var result = new string[numberOfPets];

            for (int i = 0; i < numberOfPets; i++)
            {
                Console.Write($"Please name your nr.{i + 1} pet: ");
                result[i] = Console.ReadLine();
            }

            return result;
        }

        //parameter - is the variable definition in the declaration of method
        //in this case - parameter is {string text}
        public static void TestMethod(string text)
        {
            Console.WriteLine(text);
        }

        #endregion

        #region Overload methods
        public static string GetText()
        {
            return "magic";
        }

        public static string GetText(int number)
        {
            return number > 5 ? "magic" : "not magic";
        }

        public static string GetText(int number, string extraText)
        {
            if (number > 5)
            {
                return "magic " + extraText;
            }
            else
            {
                return "not magic " + extraText;
            }
        }
        #endregion

        public static void PrintSum(int a, int b = 7)
        {
            Console.WriteLine($"The sum of parameters are {a + b}");
        }

        public static void IsAllGood(bool param1, bool param2 = false, bool param3 = true)
        {
            if (param1 && param2 && param3)
            {
                Console.WriteLine("Everything is good");
            }
            else
            {
                Console.WriteLine("Something is not good");
            }
        }

        public static void PrintAllInfo(string company, double salary = 355.67, string jobTitle = "Assistant")
        {
            Console.WriteLine($"Company: {company}, salary: {salary}, job title: {jobTitle}");
        }
    }
}
