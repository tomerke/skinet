using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrdersWithItemsAndOrederingSpecification : BaseSpecification<Order>
    {
        public OrdersWithItemsAndOrederingSpecification(string email) :base(o => o.BuyerEmail == email)
        {
            AddInclude(o => o.OrderItems);
            AddInclude(o => o.DeliveryMethod);
            AddOrderByDescending(o => o.OrderDate)
        }

        public OrdersWithItemsAndOrederingSpecification(Expression<Func<Order, bool>> criteria) : base(criteria)
        {
        }
    }
}