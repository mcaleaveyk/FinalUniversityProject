using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    public class UserFavourite
    {
        //Foreign key
        public int UserId { get; set; }
        //Foreign Key
        public int ItemId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Relationships
        public User User { get; set; }
        public Item Item { get; set; }
    }
}
