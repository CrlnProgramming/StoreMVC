using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }

    }
}
