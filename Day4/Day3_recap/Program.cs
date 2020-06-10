using System;

namespace Day3_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = "Adventures of the new coders";
            int age = 18;

            if (age >= 18 && (bookTitle.Length > 10 || bookTitle.Substring(bookTitle.Length - 1) == "!"))
            {
                Console.WriteLine("This is an exciting adult book");
            }
            else
            {
                Console.WriteLine("We are not interested in this book!");
            }

            //bool isWorkday = true;
            //int age = 20;

            //if (isWorkday && age >= 18)
            //{
            //    Console.WriteLine("You have to work today!");
            //}
            //else
            //{
            //    Console.WriteLine("You don't have to work today");
            //}

            ////Lets find out if it is a workday, without a conversion
            //Console.WriteLine("Is this a workday?");
            //string workdayInput = Console.ReadLine();
            //bool isWorkday = bool.Parse(workdayInput);

            //if (isWorkday)
            //{
            //    Console.WriteLine("Get up early, you have to work");
            //}
            //else
            //{
            //    Console.WriteLine("You can sleep in, you can relax on the weekend!");
            //}

            ////Lets find out if it is a workday, without a conversion
            //Console.WriteLine("Is this a workday?");
            //string workdayInput = Console.ReadLine();
            //if (workdayInput == "yes")
            //{
            //    Console.WriteLine("Get up early, you have to work");
            //}

            //string carName = "Skoda";

            //if (carName == "Audi")
            //{
            //    Console.WriteLine("The car you chose was Audi");
            //}
            //else if (carName == "BMW")
            //{
            //    Console.WriteLine("The car you chose was BMW");
            //}
            //else if (carName == "Mercedes")
            //{
            //    Console.WriteLine("The car you chose was Mercedes");
            //}
            //else 
            //{
            //    Console.WriteLine($"Your car was not expected, it was '{carName}'");
            //}

            //if (carName != "Audi")
            //{
            //    Console.WriteLine("Your car could be any of the cars, but NOT Audi");
            //}

            //bool sunny = true;
            //bool rainy = false;
            //bool firstLecture = false;
            //bool fourthLecture = true;

            ////Conversion of data types
            //Console.WriteLine("How big is your family now?");
            //string familyMemberCount = Console.ReadLine();

            //int familyMemberCount1 = Convert.ToInt32(familyMemberCount);
            //int familyMemberCount2 = int.Parse(familyMemberCount);

            ////Family is growing bigger, mom just had twins
            //familyMemberCount1 = familyMemberCount1 + 2;
            //Console.WriteLine($"After the twins our family count is {familyMemberCount1}");

            ////Conversion to double
            //Console.WriteLine("What is your salary?");
            //string salaryInput = Console.ReadLine();
            //double salary = double.Parse(salaryInput);
            //Console.WriteLine($"Your salary is {salary}.");
            //Console.WriteLine($"Your salary is {salary - 430.00} EUR away from the minimal wage 430 EUR.");
        }
    }
}
