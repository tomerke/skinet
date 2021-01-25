using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using StackExchange.Redis;

namespace Infrastructure
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;

        public BasketRepository(IConnection)
        {
        }

        public Task<bool> DeleteBasketAsync(string basketId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerBasket> GetBasketAsync(string basketId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket)
        {
            throw new System.NotImplementedException();
        }
    }
}