using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_Park
{
    class Park
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Gardener MainGardener { get; set; }

        public void PrintParkInfo()
        {
            Console.WriteLine("Park info:");
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Address:{Address}");            
            Console.WriteLine($"Main Gardener Name:{MainGardener.Name}");
            Console.WriteLine($"Main Gardener Age:{MainGardener.Age}");
            Console.WriteLine($"Main Gardener Experience:{MainGardener.Experience}");
        }
    }
}
