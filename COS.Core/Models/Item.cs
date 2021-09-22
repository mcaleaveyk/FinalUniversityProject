using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    //Size to be removed per stakeholder requirements
    //temporary NoSize option
    public enum Size { Small, Medium, Large, NoSize }
    public class Item
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public Size? Size { get; set; } = null;

        //navigation properties
        [JsonIgnore]public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        [JsonIgnore]public ICollection<UserFavourite> UserFavourites { get; set; } = new List<UserFavourite>();
        public Category Category { get; set; }
    }
}
