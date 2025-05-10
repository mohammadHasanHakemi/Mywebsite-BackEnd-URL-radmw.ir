using Microsoft.EntityFrameworkCore;

namespace MyMvcProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet برای جداول
        public DbSet<Album> Albums { get; set; }
        public DbSet<Music> Music { get; set; }
    }
}
