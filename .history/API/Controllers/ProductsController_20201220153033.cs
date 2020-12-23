using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {


        public ProductsController( )
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }

          [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> getProductBrands()
        {
            return Ok(await _repo.GetProductBrandsAsync());
        }

          [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> getProductTypes()
        {
           return Ok(await _repo.GetProductTypesAsync());
        }
    }
}