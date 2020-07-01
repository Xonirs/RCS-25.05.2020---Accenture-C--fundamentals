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
                Seats = 10000,
                Name = "Brainstorm back to the future",
                IsFull = false,
                ExpectedDuration = 4,
                Visitors = new List<Visitor>()
            };



            concert.PrintConcertInfo();
        }
    }
}
