using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_While
{
    class NumberActions
    {
        public void Numbers()
        {
            int number = 10; //10
            number = 20; //20
            number = number + 5; // 20 + 5 = 25

            number += 7; // number = number + 7; // 25 + 7 = 32
            number -= 6; // 32 - 6 = 26
            number *= 2; // 26 * 2 = 52
            Console.WriteLine(number);

            number++; //number = number + 1;           
            number--; //number = number - 1;

            //CAN'T DO THIS:
            //number++++++++;
            //number-----;
        }
    }
}
