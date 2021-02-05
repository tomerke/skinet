using Core.Entities.Identity;
using Core.Interfaces;

namespace Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        public TokenService()
        {
        }

        public string CreateToken(AppUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}