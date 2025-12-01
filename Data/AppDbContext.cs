using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        // register entities/models (tables)
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Warehouse> Warehouses { get; set; } = null!;
        public DbSet<Stock> Stocks { get; set; } = null!;
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; } = null!;
        public DbSet<TransactionDetail> TransactionDetails { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<UserRole> UserRoles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
           .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Role>().HasData(
                               new Role { Id = 1, Name = "SuperAdmin" },
                               new Role { Id = 2, Name = "WarehouseManager" },
                               new Role { Id = 3, Name = "WarehouseStaff" },
                               new Role { Id = 4, Name = "Purchasing" },
                               new Role { Id = 5, Name = "Sales" },
                               new Role { Id = 6, Name = "Auditor" }
                           );
        }
    }
}