using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace COS.Core.Models
{
    public enum Role { Admin, Manager, Guest }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        [JsonIgnore]public ICollection<UserFavourite> UserFavourites { get; set; } = new List<UserFavourite>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    
        public override string ToString()
        {
            return $"Id:{Id} Name:{FirstName + LastName} Email:{Email} Favs: {UserFavourites.ToString()} ";
        }
    
    }
}
