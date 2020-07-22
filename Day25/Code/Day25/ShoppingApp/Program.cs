using ShoppingApp.Models.DB;
using System;

namespace ShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using - helps us to initiate an object, an afterwards makes sure of Disposing of it
            using (ShoppingContext dbContext = new ShoppingContext())
            {
                var shoppingItems = dbContext.ShoppingItems;

                foreach (var item in shoppingItems)
                {
                    Console.WriteLine($"Shopping item: Id:{item.Id} Description:{item.Description}, AvailableAmount:{item.AvailableAmount}," +
                        $"UseBefore:{item.UseBefore}, Price:{item.Price}");
                }
            }
        }
    }
}

/*
int number = 19;
number = -21758695;
number = 21758695;


var classInstance = new Program();
classInstance = new Program();
classInstance = null;

//number = null; //this can't be done

int? nullableNumber;
nullableNumber = 19;
nullableNumber = number - 5;
nullableNumber = 43535435;
nullableNumber = null; //this is possible
 */
