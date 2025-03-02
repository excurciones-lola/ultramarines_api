using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;

namespace excurciones_lola.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().ToTable("Trip");
        }
    }
}