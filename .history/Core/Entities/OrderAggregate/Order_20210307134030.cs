using System;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public int MyProperty { get; set; }

    }
}