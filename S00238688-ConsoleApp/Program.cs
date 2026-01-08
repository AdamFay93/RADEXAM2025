using Microsoft.EntityFrameworkCore;
using S00238688_ClassLibrary;
namespace Program
{
    public class ConsoleEcommerceContext : DbContext
    {
        public DbSet<CategoryClass> Categories { get; set; }
        public DbSet<CollectibleClass> Collectibles { get; set; }
        public DbSet<OrderClass> Orders { get; set; }
        public DbSet<OrderItemClass> OrderItems { get; set; }
        public DbSet<UserClass> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ConsoleEcommerceDB;Trusted_Connection=True;");
        }
    }
}
    
