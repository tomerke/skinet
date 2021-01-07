using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController :BaseApiController
    {
        public BuggyController(Strore)
        {
        }

        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest(){

        }
    }
}