using System;
using System.Collections.Generic;

namespace Day14_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var concert = new Concert();
            //concert.Band = "Brainstorm";
            //concert.Venue = "Arēna Rīga";
            //concert.Price = 50.00;
            //concert.Seats = 10000;
            //concert.Name = "Brainstorm back to the future";
            //concert.IsFull = false;
            //concert.ExpectedDuration = 4;

            //a different approach for creating an object
            var concert = new Concert()
            {
                Band = "Brainstorm",
                Venue = "Arēna Rīga",
                Price = 50.00,
                Seats = 5,
                Name = "Brainstorm back to the future",
                ExpectedDuration = 4,
                Date = new DateTime(2020, 9, 2)
            };
                        
            concert.PrintConcertInfo();
            concert.AddVisitor("John Heading", 21, 60.00);
            string message = concert.AddVisitor("Maria Tablecloth", 16, 60.00);
            Console.WriteLine(message);
            Console.WriteLine(concert.AddVisitor("Ann Bush", 21, 40.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine(concert.AddVisitor("Tom Juventus", 21, 60.00));
            Console.WriteLine();
            concert.PrintConcertInfo();
        }
    }
}
