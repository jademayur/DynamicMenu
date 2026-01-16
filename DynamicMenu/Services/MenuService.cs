using DynamicMenu.DTOs;
using DynamicMenu.Repositories;

namespace DynamicMenu.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        public async Task<List<MenuDto>> GetMenusByRoleAsync(string role)
        {
           var menus = await menuRepository.GetMenusByRoleAsync(role);

            return menus.Select(m => new MenuDto
            {
                Title = m.Title,
                Route = m.Route
            }).ToList();
        }
    }
}
