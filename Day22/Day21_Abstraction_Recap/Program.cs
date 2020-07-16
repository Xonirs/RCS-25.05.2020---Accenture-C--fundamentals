using System;

namespace Day21_Abstraction_Recap
{
    abstract class Vehicle
    {
        public bool HasFuel { get; set; }
        public string Color { get; set; }
        public void GoForward() 
        {
            if (HasFuel == false) //!HasFuel
            {
                FillFuel();
            }
            Console.WriteLine("Vehicle is moving forward"); 
        }
        public abstract void FillFuel();
    }
    class Car : Vehicle
    {
        public bool HasChildrenSeats { get; set; }
        public override void FillFuel() { Console.WriteLine("Simulation car fuel filling"); }
    }
    class Boat : Vehicle
    {
        public bool SailIsSet { get; set; }
        public override void FillFuel() { Console.WriteLine("Simulation boat fuel filling"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); car.Color = "black"; car.GoForward();
            Boat boat = new Boat(); boat.Color = "red"; boat.GoForward();
            car.HasChildrenSeats = true;
            boat.SailIsSet = false;
            car.HasFuel = true;
            Console.WriteLine(); car.GoForward(); 
        }
    }
}
