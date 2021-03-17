using Microsoft.AspNetCore.Authorization;
using Core.Interfaces;

namespace API.Controllers
{
    [Authorize]
    public class OrdersController : BaseApiController
    {
        public OrdersController(IOrderService orderService)
        {
        }
    }
}