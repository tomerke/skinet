using System.Text.Json;
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

        public async Task<CustomerBasket> GetBasketAsync(string basketId)
        {
            var data = await _database.StringGetAsync(basketId);
            return data.IsNullOrEmpty? null : JsonSerializer.Deserialize<CustomerBasket>(basketId);
         }

        public async Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket)
        {
            var created = await _database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), TimeSpan);
        }
    }
}