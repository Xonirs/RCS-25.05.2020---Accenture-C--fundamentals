using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_ProductShipping
{
    interface IProduct
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; set; }
        void ShipItem(Customer customer);
    }
}

/*
 Create an interface IProduct which has these features:
property Title,
property HasOrderBeenCompleted,
a method ShipItem which does not return anything and takes Customer as a parameter.
 */
