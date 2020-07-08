using System;

namespace Day17_OOP_Refrigerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Refrigerator. Add public fields – Name, Height, Weight, Manufacturer, Year. 
            //Choose appropriate data types for all of them. Create 2 constructors for this class – one without parameters and 
            //one with some (or all) of them. Create a public method – void PrintRefrigeratorInfo(), 
            //which will print all the information known about the fridge. In Program.Main method create at least 2 objects 
            //of class Refrigerator. Use both constructors while creating objects. Fill the values for fields and 
            //use method PrintRefrigeratorInfo().
            Refrigerator ref1 = new Refrigerator();
            ref1.Height = 10.5;
            ref1.Weight = 88;
            ref1.Name = "Main kitchen refrigerator";
            ref1.Manufacturer = "Samsung";

            Refrigerator ref2 = new Refrigerator("Small basement fridge", 7.9, 52);

            ref1.PrintRefrigeratorInfo();
            ref2.PrintRefrigeratorInfo();
        }
    }
}
