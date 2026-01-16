using DynamicMenu.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenus()
        {
            var userRole = User.Claims.FirstOrDefault(c => c.Type == "role")?.Value;
            if (string.IsNullOrEmpty(userRole))
            {
                return Unauthorized();
            }
            var menus = await _menuService.GetMenusByRoleAsync(userRole);
            return Ok(menus);
        }
    }
}
