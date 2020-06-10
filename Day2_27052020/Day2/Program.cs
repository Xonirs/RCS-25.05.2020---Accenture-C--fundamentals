using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string surname = "Bear";
            string middleName = "Peter";
            string middleName2 = "Angus";
            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(middleName);
            Console.WriteLine(middleName2);
            Console.WriteLine();

            //1st way of string attaching
            // +
            string fullName1 = name + " " + surname;
            Console.WriteLine(fullName1); //writeline via variable
            Console.WriteLine(name + " " + surname); //writeline via plus sign 
            Console.WriteLine();

            //2nd way
            // string.Format
            string fullName21 = string.Format("{0} {1}", name, surname);
            Console.WriteLine(fullName21);
            string fullName22 = string.Format("FirstName:{0}, MiddleName: {2},LastName: {1}!", name, surname, middleName);
            Console.WriteLine(fullName22);
            Console.WriteLine(string.Format("{0} {2} {3} {1}", name, surname, middleName, middleName2)); 
            Console.WriteLine(string.Format("{0} {1} {2} {3}", name, surname, middleName, middleName2));
            Console.WriteLine();

            //3rd way
            // $
            string fullName3 = $"!{name} {surname}.";
            Console.WriteLine(fullName3); 
            Console.WriteLine($"!{name} {surname}?"); 
            Console.WriteLine();
        }
    }
}
