using DynamicMenu.DTOs;
using DynamicMenu.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(RegisterRequestDto request)
        {
            await _userService.AddAsync(request);
            return Ok("User registered successfully");
        }
    }
}
