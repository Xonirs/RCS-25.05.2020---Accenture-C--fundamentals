using System;

namespace Day3_IfUsage3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle driver has exceeded the allowed speed by x km/h (user inputs this). 
            //In case the speed exceeds by more than 10, then the penalty 15 eur, 
            //if by more than 20, then the penalty is 30, and if by more than 30, 
            //then the drivers license is lost.

            Console.WriteLine("How much the speed was exceeded?");
            string speedInput = Console.ReadLine();
            int speed = int.Parse(speedInput);

            if (speed > 10 && speed <= 20)
            {
                Console.WriteLine("15 eur penalty");
            }
            else if (speed > 20 && speed <= 30)
            {
                Console.WriteLine("30 eur penalty");
            }
            else if (speed > 30)
            {
                Console.WriteLine("LICENSE IS LOST");
            }
        }
    }
}
