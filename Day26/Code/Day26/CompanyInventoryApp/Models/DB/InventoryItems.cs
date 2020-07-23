using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyInventoryApp.Models.DB
{
    public partial class InventoryItems
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string Color { get; set; }

        public void PrintInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Inventory item info: ");
            builder.Append($"Id:{Id},");
            builder.Append($"Description:{Description},");

            if (Quantity == null)
            {
                builder.Append($"Quantity:NO_VALUE,");
            }
            else
            {
                builder.Append($"Quantity:{Quantity},");
            }

            if (string.IsNullOrEmpty(Color))
            {
                builder.Append($"Color:NO_VALUE.");
            }
            else
            {
                builder.Append($"Color:{Color}.");
            }

            var result = builder.ToString();
            Console.WriteLine(result);
        }
    }
}
