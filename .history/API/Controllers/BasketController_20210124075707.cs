using Core.Interfaces;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public IBasketRepository _basketRepository { get; }
        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository  = basketRepository;
        }
    }
}