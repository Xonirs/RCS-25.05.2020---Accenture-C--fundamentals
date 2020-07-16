using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_ProductShipping
{
    class DigitalProduct : IDigitalProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; set; }
        public int TotalDownloadsLeft { get; set; } = 5;

        public void ShipItem(Customer customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
/*
 * Create 2 classes - PhysicalProduct, DigitalProduct, which both implement interface IProduct.
DigitalProduct.ShipItem will check if the product has not been yet completed and if so, then will print message "$"Simulating emailing { Title } to { customer.EmailAddress }" and set HasOrderBeenCompleted to done.

 */
