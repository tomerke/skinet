namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {   [EnumMemeber]
        Pending,
        PaymentRecevied,
        PaymentFailed
    }
}