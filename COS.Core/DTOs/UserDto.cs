using System.Collections.Generic;

namespace COS.Core.DTOs
{
    public class UserDto {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // convert role to int
        public int Role { get; set; }
        public string Token { get; set; }
        public IList<UserFavouriteDto> FavItems { get; set; } = new List<UserFavouriteDto>();
        public IList<OrderDto> Orders { get; set; } = new List<OrderDto>();
    }   
}