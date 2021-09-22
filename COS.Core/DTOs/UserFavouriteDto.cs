using System.Collections.Generic;
namespace COS.Core.DTOs
{
    public class UserFavouriteDto {        
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }

    }
}