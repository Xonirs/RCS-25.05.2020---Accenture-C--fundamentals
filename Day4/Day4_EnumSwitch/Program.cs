using System;

namespace Day4_EnumSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 60;
            switch (age)
            {
                case 18:
                    Console.WriteLine("You are now allowed to drink alcohol");
                    break;
                case 40:
                    Console.WriteLine("You are now allowed to become a president");
                    break;
                case 60:
                    Console.WriteLine("You are now allowed to become a pope");
                    break;
                case 100:
                    Console.WriteLine("You are a LEGEND!");
                    break;
                default:
                    break;
            }

            string carName = "MiniCooper";
            switch (carName)
            {
                case "Audi":
                    Console.WriteLine("Thanks for supporting the great Audi!");
                    break;
                case "BMW":
                    Console.WriteLine("BMW is fast!");
                    break;
                case "VW":
                    Console.WriteLine("VW is made in Germany");
                    break;
                case "Skoda":
                    Console.WriteLine("This car is very cute!");
                    break;
                default:
                    Console.WriteLine($"We don't have information about this '{carName}' car");
                    break;
            }
        }
    }
}
