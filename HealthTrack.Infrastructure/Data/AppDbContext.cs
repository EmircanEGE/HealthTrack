using HealthTrack.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthTrack.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Exercise> Exercises => Set<Exercise>();
        public DbSet<Nutrition> Nutritions => Set<Nutrition>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
