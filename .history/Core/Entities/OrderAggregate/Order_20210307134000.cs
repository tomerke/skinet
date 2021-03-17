namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Order(string buyerEmail, DateTimeOffset myProperty)
        {
            this.BuyerEmail = buyerEmail;
                this.MyProperty = myProperty;

        }
                public string BuyerEmail { get; set; }

        public DateTimeOffset MyProperty { get; set; }

    }
}