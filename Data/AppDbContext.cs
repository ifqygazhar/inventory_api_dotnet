using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Inventory.Data
{
    public class AppDbContext : IdentityDbContext<User, Role, string>
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(e => e.ToTable("Users"));
            modelBuilder.Entity<Role>(e => e.ToTable("Roles"));
            modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>(e => e.ToTable("UserRoles"));

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b7330",
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN",
                    Description = "Full access to all features",
                    IsActive = true,
                    ConcurrencyStamp = "c7b013f0-5201-4317-abd8-c211f91b7330",
                },
                new Role
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    Name = "WarehouseManager",
                    NormalizedName = "WAREHOUSEMANAGER",
                    Description = "Manage stock and approvals",
                    IsActive = true,
                    ConcurrencyStamp = "bd2bcf0c-20db-474f-8407-5a6b159518bb"
                },
                new Role
                {
                    Id = "8af10569-b718-4ac4-9b51-cf862f90260d",
                    Name = "WarehouseStaff",
                    NormalizedName = "WAREHOUSESTAFF",
                    Description = "Input inbound and outbound items",
                    IsActive = true,
                    ConcurrencyStamp = "8af10569-b718-4ac4-9b51-cf862f90260d"
                },
                new Role
                {
                    Id = "1262f022-7744-48f8-b851-177935c13f99",
                    Name = "Purchasing",
                    NormalizedName = "PURCHASING",
                    Description = "Manage vendors and PO",
                    IsActive = true,
                    ConcurrencyStamp = "1262f022-7744-48f8-b851-177935c13f99"
                },
                new Role
                {
                    Id = "f5a54388-1c4b-4f51-877f-178556606f23",
                    Name = "Sales",
                    NormalizedName = "SALES",
                    Description = "View stock availability",
                    IsActive = true,
                    ConcurrencyStamp = "f5a54388-1c4b-4f51-877f-178556606f23"
                },
                new Role
                {
                    Id = "0c42718e-6701-4127-b457-3e5831730043",
                    Name = "Auditor",
                    NormalizedName = "AUDITOR",
                    Description = "View reports only",
                    IsActive = true,
                    ConcurrencyStamp = "0c42718e-6701-4127-b457-3e5831730043"
                }
            );
        }
    }
}