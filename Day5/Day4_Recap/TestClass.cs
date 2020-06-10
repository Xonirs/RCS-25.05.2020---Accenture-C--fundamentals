using System;

namespace Day4_Recap
{
    class TestClass
    {
        static void TestMethod()
        {
            string familyRole = "mother";
            if (familyRole == "father")
            {
                Console.WriteLine("You are father! Your name is John");
            }
            else if (familyRole == "mother")
            {
                Console.WriteLine("You are mother! Your name is Ann");
            }
            else if (familyRole == "brother")
            {
                Console.WriteLine("You are brother! Your name is Peter");
            }
            else if (familyRole == "sister")
            {
                Console.WriteLine("You are sister! Your name is Maria");
            }
            else
            {
                Console.WriteLine("We don't know who you are!");
            }
        }
    }
}
