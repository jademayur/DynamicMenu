using DynamicMenu.Data;
using DynamicMenu.DTOs;
using DynamicMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicMenu.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext appDbContext;
        public MenuRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<List<Menu>> GetMenusByRoleAsync(string role)
        {
           return await appDbContext.Menus
                .Where(menu => menu.Role == role)
                .ToListAsync();
        }
    }
}
