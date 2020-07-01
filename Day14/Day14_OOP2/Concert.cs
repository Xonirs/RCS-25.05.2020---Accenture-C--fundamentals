using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_OOP2
{
    class Concert
    {
        public string Band;
        public string Venue;
        public double Price;
        public int Seats;
        public string Name;
        public int ExpectedDuration;
        //date
        public DateTime Date;
        private List<Visitor> Visitors = new List<Visitor>();

        public Concert()
        {

        }

        public void PrintConcertInfo()
        {
            Console.WriteLine("This is the concert info:");
            Console.WriteLine($"Band: {Band}");
            Console.WriteLine($"Venue: {Venue}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ExpectedDuration: {ExpectedDuration}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Visitor count: {Visitors.Count}");
            Console.WriteLine();
        }

        //AddVisitor - basically selling tickets and letting in visitors
        public string AddVisitor(string fullName, int age, double money)
        {
            //check the age for visitor
            if (age < 18)
            {
                return "This visitor is too young!";
            }
            //checking if visitor has enough money for ticket
            if (money < Price)
            {
                return "Visitor can't afford the ticket!";
            }
            //checking if the venue is full
            if (IsVenueFull())
            {
                return "Venue is full, no more visitors!";
            }
            //No errors found, proceed with adding this visitor to concert
            var visitor = new Visitor()
            {
                FullName = fullName,
                Age = age,
                TicketMoney = money,
                SeatNumber = Visitors.Count + 1
            };

            Visitors.Add(visitor);

            return "Success, visitor was added";
        }

        private bool IsVenueFull()
        {
            return Seats == Visitors.Count;
        }
    }
}
