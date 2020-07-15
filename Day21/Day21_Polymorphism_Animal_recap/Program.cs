using System;

namespace Day21_Polymorphism_Animal_recap
{
    class Animal
    {
        public virtual void AnimalSound() { Console.WriteLine("This is generic animal sound."); }
    }

    class Dog : Animal
    {
        public void SniffPeople() { Console.WriteLine("Sniffing people right now!!"); }
        public override void AnimalSound() { Console.WriteLine("WOOF-WOOF!"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); animal.AnimalSound();
            Dog dog = new Dog(); dog.SniffPeople(); dog.AnimalSound();
            Animal dog2 = new Dog(); dog2.AnimalSound();
            Console.WriteLine();
            DoAnimalStuff(animal);
            DoAnimalStuff(dog);
            DoAnimalStuff(dog2);
        }
        static void DoAnimalStuff(Animal animal)
        {
            animal.AnimalSound();
            //animal.OtherMethod1();
            //animal.OtherMethod2();
            //animal.OtherMethod3();
        }
    }
}
