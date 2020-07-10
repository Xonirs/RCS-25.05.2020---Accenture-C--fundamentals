using System;
using System.Collections.Generic;
using System.Linq;

namespace Day19_Mom
{
    class Program
    {

//Create 2 classes – Mom, Child.Child has properties – Name, Age, HairColor.Create an enum for HairColor.Mom has properties – Name, Children.Children is a public List<Child>.
//In Program.Main create new Mom object. Create multiple Child objects and add to the list of Mom.Children.Using LINQ:
//1.	Get all the children above age 5.
//2.	Get all the children with brown hair color
//3.	Get the first children in the list with the name “Bob”
//4.	Get all the children whose name Contains letter “e”
//After each usage of LINQ, print the results.
        static void Main(string[] args)
        {
            Mom mom = new Mom();
            mom.Name = "Ann";
            mom.Children.Add(new Child() { Name = "Tommy", Age = 21, HairColor = HairColor.Brown });
            mom.Children.Add(new Child() { Name = "Bobby", Age = 12, HairColor = HairColor.Gray });
            mom.Children.Add(new Child() { Name = "George", Age = 4, HairColor = HairColor.Blonde });
            mom.Children.Add(new Child() { Name = "Alice", Age = 2, HairColor = HairColor.Blonde });
            mom.Children.Add(new Child() { Name = "Herox", Age = 37, HairColor = HairColor.Brown });
            mom.Children.Add(new Child() { Name = "Bob", Age = 25, HairColor = HairColor.Brown });

            var oldChildren = mom.Children.Where(children => children.Age > 5);
            Console.WriteLine("Old children:");
            foreach (var child in oldChildren)
            {
                Console.WriteLine(child.Name);
            }

            var brownHairedChildren = mom.Children.Where(children => children.HairColor == HairColor.Brown);
            Console.WriteLine("Brown haired children:");
            foreach (var child in brownHairedChildren)
            {
                Console.WriteLine(child.Name);
            }

            Child bobChild = mom.Children.FirstOrDefault(c => c.Name == "Bob");
            if (bobChild == null)
            {
                Console.WriteLine("Mom has no children with name of Bob");
            }
            else
            {
                Console.WriteLine("Yes, there is a Bob");
            }

            var eChildren = mom.Children.Where(children => children.Name.Contains("e"));
            Console.WriteLine("e-children:");
            foreach (var child in eChildren)
            {
                Console.WriteLine(child.Name);
            }

        }
    }
}
