using System;
using System.Collections.Generic;
using Core.Entities.OrderAggregate;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTimeOffset OrderDate { get; set; }
        public Address ShipToAddress { get; set; }

        public DeliveryMethod DeliveryMethod { get; set; }

        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public dec MyProperty { get; set; }

    }
}