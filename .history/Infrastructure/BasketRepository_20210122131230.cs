using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using StackExchange.Redis;

namespace Infrastructure
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;

        public BasketRepository(IConnectionMultiplexer redis)
        {
            _database = redis.GetDatabase();
        }

        public Task<bool> DeleteBasketAsync(string basketId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerBasket> GetBasketAsync(string basketId)
        {
            var data = wait 
         }

        public Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket)
        {
            throw new System.NotImplementedException();
        }
    }
}