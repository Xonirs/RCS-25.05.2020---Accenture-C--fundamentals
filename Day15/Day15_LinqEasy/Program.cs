using System;
using System.Collections.Generic;
using System.Linq;

namespace Day15_LinqEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "John", "Ann", "Cecilia", "Bob", "Cristopher", "Magnolia" };

            //the first with value Ann
            string result = names.First(n => n == "Ann");
            Console.WriteLine(result);

            //the first with value Tom
            result = names.FirstOrDefault(n => n == "Tom");
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("There was no Tom"); 
            }
            else
            {
                Console.WriteLine(result);
            }

            //the first with value Cristopher
            result = names.FirstOrDefault(n => n == "Cristopher");
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("There was no Cristopher");
            }
            else
            {
                Console.WriteLine(result);
            }

            //the first with value user input
            result = names.FirstOrDefault(n => n == Console.ReadLine()); //Console.Readline will execute for all list values
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("There was no value of user input");
            }
            else
            {
                Console.WriteLine(result);
            }


            result = names.FirstOrDefault(n => IsThisNameGood(n));
        }

        private static bool IsThisNameGood(string n)
        {
            //do magic stuff for each name and don't forget to return bool value
            return true;
        }
    }
}
