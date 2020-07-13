using System;

namespace Day20_Polymorphism
{
    //Polymorphism - "many forms". it allows us to perform a single action in different ways
    //virtual - this allows for the member to be overriden in a derived class
    //override - this allows to modify the original implementation from inherited method
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    class Rooster : Animal
    {
        public int ChickFriends { get; set; }
        public override void AnimalSound() //this methods provides a new implemenation of a member which is inherited from base class
        {
            Console.WriteLine("COCK-A-DOODLE-DOO");
        }
    }
    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("WoofWoofWoof");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); animal.AnimalSound();
            Animal rooster = new Rooster(); rooster.AnimalSound();
            Rooster roosterMain = new Rooster(); roosterMain.AnimalSound();
            Animal dog = new Dog(); dog.AnimalSound();
        }
    }
}
