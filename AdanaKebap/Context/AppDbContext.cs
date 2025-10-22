using AdanaKebap.Models.Admin;
using AdanaKebap.Models.WebUI;
using Microsoft.EntityFrameworkCore;

namespace AdanaKebap.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8AVNO4L\\SQLEXPRESS;Database=AdanaDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Booking> Bookings { get; set; }

        //public DbSet<User> Users { get; set; }
  
    }
}
