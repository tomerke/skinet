namespace Core.Entities.OrderAggregate
{
    public class OrderItem :BaseEntity
    {
        public ProductItemOrdered ItemOrdered { get; set; }
        public int MyProperty { get; set; }
    }
}