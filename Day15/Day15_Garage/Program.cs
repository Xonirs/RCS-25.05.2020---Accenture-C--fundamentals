using System;

namespace Day15_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 32;
            person.Name = "John Bush";

            Garage garage = new Garage();
            garage.Name = "Old Vinyls";
            garage.Address = "1st street";
            garage.Owner = person;

            Garage garage2 = new Garage();
            garage2.Name = "New rims";
            garage2.Address = "33rd street";
            garage2.Owner = new Person()
            {
                Age = 44,
                Name = "Elisa Buckenfald"
            };

            Garage garage3 = new Garage()
            {
                Name = "Street gods",
                Address = "Valdemara streeet",
                Owner = person,
                MainCar = new Car()
                {
                    Manufacturer = "BMW",
                    Model = "M19",
                    Year = 2040,
                    Owner = garage2.Owner
                }
            };
        }
    }
}
