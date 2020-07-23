using CompanyInventoryApp.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyInventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void DeleteData()
        {
            using (CompanyInventoryContext context = new CompanyInventoryContext())
            {
                var tabletsItem = context.InventoryItems.FirstOrDefault(item => item.Id == 13);
                context.InventoryItems.Remove(tabletsItem);
                context.SaveChanges();
                Console.WriteLine("We have deleted the tablets item!");
            }
        }

        private static void UpdateData()
        {
            using (CompanyInventoryContext context = new CompanyInventoryContext())
            {
                var tvItem = context.InventoryItems.FirstOrDefault(item => item.Description == "TV");
                if (tvItem != null)
                {
                    //We have found TV record in table, let's add it's quantity
                    tvItem.Quantity += 1000;
                    context.SaveChanges();
                    Console.WriteLine("Context SaveChanges for TV item completed!");
                }

                //We are going to updated all of the items without color to white colore
                var nonColorItems = context.InventoryItems.Where(x => x.Color == null);
                foreach (var item in nonColorItems)
                {
                    item.Color = "white";
                }
                context.SaveChanges();
                Console.WriteLine("All non colored items are updated!");
            }
        }

        private static void InsertData()
        {
            var newItem = new InventoryItems();
            Console.WriteLine("Please input some values for a new inventory item:");
            Console.Write("Id: ");
            newItem.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Description: ");
            newItem.Description = Console.ReadLine();
            Console.Write("Quantity: ");
            newItem.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Color: ");
            newItem.Color = Console.ReadLine();

            using (CompanyInventoryContext context = new CompanyInventoryContext())
            {
                Console.WriteLine("Saving new item to DB!");
                context.InventoryItems.Add(newItem);
                context.SaveChanges();

                var newItemFound = context.InventoryItems.First(x => x.Id == newItem.Id);
                Console.WriteLine("Newly created InventoryItem was found");
                newItemFound.PrintInfo();
            }
        }

        static void SelectData()
        {
            using (CompanyInventoryContext dbContext = new CompanyInventoryContext())
            {
                var inventoryItems = dbContext.InventoryItems;

                Console.WriteLine("All items:");
                foreach (var item in inventoryItems)
                {
                    item.PrintInfo();
                }
                Console.WriteLine();

                var blackItems = dbContext.InventoryItems.Where(item => item.Color == "black");
                Console.WriteLine("Black colored items:");
                foreach (var item in blackItems)
                {
                    item.PrintInfo();
                }
                Console.WriteLine();

                var blackItems2 = dbContext.InventoryItems.Where(item => item.Color == "black");
                blackItems2 = blackItems2.Where(item => item.Quantity > 10);
                Console.WriteLine("Black colored items with quantity above 10:");
                foreach (var item in blackItems2)
                {
                    item.PrintInfo();
                }
                Console.WriteLine();

                var blackItems3 = dbContext.InventoryItems.Where(item => item.Color == "black" && item.Quantity > 10);
                Console.WriteLine("Black colored items with quantity above 10, v2:");
                foreach (var item in blackItems3)
                {
                    item.PrintInfo();
                }
                Console.WriteLine();

                var colors = new List<string>() { "red", "yellow" };
                var multipleColorItems = dbContext.InventoryItems.Where(item => colors.Contains(item.Color));
                Console.WriteLine("Items in red or yellow color:");
                foreach (var item in multipleColorItems)
                {
                    item.PrintInfo();
                }
                Console.WriteLine();

                var searchId = 3;
                var singleItem = dbContext.InventoryItems.Where(item => item.Id == searchId).FirstOrDefault();
                //same thing in practice
                //var singleItem = dbContext.InventoryItems.FirstOrDefault(item => item.Id == searchId);
                if (singleItem != null)
                {
                    Console.WriteLine($"Item with id {searchId} was found:");
                    singleItem.PrintInfo();
                }
                else
                {
                    Console.WriteLine($"Item with id {searchId} was not found!");
                }
            }
        }
    }
}
