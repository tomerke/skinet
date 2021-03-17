namespace API.Dtos
{
    public class OrderItemDto
    {
        public int  ProductId { get; set; }
        public int MyProperty { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}