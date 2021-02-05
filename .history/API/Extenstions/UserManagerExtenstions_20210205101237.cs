using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace API.Extenstions
{
    public static class UserManagerExtenstions
    {
        public static async Task<AppUser> FindByEmailWithAddressAsync( this UserManager<AppUser> input)
        {
            
        }
    }
}