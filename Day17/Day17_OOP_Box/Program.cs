using System;

namespace Day17_OOP_Box
{
    class Program
    {
        //In Program.Main method create Box object, 
        //fill all the fields and add multiple Items to the Box.
        //Then use method PrintBoxInfo() and print the value 
        //which is returned from method GetBoxVolume().
        static void Main(string[] args)
        {
            Box box = new Box()
            {
                Id = "XY001",
                Width = 10,
                Height = 60,
                Length = 54,
                Weight = 44
            };
            box.Items.Add("pencil");
            box.Items.Add("phone");
            box.Items.Add("book");

            box.PrintBoxInfo();
            Console.WriteLine($"Box volume is {box.GetBoxVolume()}");
        }
    }
}
