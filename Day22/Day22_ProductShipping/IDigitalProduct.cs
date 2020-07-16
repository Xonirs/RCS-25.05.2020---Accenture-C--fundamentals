using System;
using System.Collections.Generic;
using System.Text;

namespace Day22_ProductShipping
{
    interface IDigitalProduct : IProduct
    {
        int TotalDownloadsLeft { get; set; }
    }
}
