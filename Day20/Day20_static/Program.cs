using System;

namespace Day20_static
{
    //static - static class members don't belong to a specific object but to the type (class) itself

    class Bird
    {
        public string WingType { get; set; }
        public static int WingCount { get; set; }
    }

    class Rabbit
    {
        public int CaveSize { get; set; }
        public static int RabbitCount { get; set; }
        public Rabbit()
        {
            RabbitCount++;
        }
        //inside a static method we can only work with other static class members
        public static void PrintRabbitCount()
        {
            Console.WriteLine($"Currently there are {RabbitCount} rabbits!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region bird
            Bird bird1 = new Bird();
            bird1.WingType = "curved";

            //this is not possible: 
            //bird1.WingCount = 0;

            //but this is:
            Bird.WingCount = 2;
            #endregion
            #region Rabbit
            Rabbit rabbit = new Rabbit();
            rabbit.CaveSize = 10;
            Console.WriteLine($"Rabbit count: {Rabbit.RabbitCount}");
            Rabbit rabbit2 = new Rabbit();
            rabbit2.CaveSize = 10;
            Console.WriteLine($"Rabbit count: {Rabbit.RabbitCount}");
            Rabbit rabbit3 = new Rabbit();
            Rabbit rabbit4 = new Rabbit();
            Rabbit rabbit5 = new Rabbit();
            Rabbit rabbit6 = new Rabbit();
            Rabbit rabbit7 = new Rabbit();
            Rabbit.PrintRabbitCount();
            #endregion
            Console.WriteLine("Test to the static console");
        }
    }
}
