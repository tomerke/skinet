namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {   [EnumMember]
        Pending,
        PaymentRecevied,
        PaymentFailed
    }
}