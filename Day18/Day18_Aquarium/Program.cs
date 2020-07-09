using System;
using System.Collections.Generic;
using System.Linq;

namespace Day18_Aquarium
{
    class Program
    {
        /*
         *Create a class Aquarium. Create a public field – List<string> Fish. In Program.Main create Aquarium object and fill it with multiple fish. Using LINQ try to find:
        1.	All the fish where the fish name is longer than 5 letters by using Where() + Length.
        a.	Then print all the found fish
        2.	A single fish by using First() + Contains (must be an existing fish).
        a.	Then print the found fish
        3.	A single fish by using FirstOrDefault() + Contains (must be an existing fish).
        a.	Check if the fish is found
        b.	If the fish is found, print it
        4.	A single fish by using FirstOrDefault() + Contains (must be a non-existing fish).
        a.	Check if the fish is found
        b.	If the fish is found, print it
        c.	If the fish is not found, print $“Fish not found with search value {searchValue}”. 
         */
        static void Main(string[] args)
        {
            Aquarium aquarium = new Aquarium();
            aquarium.Fish.Add("shark");
            aquarium.Fish.Add("pike");
            aquarium.Fish.Add("salmon");
            aquarium.Fish.Add("tune");
            aquarium.Fish.Add("cod");
            aquarium.Fish.Add("swordfish");
            aquarium.Fish.Add("catfish");

            List<string> longNamedFish = aquarium.Fish.Where(fish => fish.Length > 5).ToList();
            Console.WriteLine("Fish with long names:");
            foreach (var fish in longNamedFish)
            {
                Console.WriteLine(fish);
            }
            Console.WriteLine();

            string fish2 = aquarium.Fish.First(fish => fish.Contains("r"));
            Console.WriteLine(fish2);

            string fish3 = aquarium.Fish.FirstOrDefault(fish => fish.Contains("o"));
            if (!string.IsNullOrEmpty(fish3))
            {
                Console.WriteLine(fish3); 
            }
            else
            {
                Console.WriteLine("There are no fish with 'o'");
            }

            string searchValue = "bbb";
            string fish4 = aquarium.Fish.FirstOrDefault(fish => fish.Contains(searchValue));
            if (!string.IsNullOrEmpty(fish4))
            {
                Console.WriteLine(fish4);
            }
            else
            {
                Console.WriteLine($"There are no fish with '{searchValue}'");
            }
        }
    }
}
