using System;

namespace Day17_OOP_Human
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Human. Add public fields – Name, Height, Gender, RelativeCount, HasChildren. 
            //Choose appropriate data types for all of them. In Program.Main method, create multiple Human objects and 
            //fill all the fields with values.
            Human human1 = new Human();
            human1.Name = "Bob";
            human1.Height = 1.80;
            human1.Gender = "male";
            human1.RelativeCount = 5;
            human1.HasChildren = false;

            Human human2 = new Human()
            {
                Name = "Ann",
                Gender = "female",
                HasChildren = true,
                Height = 1.65,
                RelativeCount = 10
            };
        }
    }
}
