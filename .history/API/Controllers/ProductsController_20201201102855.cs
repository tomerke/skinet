using System.Collections.Generic;
using System.Linq;
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
        public async TaskActionResult<List<Product>> getProducts()
        {
           var products = _context.Products.ToList();
           return Ok(products);
        }

        [HttpGet("{id}")]
        public string getProduct(int id)
        {
            return "singleProduct";
        }
    }
}