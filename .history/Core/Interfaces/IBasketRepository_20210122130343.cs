namespace Core.Interfaces
{
    public interface IBasketRepository
    {
         Task<CustomerBasket> GetBasketAsync(string basketId)
    }
}