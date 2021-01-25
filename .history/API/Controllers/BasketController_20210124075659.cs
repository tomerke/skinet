using Core.Interfaces;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public IBasketRepository _asketRepository { get; }
        public BasketController(IBasketRepository basketRepository)
        {
            BasketRepository = basketRepository;
        }
    }
}