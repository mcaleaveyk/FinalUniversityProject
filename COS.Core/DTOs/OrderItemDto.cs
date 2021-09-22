namespace COS.Core.DTOs
{
    public class OrderItemDto {        
        //foreign key
        public int OrderId { get; set; }
        //foreign key
        public int ItemId { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }

    }
}