using Core.Interfaces;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public IBasketRepository BasketRepository { get; }
        public BasketController(IBasketRepository basketRepository)
        {
            BasketRepository = basketRepository;
        }
    }
}