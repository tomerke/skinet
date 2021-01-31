using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure
{
    public class BasketRepository : IBasketRepository
    {
        private 
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