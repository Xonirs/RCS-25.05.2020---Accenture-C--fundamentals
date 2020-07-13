using System;

namespace Day19_recap
{
    //Derived class (child) - the class that inherits from another class 
    //Base class (parent) - the class being inherited from
    //to inherit - the child class will get all of the public members from the base class
    //IMPORTANT - in C# you can inherit only from a single class

    class Human
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public void SayHi(string name)
        {
            Console.WriteLine($"Hi, {name}, my name is {Name} {Surname}");
        }
    }

    class Adult : Human
    {
        public int Salary { get; set; }
        public void PrintSalary()
        {
            Console.WriteLine($"My monthly salary is {Salary}.");
        }
    }

    class Child : Human
    {
        public int MilkTeeth { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human()
            {
                Name = "Bob",
                Surname = "Tregush"
            };
            Adult adult = new Adult()
            {
                Name = "Bob", //derived from Human
                Surname = "Tregush", //derived from Human
                Salary = 600
            };
            Adult adult2 = new Adult()
            {
                Name = "Bob", //derived from Human
                Salary = 600
            };
            Child child = new Child()
            {
                Name = "Bob", //derived from Human
                Surname = "Tregush", //derived from Human
                MilkTeeth = 8
            };

            human.SayHi("Ann");
            adult.SayHi("Ann");
            adult2.SayHi("Ann");
            child.SayHi("Ann"); Console.WriteLine();
            adult.PrintSalary();
        }
    }
}
