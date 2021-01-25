using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public IBasketRepository _basketRepository { get; }
        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return Ok(basket?? new CustomerBasket(id));
        }

        [HttpPost]
          public async Task<ActionResult<CustomerBasket>> UpdateBasket(string id)
        {
            var basket = await _basketRepository.UpdateBasketAsync(id);

            return Ok(basket?? new CustomerBasket(id));
        }
    }
}