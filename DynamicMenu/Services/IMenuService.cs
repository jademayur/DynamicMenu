using DynamicMenu.DTOs;
using DynamicMenu.Models;

namespace DynamicMenu.Services
{
    public interface IMenuService
    {
        Task<List<MenuDto>> GetMenusByRoleAsync(string role);
    }
}
