using DynamicMenu.DTOs;
using DynamicMenu.Models;
using DynamicMenu.Repositories;

namespace DynamicMenu.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddAsync(RegisterRequestDto request)
        {
            var existingUser = await _userRepository.GetByEmailIdAsync(
            request.Email.ToLower()
        );

            if (existingUser != null)
                throw new Exception("User already exists");

            var user = new User
            {
                Email = request.Email.ToLower(),
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password),
                Role = request.Role
            };

            await _userRepository.AddAsync(user);
        }
    }
}
