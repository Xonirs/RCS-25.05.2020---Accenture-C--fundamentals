using System;

namespace Day17_OOP_Closet
{
    class Program
    {
        //In Program.Main method create Closet object and fill the closet with some Clothes. 
        //For each closet addition, print status you get from AddClothes method. At the and use method PrintClosetContent().
        static void Main(string[] args)
        {
            Closet closet = new Closet();
            Console.WriteLine(closet.AddClothes("skirt"));
            string clothesAddingMessage = closet.AddClothes("skirt");
            Console.WriteLine(clothesAddingMessage);
            Console.WriteLine(closet.AddClothes("hat"));
            Console.WriteLine(closet.AddClothes("shirt"));
            Console.WriteLine(closet.AddClothes("shirt"));
            Console.WriteLine(closet.AddClothes("trousers"));
            Console.WriteLine(closet.AddClothes("blouse"));
            closet.PrintClosetContent();
        }
    }
}
