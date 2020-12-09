using System.Collections.Generic;
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
        public ActionResult<List<Product>> getProducts()
        {
           var products
        }

        [HttpGet("{id}")]
        public string getProduct(int id)
        {
            return "singleProduct";
        }
    }
}