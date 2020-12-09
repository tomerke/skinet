using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
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
        public async Task<ActionResult<List<Product>>> getProducts()
        {
           var products = await _context.Products.ToListA();
           return Ok(products);
        }

        [HttpGet("{id}")]
        public string getProduct(int id)
        {
            return "singleProduct";
        }
    }
}