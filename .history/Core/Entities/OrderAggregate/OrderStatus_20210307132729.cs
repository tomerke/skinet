namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {   [Enum]
        Pending,
        PaymentRecevied,
        PaymentFailed
    }
}