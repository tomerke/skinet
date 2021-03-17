using System;
using System.Collections.Generic;
using Core.Entities.OrderAggregate;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;


        public DeliveryMethod DeliveryMethod { get; set; }
         public Address ShipToAddress { get; set; }

        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string Payment { get; set; }

    }
}