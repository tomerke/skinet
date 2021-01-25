using Core.Interfaces;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public BasketController(IBasketRepository basket)
        {
        }
    }
}