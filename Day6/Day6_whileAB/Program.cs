using System;

namespace Day6_whileAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program where the user enters two numbers A and B. 
            Console.Write("Please enter A: ");
            string aInput = Console.ReadLine();
            int A = int.Parse(aInput);

            Console.Write("Please enter B: ");
            string bInput = Console.ReadLine();
            int B = int.Parse(bInput);

            //Output all the numbers between A and B
            //A = 5, B = 10, Output: 5,6,7,8,9,10
            //A = 10, B = 5, Output: 10,9,8,7,6,5

            if (A < B)
            {
                //When A is smaller than B
                while (A <= B)
                {
                    Console.WriteLine(A);
                    A++;
                } 
            }
            else if (A > B)
            {
                //When B is smaller than A
                while (A >= B)
                {
                    Console.WriteLine(A);
                    A--;
                } 
            }
            else
            {
                //When A is equal to B
                Console.WriteLine("There are no numbers between A and B since they are EQUAL!");
            }
        }
    }
}
