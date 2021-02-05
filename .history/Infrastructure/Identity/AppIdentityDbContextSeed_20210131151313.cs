using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Tomer",
                    Email = "tomer@gmail.com",
                    UserName = "tomerke",
                    Address = new Address
                    {
                        FirstName
                    }
                }
            }
        }
    }
}