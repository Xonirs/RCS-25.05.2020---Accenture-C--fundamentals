using System;

namespace Day11_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Some value";
            string b = "another value";
            string c;
            c = a + b;
            
            string value = "not stop";
            bool doWeStop = value == "stop";
            while (!doWeStop)
            {
                value = Console.ReadLine();
                doWeStop = value == "stop";
            }
        }
    }
}
