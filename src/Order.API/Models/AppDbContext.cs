using Microsoft.EntityFrameworkCore;
using Order.API.Mapping.Configuration;
using System.Reflection;

namespace Order.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}
