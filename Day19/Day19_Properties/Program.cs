using System;

namespace Day19_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Tom";
            person.Name = "";

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Name);

            person.Surname = "Bush";
            person.Surname = "Nomad";
            Console.WriteLine(person.Surname);

            //person.Age = 18; //we can't set a read-only property
            Console.WriteLine(person.Age);
            Console.WriteLine("Person 2 begins");
            Person person2 = new Person(18);
            Console.WriteLine(person2.Age);
            Console.WriteLine(person2.PianoExp);

            person2.ScaredOfSpider = true;
            person2.ScaredOfSpider = false;
            person2.ScaredOfSpider = true;
            //we can't do this to a write-only prop
            //Console.WriteLine(person2.ScaredOfSpider);

            Console.WriteLine("Person 3 begins");
            Person person3 = new Person("Mary");
            Console.WriteLine(person3.MothersName);
            //person3.MothersName = ""; //we can't do this

        }
    }
}
