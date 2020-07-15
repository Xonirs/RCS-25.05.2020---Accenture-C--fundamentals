using System;

namespace Day21_Abstraction_Animal
{
    //abstract class - a restricted class that cannot be used to create objects. to use it, you must inherit from it.
    abstract class Animal
    {
        //abstract method - can only be used in an abstract class. it does not have a body, just a method signature.
        //                  The method body MUST be provided by the derived class.
        public abstract void AnimalSound();
        public void Sleep() 
        { 
            Console.WriteLine("Zzz"); 
        }
        public void ExecuteDay()
        {
            Sleep();
            Console.WriteLine("Animal is waking up");
            for (int i = 0; i < 3; i++)
            {
                AnimalSound();
            }
            Sleep();
        }
        public string Name { get; set; }
    }

    class Dog : Animal
    {
        public void SniffPeople() 
        { 
            Console.WriteLine("Sniffing people right now!!"); 
        }
        //since AnimalSound() is abstract in base class, we MUST override it and provide implementation
        public override void AnimalSound() 
        { 
            Console.WriteLine("WOOF-WOOF!"); 
        }
    }

    class Cat : Animal
    {
        public void ScratchPeople() 
        { 
            Console.WriteLine("Scratching people right now!!"); 
        }
        public override void AnimalSound() 
        { 
            Console.WriteLine("MEOW-MEOW!"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string temporaryText = "Blah blah blah";
            int tempNumber = 133;
            Dog dog = new Dog();
            dog.Name = "Fluffy";
            dog.AnimalSound();
            Cat cat = new Cat();
            cat.Name = "Buffy";
            cat.AnimalSound();
            Console.WriteLine(); 
            DoAnimalStuff(dog); 
            DoAnimalStuff(cat);
            Console.WriteLine(); 
            cat.Sleep(); 
            dog.Sleep();
            Console.WriteLine(); 
            dog.ExecuteDay();
        }

        static void DoAnimalStuff(Animal animal)
        {
            animal.AnimalSound();
            animal.Sleep();
        }
    }
}
