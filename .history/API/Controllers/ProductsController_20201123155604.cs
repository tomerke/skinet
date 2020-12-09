using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string getProducts(){
            return "this will be a list of products";
        }

        [HttpGet]
        public string getProduct(){
            return "singleProduct"
        }
    }
}