using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly StoreContext _context;
        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
           var things = _context.Products.Find(42);
           if 
            return Ok();
        }

          [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            return Ok();
        }

          [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            return Ok();
        }

          [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest()
        {
            return Ok();
        }
    }
}