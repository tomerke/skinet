namespace API.Controllers
{
    public class BuggyController :BaseApiController
    {
        [HttpGet("notfound")]
        public ActionResult GetNotFoundRequest
    }
}