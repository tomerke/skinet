using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
          [EnumMember(Value = "Pending")]
        Pending,
        PaymentRecevied,
        PaymentFailed
    }
}