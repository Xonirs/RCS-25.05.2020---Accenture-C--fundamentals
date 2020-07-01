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
        public bool IsFull;
        public int ExpectedDuration;
        //date
        public List<Visitor> Visitors;

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
            Console.WriteLine($"IsFull: {IsFull}");
            Console.WriteLine($"ExpectedDuration: {ExpectedDuration}");
            //Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Visitor count: {Visitors.Count}");
            Console.WriteLine();
        }

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
                TicketMoney = money
            };

            Visitors.Add(visitor);

            return "Success";
        }

        private bool IsVenueFull()
        {
            return Seats == Visitors.Count;
        }
    }
}
