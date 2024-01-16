using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoApi.Entities;

namespace TodoApi.Data
{
    public class ApplicationDbContext: IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> category { get; set; }
    }
}
