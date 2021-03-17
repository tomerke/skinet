namespace Core.Entities.OrderAggregate
{
    public class OrderItem :BaseEntity
    {
        public ProductItemOrdered MyProperty { get; set; }
    }
}