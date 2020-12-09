using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(StoreContext )
        {
        }

        [HttpGet]
        public string getProducts(){
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string getProduct(int id){
            return "singleProduct";
        }
    }
}