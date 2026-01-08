using Microsoft.EntityFrameworkCore;
using S00238688_ClassLibrary;
using System.Diagnostics.Metrics;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClass>(b =>
            {
                b.HasData(
                    new UserClass { User_ID = 1, Name = "Alice Carter", Email = "alice@example.com", Role = "customer" },
                    new UserClass { User_ID = 2, Name = "Bob Nguyen", Email = "bob@example.com", Role = "customer" });
            });
            modelBuilder.Entity<CategoryClass>(b =>
            {
                b.HasData(
                    new CategoryClass { Category_ID = 1, Name = "Trading Cards"},
                    new CategoryClass { Category_ID = 2, Name = "Action Figures" });
            });
            modelBuilder.Entity<CollectibleClass>(b =>
            {
                b.HasData(
                    new CollectibleClass { Collectible_ID = 1, Name = "Pikachu Holo Card", Category_ID = 1, Price = 120.00m, Condition = "Mint", Stock_Quantity = 5},
                    new CollectibleClass { Collectible_ID = 2, Name = "Batman Figure", Category_ID = 2, Price = 80.00m, Condition = "Good", Stock_Quantity = 3 },
                    new CollectibleClass { Collectible_ID = 3, Name = "Yoda Figure", Category_ID = 2, Price = 95.50m, Condition = "Near Mint", Stock_Quantity = 2});
            });
            modelBuilder.Entity<OrderClass>(b =>
            {
                b.HasData(
                    new OrderClass { Order_ID = 101, User_ID = 1, Total_Price = 120.00m, Payment_Status = "Paid", Order_Status = "Shipped" },
                    new OrderClass { Order_ID = 102, User_ID = 2, Total_Price = 175.50m, Payment_Status = "Pending", Order_Status = "Processing" });
            });
            modelBuilder.Entity<OrderItemClass>(b =>
            {
                b.HasData(
                    new OrderItemClass { Order_Item_ID = 1, Order_ID = 101, Collectible_ID = 1, Quantity = 1, Unit_Price = 120.00m },
                    new OrderItemClass { Order_Item_ID = 2, Order_ID = 102, Collectible_ID = 2, Quantity = 1, Unit_Price = 80.00m },
                    new OrderItemClass { Order_Item_ID = 3, Order_ID = 103, Collectible_ID = 3, Quantity = 1, Unit_Price = 95.50m });
            });
        }
    }
}
    
