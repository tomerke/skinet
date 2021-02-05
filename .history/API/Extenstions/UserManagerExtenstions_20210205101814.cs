using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Entities.Identity;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Extenstions
{
    public static class UserManagerExtenstions
    {
        public static async Task<AppUser> FindByEmailWithAddressAsync( this UserManager<AppUser> input, ClaimsPrincipal user)
        {
              var email = user?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

              return await input.Users.Include(x  =)
        }
    }
}