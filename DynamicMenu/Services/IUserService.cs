using DynamicMenu.DTOs;

namespace DynamicMenu.Services
{
    public interface IUserService
    {
        public Task AddAsync(RegisterRequestDto request);
    }
}
