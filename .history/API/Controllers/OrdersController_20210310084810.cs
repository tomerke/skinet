using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Authorize]
    public class OrdersController : BaseApiController
    {
        public OrdersController(IOderService orderService)
        {
        }
    }
}