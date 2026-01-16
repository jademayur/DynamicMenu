using DynamicMenu.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DynamicMenu.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
