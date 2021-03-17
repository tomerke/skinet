using Microsoft.AspNetCore.Authorization;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.Entities.OrderAggregate;
using API.Dtos;
using AutoMapper;

namespace API.Controllers
{
    [Authorize]
    public class OrdersController : BaseApiController
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(OrderDto orderDto)
        {
            var email = HttpContext.User?.Claims?.FirstOrDef
        }
    }
}