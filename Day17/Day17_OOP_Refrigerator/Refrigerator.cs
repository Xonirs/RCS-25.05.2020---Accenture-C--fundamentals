using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_OOP_Refrigerator
{
    class Refrigerator
    {
        public string Name;
        public double Height;
        public double Weight;
        public string Manufacturer;
        public int Year;

        public Refrigerator()
        {
            Year = 2020;
            Manufacturer = "LG";
        }

        public Refrigerator(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;

            Year = 2020;
            Manufacturer = "LG";
        }

        public void PrintRefrigeratorInfo()
        {
            Console.WriteLine($"Name:{Name}, Height:{Height}, Weight:{Weight},");
            Console.WriteLine($"Manufacturer:{Manufacturer}, Year:{Year}");
        }
    }
}
