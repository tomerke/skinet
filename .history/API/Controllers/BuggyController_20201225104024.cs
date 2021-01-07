using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController :BaseApiController
    {
        public BuggyController(StoreContext context)
        {
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest(){

        }
    }
}