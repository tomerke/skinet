using System;
using Core.Entities.OrderAggregate;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public Address ShipToAddress { get; set; }

        public DeliveryMethod MyProperty { get; set; }

    }
}