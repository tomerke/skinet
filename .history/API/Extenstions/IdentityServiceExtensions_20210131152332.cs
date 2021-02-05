using Core.Entities.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extenstions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<AppUser>();
            builder = new IdentityBuilder(builder)
        }
    }
}