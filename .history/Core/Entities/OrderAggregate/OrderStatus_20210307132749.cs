using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {   [EnumMember()]
        Pending,
        PaymentRecevied,
        PaymentFailed
    }
}