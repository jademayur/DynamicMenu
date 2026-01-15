using DynamicMenu.DTOs;
using Microsoft.AspNetCore.Identity.Data;

namespace DynamicMenu.Services
{
    public interface IAuthService
    {
        LoginResponseDto Login(LoginRequestDto loginRequest);
    }
}
