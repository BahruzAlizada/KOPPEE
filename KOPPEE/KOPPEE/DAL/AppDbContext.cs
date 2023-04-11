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
    }
}
