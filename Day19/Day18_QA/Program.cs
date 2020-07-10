using System;

namespace Day18_QA
{
    class Owner
    {
        public string Name;
    }

    class Piano
    {
        public int Age;
        public Owner CurrentOwner;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string text = "Tom is walking";
            Piano grandPiano = null; //nothing
            try
            {
                Console.WriteLine(grandPiano.Age);
            }
            catch (Exception)
            {
                Console.WriteLine("There was a problem with the piano object");
            }

            Piano smallPiano = new Piano();
            smallPiano.Age = 5;
            Console.WriteLine(smallPiano.Age);
            Owner owner = new Owner();
            owner.Name = "Bobby";
            smallPiano.CurrentOwner = owner;
            Console.WriteLine(smallPiano.CurrentOwner.Name);
        }
    }
}
