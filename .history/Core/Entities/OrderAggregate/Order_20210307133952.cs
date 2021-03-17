namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTime MyProperty { get; set; }

    }
}