using System.Linq;
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
                        FirstName = "Amit",
                        LastName = "Sadi",
                        Street = "10 Hamaavaq",
                        City = "Tel Aviv",
                        State = "TLV",
                        Zipcode = "90210"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}