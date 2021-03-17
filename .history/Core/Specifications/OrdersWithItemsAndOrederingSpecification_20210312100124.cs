using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrdersWithItemsAndOrederingSpecification : BaseSpecification<Order>
    {
        public OrdersWithItemsAndOrederingSpecification(string email)
        {
        }

        public OrdersWithItemsAndOrederingSpecification(Expression<Func<Order, bool>> criteria) : base(criteria)
        {
        }
    }
}