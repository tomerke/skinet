using System;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTimeOffset MyProperty { get; set; }

    }
}