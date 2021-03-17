namespace Core.Interfaces
{
    public interface IOrderService
    {
         Task<Order> CreateOrderAsync(string buyerEmail, int deliveryMethod, string basketId, Address shipping)
    }
}