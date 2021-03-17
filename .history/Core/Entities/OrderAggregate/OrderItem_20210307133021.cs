namespace Core.Entities.OrderAggregate
{
    public class OrderItem :BaseEntity
    {
        public ProductItem MyProperty { get; set; }
    }
}