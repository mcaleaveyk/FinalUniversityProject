using System;
using System.Collections.Generic;

namespace COS.Core.DTOs
{
    public class OrderDto {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime DueFor { get; set; }
        public bool Takeaway { get; set; }
        public bool FoodReady { get; set; }
        public bool OrderFulfilled { get; set; }
        public bool Submitted { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comment { get; set; }
        public IList<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
        
    }
}