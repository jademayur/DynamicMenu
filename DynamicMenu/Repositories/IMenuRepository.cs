using DynamicMenu.DTOs;
using DynamicMenu.Models;

namespace DynamicMenu.Repositories
{
    public interface IMenuRepository
    {
        public Task<List<Menu>> GetMenusByRoleAsync(string role);
    }
}
