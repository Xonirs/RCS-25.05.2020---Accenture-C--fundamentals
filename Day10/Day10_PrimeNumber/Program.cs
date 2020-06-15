using System;

namespace Day10_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs a number N. Find the biggest prime number from 1 to N.
            //Prime number - a number greater than 1 and which divides with a remainder of zero only with 1 and 
            //itself. 
            //Prime numbers : 2,3,5,7,11,13,17, etc.
            Console.Write("Input a number: ");
            int N = int.Parse(Console.ReadLine());
            var biggestPrime = 0;

            //going through all of the numbers from 2..N
            for (int i = 2; i <= N; i++)
            {
                //a variable for checking whether i is a prime
                bool isPrimeNumber = true;

                //we have a number i,
                //we have to check whether i is a prime number
                for (int j = 2; j < i - 1; j++) //going through all of the numbers from 2..(i-1)
                {
                    //Checking if i can be divided by j, therefore remainder is 0
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                    }
                }

                //if i is a prime number
                if (isPrimeNumber)
                {
                    //Then i is now our biggest prime number
                    biggestPrime = i;
                }
            }

            Console.WriteLine($"Biggest prime number until {N} is {biggestPrime}");
        }
    }
}
