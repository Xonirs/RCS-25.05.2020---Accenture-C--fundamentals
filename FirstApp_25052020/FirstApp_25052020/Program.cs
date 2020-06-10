using System;

namespace FirstApp_25052020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jānis";
            int dayOfTheMonth = 25;
            int dayofthemonth = 25;
            int DAYOFTHEMONTH = 25;
            char favoriteSymbol = '#';
            double daysTillSummer = 3.125;
            float minimalWage = 430.00F;
            bool firstLecture = true;
            bool isMoonShining = false;

            Console.WriteLine(name);
            Console.WriteLine(dayOfTheMonth);
            Console.WriteLine(favoriteSymbol);
            Console.WriteLine(daysTillSummer);
            Console.WriteLine(minimalWage);
            Console.WriteLine(firstLecture);
            Console.WriteLine(isMoonShining);

            Console.WriteLine();
            string weather = "sunny";
            Console.WriteLine(weather);
            Console.WriteLine("Jānis Lācis");
            Console.WriteLine("This text is now being printed!");
            Console.WriteLine();

            int number = 100;
            Console.WriteLine(number);
            Console.WriteLine(100 + 50);
            Console.WriteLine("100 + 50");
            Console.WriteLine(100 + number);
            Console.WriteLine();

            number = 35;
            Console.WriteLine("New number value:");
            Console.WriteLine(number);
            Console.WriteLine(100 + number);
            Console.WriteLine();

            int otherNumber = 87;
            number = 100 - otherNumber;
            Console.WriteLine("New NEW number value:");
            Console.WriteLine(number);
            Console.WriteLine(100 + number);
            Console.WriteLine();

            int nrOfLectures;
            bool hasCourseStarted;

            Console.WriteLine("Course has started, lectures - 27");

            nrOfLectures = 27;
            hasCourseStarted = true;
            Console.WriteLine(nrOfLectures);
            Console.WriteLine(hasCourseStarted);


        }
    }
}
