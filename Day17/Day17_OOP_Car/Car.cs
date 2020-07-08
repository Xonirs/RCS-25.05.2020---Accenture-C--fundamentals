using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_OOP_Car
{
    class Car
    {
        private int hornPressedCount = 0;
        public void PressHorn()
        {
            Console.WriteLine("Honk honk");
            hornPressedCount++;
        }

        public string GetHornCount()
        {
            return $"Car horn was pressed { hornPressedCount}";
        }
    }
}
