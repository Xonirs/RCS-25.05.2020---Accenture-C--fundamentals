using System;

namespace Day16_OOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("Ann", "Cloth");
            house.Name = "Bath legend";
            house.Address = "Brivibas street 13";
            house.Rent = 500;
            Console.WriteLine(house.Name);
            house.Floors = 5;
            Console.WriteLine(house.Floors);
            house.Floors = -4;
            Console.WriteLine(house.Floors);

            //read-only
            //compile error, because property read-only
            //house.OwnersName = "Bob Baker";
            Console.WriteLine($"The owner of the house: {house.OwnersName} {house.OwnersSurname}");

            //write-only
            house.ElectricityAmount = 1000;
            //compile error, because property write-only
            //Console.WriteLine($"Electricity amount: {house.ElectricityAmount}");

            house.ShowInfo();
        }
    }
}
