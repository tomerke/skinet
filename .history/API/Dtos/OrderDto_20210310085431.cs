namespace API.Dtos
{
    public class OrderDto
    {
        public string BasketId { get; set; }
        public int DeliveryMethod { get; set; }
        public Address MyProperty { get; set; }
    }
}