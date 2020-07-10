using System;

namespace Day19_Inheritance
{
    //Inheritance
    //it is possible to inhert fields/properties/methods/etc. from one class to another
    //Derived class (child) - this is the class that inherits
    //Base class (parent) - this is the class that is being inherited from

    class Computer //Base class (parent)
    {
        public int Memory { get; set; }
        public int DiskSpace { get; set; }
    }

    //in C#, at a single time, you can inherit from just 1 class at a time
    //but you can have multiple interfaces
    class Laptop : Computer //Derived class (child)
    {
        public bool HasTouchScreen { get; set; }
    }

    class Server : Computer //Derived class (child)
    {
        public int DailyUptime { get; set; }
    }

    class Tablet : Laptop //Derived class (child)
    {
        public string MobileOS { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.DiskSpace = 256;
            computer.Memory = 32;

            Laptop laptop = new Laptop();
            laptop.HasTouchScreen = true;
            laptop.Memory = 64; //this property is inherited from Computer class
            laptop.DiskSpace = 128; //this property is inherited from Computer class

            Server server = new Server();
            server.DailyUptime = 23;
            server.Memory = 64; //this property is inherited from Computer class
            server.DiskSpace = 128; //this property is inherited from Computer class

            Tablet tablet = new Tablet();
            tablet.HasTouchScreen = true; //this property is inherited from Laptop class
            tablet.Memory = 64; //this property is inherited from Computer class
            tablet.DiskSpace = 128; //this property is inherited from Computer class
            tablet.MobileOS = "iOS";
        }
    }
}
