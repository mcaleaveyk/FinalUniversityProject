using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    public class Category
    {
        public Category()
        {
           Items = new List<Item>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation property
        [JsonIgnore] public ICollection<Item> Items { get; set; } 
    }
}
