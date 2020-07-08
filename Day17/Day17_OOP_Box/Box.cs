using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_OOP_Box
{
    //Create a class Box. Add public fields – Id, Height, Width, Length, Weight, Items.
    //Choose appropriate data types for all of them. Field Items is a list of strings of the items 
    //inside the box.Create a public method – void PrintBoxInfo(), which will print information about 
    //all of the fields and will list all of the items.Create a public method – int GetBoxVolume(), 
    //which will calculate volume for the box(volume is calculated by multiplying all of the measurements). 
    class Box
    {
        public string Id;
        public int Height;
        public int Width;
        public int Length;
        public int Weight;
        public List<string> Items = new List<string>();

        public void PrintBoxInfo()
        {
            Console.WriteLine("Box info:");
            Console.WriteLine($"Id:{Id},Height:{Height},Width:{Width},Length:{Length},Weight:{Weight}");
            if (Items.Count > 0)
            {
                Console.WriteLine("Box items:");
                foreach (var item in Items)
                {
                    Console.WriteLine(item);
                }
            }
        }
        
        public int GetBoxVolume()
        {
            return Height * Width * Length;
        }
    }
}
