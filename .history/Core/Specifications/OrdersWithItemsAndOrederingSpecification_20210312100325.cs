using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrdersWithItemsAndOrederingSpecification : BaseSpecification<Order>
    {
        public OrdersWithItemsAndOrederingSpecification(string email) :base(o => o.BuyerEmail == email)
        {
            Ad
        }

        public OrdersWithItemsAndOrederingSpecification(Expression<Func<Order, bool>> criteria) : base(criteria)
        {
        }
    }
}