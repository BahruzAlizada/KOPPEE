using KOPPEE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KOPPEE.DAL
{
	public class AppDbContext : IdentityDbContext<AppUser>
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
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Reservation> Reservationss { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
