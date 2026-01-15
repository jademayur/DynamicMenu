using DynamicMenu.Data;
using DynamicMenu.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicMenu.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public async Task<User?> GetByEmailIdAsync(string emailId)
        {
            return await appDbContext.users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == emailId);
        }

        public async Task AddAsync(User user)
        {
            appDbContext.users.Add(user);
            await appDbContext.SaveChangesAsync();
        }
    }
}
