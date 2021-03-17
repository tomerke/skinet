using System;
using System.Collections.Generic;
using Core.Entities.Identity;
using Core.Entities.OrderAggregate;

namespace API.Dtos
{
    public class OrderToReturnDto
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public Core.Entities.OrderAggregate.Address ShipToAddress { get; set; }
        public string DeliveryMethod { get; set; }
        public decimal Sh { get; set; }
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal Subtotal { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string PaymentIntentId { get; set; }

    }
}