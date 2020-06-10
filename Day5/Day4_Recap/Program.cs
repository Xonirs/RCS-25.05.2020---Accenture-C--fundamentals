using System;

namespace Day4_Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            //!
            //! - changes a bool value to the opposite
            //!true -> false
            //!false -> true

            bool sunny = false;
            if (sunny)
            {
                Console.WriteLine("There is some sun showing in the sky");
            }

            if (!sunny)
            {
                //do stuff when not sunny
                Console.WriteLine("Is it raining?");
            }

            //string familyRole = "mother";
            //switch (familyRole)
            //{
            //    case "father":
            //        Console.WriteLine("You are father! Your name is John");
            //        break;
            //    case "mother":
            //        Console.WriteLine("You are mother! Your name is Ann");
            //        break;
            //    case "brother":
            //        Console.WriteLine("You are brother! Your name is Peter");
            //        break;
            //    case "sister":
            //        Console.WriteLine("You are sister! Your name is Maria");
            //        break;
            //    default:
            //        Console.WriteLine("We don't know who you are!");
            //        break;
            //}
        }
    }
}
