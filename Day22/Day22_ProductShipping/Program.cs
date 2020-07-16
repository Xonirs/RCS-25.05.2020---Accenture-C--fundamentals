using System;
using System.Collections.Generic;

namespace Day22_ProductShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = GetCustomer();
            List<IProduct> shoppingCart = GetSampleList();

            foreach (IProduct product in shoppingCart)
            {
                product.ShipItem(customer);

                //this code will execute if the current product in shoppingCart is of type IDigitalProduct
                if (product is IDigitalProduct)
                {
                    //creating a variable by changing product to digital product
                    IDigitalProduct digitalProduct = (IDigitalProduct)product;
                    Console.WriteLine($"For the {digitalProduct.Title} there are {digitalProduct.TotalDownloadsLeft} downloads left.");
                }
            }
        }

        private static List<IProduct> GetSampleList()
        {
            List<IProduct> result = new List<IProduct>();

            result.Add(new PhysicalProduct() { Title = "iPhone 11 Pro" });
            result.Add(new PhysicalProduct() { Title = "Mega chair" });
            result.Add(new DigitalProduct() { Title = "Netflix gift card" });
            result.Add(new DigitalProduct() { Title = "C# Course source code by Jānis Lācis" });

            return result;
        }

        private static Customer GetCustomer()
        {
            return new Customer()
            {
                FirstName = "Janis",
                LastName = "Lacis",
                City = "Riga",
                EmailAddress = "janis@lacis.lv",
                PhoneNumber = "+371 29293838",
                StreetAddress = "Main street 1 - 10"
            };
        }
    }
}

/*
 Create a class Customer which has properties City, EmailAddress, FirstName, LastName, PhoneNumber, StreetAddress.
Create an interface IProduct which has these features:
property Title,
property HasOrderBeenCompleted,
a method ShipItem which does not return anything and takes Customer as a parameter.
Create 2 classes - PhysicalProduct, DigitalProduct, which both implement interface IProduct.
PhysicalProduct.ShipItem will check if the product has not been yet completed and if so, then will print message "$"Simulating shipping { Title } to { customer.FirstName } in { customer.City }" and set HasOrderBeenCompleted to done.
DigitalProduct.ShipItem will check if the product has not been yet completed and if so, then will print message "$"Simulating emailing { Title } to { customer.EmailAddress }" and set HasOrderBeenCompleted to done.

In Program.Main create a Customer object, fill values. Create a List of IProduct. 
Create 2 Physical products and 2 Digital products, add them to the list. After that create a loop which will go through 
all of the products (inside the list) and tries to ship every item to the customer.
*/
