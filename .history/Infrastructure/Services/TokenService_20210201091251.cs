using Core.Entities.Identity;
using Core.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        public TokenService(IConfiguration)
        {
        }

        public string CreateToken(AppUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}