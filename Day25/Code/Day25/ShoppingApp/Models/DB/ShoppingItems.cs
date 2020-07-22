using System;
using System.Collections.Generic;

namespace ShoppingApp.Models.DB
{
    public partial class ShoppingItems
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? UseBefore { get; set; }
        public int? AvailableAmount { get; set; }
        public decimal? Price { get; set; }
    }
}
