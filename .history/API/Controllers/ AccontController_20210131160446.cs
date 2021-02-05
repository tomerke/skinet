using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace API.Controllers
{
    public class AccontController : BaseApiController
    {
        public UserManager<AppUser> UserManager { get; }
        public AccontController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserManager = userManager;

        }
    }
}