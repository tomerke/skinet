namespace API.Dtos
{
    public class OrderItemDto
    {
               public ProductItemOrdered ItemOrdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}