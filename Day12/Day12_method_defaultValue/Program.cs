using System;

namespace Day12_method_defaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting("John Apple");
            PrintGreeting();

            PrintGreeting("Howdy mate,", "Ann Perkins");
            PrintGreeting(greetingMessage:"Good afternoon,");

            PrintMyInfo("Bob");
            PrintMyInfo("Ann", "STRING VALUE");
            PrintMyInfo("Christopher", address: "Baker street");
            PrintMyInfo("John", "Bowl", "Washington street");
        }

        static void PrintGreeting(string name = "UNKNOWN USER")
        {
            Console.WriteLine($"Hello to {name}");
        }

        //The parameters with default values must be at the and of all parameters
        static void PrintGreeting(string greetingMessage, string name = "UNKNOWN USER")
        {
            Console.WriteLine($"{greetingMessage} {name}");
        }

        static void PrintMyInfo(string name, string surname = "SURNAME", string address = "NAMELESS STREET")
        {
            Console.WriteLine($"Name:{name}, Surname:{surname}, address:{address}");
        }
    }
}
