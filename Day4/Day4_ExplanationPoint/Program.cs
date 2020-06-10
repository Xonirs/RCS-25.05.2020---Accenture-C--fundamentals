using System;

namespace Day4_ExplanationPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //! - exclamation mark changes the bool value to the opposite.
            //You can read "!" as 'NOT'
            //Examples:
            //!true -> false
            //!false -> true
            
            bool sunny = false;
            if (sunny)
            {
                //do stuff, if it is sunny
                Console.WriteLine("IS SUNNY");
            }

            //We want to check only if NOT sunny
            if (!sunny) //if NOT sunny
            {
                //do stuff, if it is sunny
                Console.WriteLine("IS NOT SUNNY");
            }

            //EXAMPLE OF USAGE
            //We want to have a program which will tell us which numbers are written incorrectly
            Console.WriteLine("Enter your exam point count:");
            string pointsInput = Console.ReadLine();
            int points;
            bool parseSuccessful = int.TryParse(pointsInput, out points);
            if (!parseSuccessful) //if the parse was NOT successful
            {
                Console.WriteLine($"Your input '{pointsInput}' is not a number");
            }
        }
    }
}
