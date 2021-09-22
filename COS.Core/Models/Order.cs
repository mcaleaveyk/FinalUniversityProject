using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        //Foreign key - order owner
        public int UserId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime DueFor { get; set; }
        public bool Takeaway { get; set; }
        public bool FoodReady { get; set; }
        public bool OrderFulfilled { get; set; }
        public bool Submitted { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }

        //navigation properties
        [JsonIgnore]public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        [JsonIgnore]public User User { get; set; }

    }
}
