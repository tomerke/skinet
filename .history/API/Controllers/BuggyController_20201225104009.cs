using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController :BaseApiController
    {
        public BuggyController(StroreContext )
        {
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest(){

        }
    }
}