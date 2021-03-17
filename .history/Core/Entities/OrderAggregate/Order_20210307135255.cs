using System;
using System.Collections.Generic;
using Core.Entities.OrderAggregate;

namespace Core.Entities.OrderAggregate
{
    public class Order : BaseEntity
    {
        public Order(string buyerEmail, DateTimeOffset orderDate, Address shipToAddress, DeliveryMethod deliveryMethod, IReadOnlyList<OrderItem> orderItems, decimal subTotal, OrderStatus status, string paymentIntentId)
        {
            BuyerEmail = buyerEmail;
            OrderDate = orderDate;
            ShipToAddress = shipToAddress;
            DeliveryMethod = deliveryMethod;
            OrderItems = orderItems;
            SubTotal = subTotal;
            Status = status;
          
        }

        public string BuyerEmail { get; set; }

        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
         public Address ShipToAddress { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }

        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public string PaymentIntentId { get; set; }

        public decimal GetTotal()
        {
            return SubTotal + DeliveryMethod.Price;
        }

    }
}