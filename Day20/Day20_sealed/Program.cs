using System;

namespace Day20_sealed
{
    //sealed class:
    //if you don't want other classes to inherit from a class, use sealed
    sealed class Human
    {

    }

    //because of sealed, this is not possible:
    //class Male : Human
    class Male //since the Male class can't inherit from Human, it remains without a parent class
    {
        
    }

    //sealed method (or just a class member):
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Printing virtual method");
        }
    }

    class DerivedClass : BaseClass
    {
        //Now the Print() method have been sealed and it can't be overridden
        public override sealed void Print()
        {
            Console.WriteLine("Printing sealed method");
        }
    }

    class ThirdClass : DerivedClass
    {
        //This cannot happend because of the sealed keyword
        //public override void Print()
        //{
        //    Console.WriteLine("Printing sealed method");
        //}
    }

    class FourthClass : BaseClass
    {
        //This can happen:
        public override void Print() //This overrides the BaseClass Print() method
        {
            Console.WriteLine("Printing overriden method in fourth class");
        }
        public string FourthProperty { get; set; } //this is just for FourthClass
    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass(); bc.Print();
            BaseClass bc2 = new DerivedClass(); bc2.Print();
            BaseClass bc3 = new FourthClass(); bc3.Print();
        }
    }
}
