using KOPPEE.Models;
using Microsoft.EntityFrameworkCore;

namespace KOPPEE.DAL
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bio> Bio { get; set; }
    }
}
