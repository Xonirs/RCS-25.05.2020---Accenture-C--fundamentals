using System;

namespace Day22_Interface_recap
{
    //interface helps us achieve abstraction. we can describe something without implementation and later fill missing parts.
    interface IReprodcution
    {
        bool HasReproduced { get; set; }
    }
    interface ILivingThings : IReprodcution
    {
        bool NeedsAir { get; set; }
        bool HasDna { get; set; }
        int Age { get; set; }
        string Name { get; set; }
        void IncreaseAge();
    }
    interface IUnderWaterLivingThing
    {
        int SpeedUnderWater { get; set; }
    }
    class BaseReproduction : IReprodcution
    {
        public bool HasReproduced { get; set; }
        public virtual void StartReproducing()
        {
            HasReproduced = true;
            Console.WriteLine("Generic reproduction has started");
        }
    }
    class Octopus : BaseReproduction, ILivingThings, IUnderWaterLivingThing
    {
        public string Name { get; set; }
        public bool NeedsAir { get; set; }
        public bool HasDna { get; set; }
        public int Age { get; set; }
        public int SpeedUnderWater { get; set; }

        public void IncreaseAge()
        {
            Console.WriteLine("OctopusAgeIncreased");
            Age++;
            if (Age > 5)
            {
                Console.WriteLine("Octopus soon will die");
            }
        }
        public override void StartReproducing()
        {
            base.StartReproducing();
            Console.WriteLine("Spreading love to other octopuses");
        }
    }    
    class SunFlower : BaseReproduction, ILivingThings
    {
        public string Name { get; set; }
        public bool NeedsAir { get; set; }
        public bool HasDna { get; set; }
        public int Age { get; set; }

        public void IncreaseAge()
        {
            Console.WriteLine("SunflowerAgeIncreased");
            Age++;
            if (Age > 12)
            {
                Console.WriteLine("Sunflower soon will die");
            }
            else if (Age > 3)
            {
                Console.WriteLine("Sunflower has opened!");
            }
        }
        public override void StartReproducing()
        {
            base.StartReproducing();
            Console.WriteLine("Sunflower starts to shoot some seeds around");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Octopus octopus = new Octopus()
            {
                HasDna = true,
                NeedsAir = false,
                Name = "Octopus OctoBobby"
            };
            SunFlower sunflower = new SunFlower()
            {
                HasDna = false,
                NeedsAir = true,
                Name = "Sunflower Sunshine"
            };
            for (int i = 0; i < 8; i++)
            {
                octopus.IncreaseAge();
            }
            for (int i = 0; i < 14; i++)
            {
                sunflower.IncreaseAge();
            }
            PrintLivingThingInfo(octopus);
            PrintLivingThingInfo(sunflower);
            octopus.StartReproducing();
            sunflower.StartReproducing();
            PrintLivingThingInfo(octopus);
            PrintLivingThingInfo(sunflower);
        }
        static void PrintLivingThingInfo(ILivingThings livingThing)
        {
            Console.WriteLine($"{livingThing.Name}, age:{livingThing.Age}, hasReproduced:{livingThing.HasReproduced}, needsAir:{livingThing.NeedsAir}, hasDna:{livingThing.HasDna}");
        }
    }
}
