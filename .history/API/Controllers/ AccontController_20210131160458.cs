using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace API.Controllers
{
    public class AccontController : BaseApiController
    {
        private readonly UserManager<AppUser> _userManager;
        public AccontController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;

        }
    }
}