using API.Data;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IRequestFormLimitsPolicy< getProducts()
        {
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string getProduct(int id)
        {
            return "singleProduct";
        }
    }
}