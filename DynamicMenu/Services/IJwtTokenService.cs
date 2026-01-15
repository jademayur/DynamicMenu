using DynamicMenu.Models;

namespace DynamicMenu.Services
{
    public interface IJwtTokenService
    {
        public string GenerateToken(User user);
    }
}
