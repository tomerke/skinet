namespace Core.Entities.OrderAggregate
{
    public class OrderItem :BaseEntity
    {
        public ProductItemOrdered ItemOrdered { get; set; }
        public decimal MyProperty { get; set; }
    }
}