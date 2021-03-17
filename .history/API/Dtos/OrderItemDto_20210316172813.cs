namespace API.Dtos
{
    public class OrderItemDto
    {
        public int  ItemOrdered { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}