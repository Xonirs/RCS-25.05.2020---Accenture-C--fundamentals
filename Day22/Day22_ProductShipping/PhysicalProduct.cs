using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_ProductShipping
{
    class PhysicalProduct : IProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; set; }

        public void ShipItem(Customer customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName } in { customer.City }");
                //actual shipping code can be added here
                //....
                HasOrderBeenCompleted = true;
            }
        }
    }
}
/*
 * 
 * Create 2 classes - PhysicalProduct, DigitalProduct, which both implement interface IProduct.
PhysicalProduct.ShipItem will check if the product has not been yet completed and if so, then will print message "$"Simulating shipping { Title } to { customer.FirstName } in { customer.City }" and set HasOrderBeenCompleted to done.

 */
