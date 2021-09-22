using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    public class OrderItem
    {
        //foreign key
        public int OrderId { get; set; }
        //foreign key
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }
        public int Quantity { get; set; }
        public Size? Size { get; set; }

        //relationships
        [JsonIgnore]public Order Order { get; set; }
        [JsonIgnore]public Item Item { get; set; }

    }
}
