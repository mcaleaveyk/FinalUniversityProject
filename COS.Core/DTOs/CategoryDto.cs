using System.Collections.Generic;

namespace COS.Core.DTOs
{
    public class CategoryDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ItemDto> Items { get; set; } = new List<ItemDto>();

    }
}