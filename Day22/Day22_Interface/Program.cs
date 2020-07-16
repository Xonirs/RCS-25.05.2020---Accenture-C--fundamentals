using System;
using System.Collections.Generic;

namespace Day22_Interface
{
    //interface - is a completely "abstract class", meaning it only contains abstract members (methods, properties)
    //            is just a contract, just a list of features with no implemenations whatsoever
    //a class can inherit only a single other class (be it abstract or regular), 
    //but a class can inherit multiple interfaces

    //by default, all of the members for interface are abstract and public
    interface IAnimal
    {
        int LegCount { get; set; }
        void AnimalSound();
    }

    interface IBird
    {
        int WingCount { get; set; }
        void StartFlying();
    }

    class Pig : IAnimal
    {
        public int LegCount { get; set; }

        public void AnimalSound()
        {
            Console.WriteLine("The pig says OINK OINK");
        }
    }

    class Eagle : IAnimal, IBird
    {
        public int LegCount { get; set; }
        public int WingCount { get; set; }

        public void AnimalSound()
        {
            Console.WriteLine("The bird says tweet tweet");
        }

        public void StartFlying()
        {
            Console.WriteLine("The bird starts flying");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.LegCount = 4;
            pig.AnimalSound();
            Eagle eagle = new Eagle();
            eagle.LegCount = 2;
            eagle.WingCount = 2;
            eagle.AnimalSound();
            eagle.StartFlying();
            Console.WriteLine();

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(pig);
            animals.Add(eagle);
            foreach (IAnimal animal in animals)
            {
                animal.AnimalSound();
            }
        }
    }
}
