using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {

    }
}