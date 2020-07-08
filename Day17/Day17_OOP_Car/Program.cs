using System;

namespace Day17_OOP_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Car. Create a public method – void PressHorn(), which will print out a message to console “Honk honk”. 
            //Create a private field – hornPressedCount. Its initial value will be zero and 
            //it will increase each time method PressHorn is called. Create a public method – string GetHornCount(), 
            //which will return a message $“Car horn was pressed {hornPressedCount}”. 
            //In Program.Main method create a Car object. Call method PressHorn() couple of times and 
            //then print the message which is returned from method GetHornCount().
            Car bmw = new Car();
            bmw.PressHorn();
            bmw.PressHorn();
            bmw.PressHorn();
            bmw.PressHorn();
            bmw.PressHorn();
            
            //printing option nr.1
            Console.WriteLine(bmw.GetHornCount());
            
            //printing option nr.2
            string message = bmw.GetHornCount();
            Console.WriteLine(message);
        }
    }
}
