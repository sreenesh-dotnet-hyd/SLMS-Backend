using Microsoft.EntityFrameworkCore;
using CostAllocationService.Models;

namespace CostAllocationService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<CostAllocation> CostAllocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("departments");
            modelBuilder.Entity<Department>()
                .Property(p => p.ManagerId)
                .HasColumnName("manager_id");

            modelBuilder.Entity<CostAllocation>().ToTable("cost_allocation");

            // ------------------------------------------------
            // ✅ SEED 10 DEPARTMENTS (STATIC VALUES)
            // ------------------------------------------------
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Engineering", ManagerId = 101 },
                new Department { Id = 2, Name = "Finance", ManagerId = 102 },
                new Department { Id = 3, Name = "HR", ManagerId = 103 },
                new Department { Id = 4, Name = "Marketing", ManagerId = 104 },
                new Department { Id = 5, Name = "Sales", ManagerId = 105 },
                new Department { Id = 6, Name = "IT Support", ManagerId = 106 },
                new Department { Id = 7, Name = "Security", ManagerId = 107 },
                new Department { Id = 8, Name = "Infrastructure", ManagerId = 108 },
                new Department { Id = 9, Name = "Product", ManagerId = 109 },
                new Department { Id = 10, Name = "Operations", ManagerId = 110 }
            );

            // ------------------------------------------------
            // ⭐ FIX: Use STATIC DATE for ALL records
            // ------------------------------------------------
            var seedDate = new DateTime(2024, 01, 01);
            // ------------------------------------------------
            // ✅ SEED 10 COST ALLOCATION RECORDS (STATIC DATE)
            // ------------------------------------------------

            modelBuilder.Entity<CostAllocation>().HasData(
                new CostAllocation { Id = 1, EntitlementId = 1, DepartmentId = 1, AllocationRule = "fixed_split", Percentage = 20, AllocatedCost = 20000, CalculatedAt = seedDate },
                new CostAllocation { Id = 2, EntitlementId = 1, DepartmentId = 2, AllocationRule = "fixed_split", Percentage = 10, AllocatedCost = 10000, CalculatedAt = seedDate },

                new CostAllocation { Id = 3, EntitlementId = 2, DepartmentId = 3, AllocationRule = "usage_based", Percentage = 30, AllocatedCost = 30000, CalculatedAt = seedDate },
                new CostAllocation { Id = 4, EntitlementId = 2, DepartmentId = 4, AllocationRule = "usage_based", Percentage = 15, AllocatedCost = 15000, CalculatedAt = seedDate },

                new CostAllocation { Id = 5, EntitlementId = 3, DepartmentId = 5, AllocationRule = "fixed_split", Percentage = 25, AllocatedCost = 25000, CalculatedAt = seedDate },
                new CostAllocation { Id = 6, EntitlementId = 3, DepartmentId = 6, AllocationRule = "fixed_split", Percentage = 5, AllocatedCost = 5000, CalculatedAt = seedDate },

                new CostAllocation { Id = 7, EntitlementId = 4, DepartmentId = 7, AllocationRule = "usage_based", Percentage = 40, AllocatedCost = 40000, CalculatedAt = seedDate },
                new CostAllocation { Id = 8, EntitlementId = 4, DepartmentId = 8, AllocationRule = "usage_based", Percentage = 10, AllocatedCost = 10000, CalculatedAt = seedDate },

                new CostAllocation { Id = 9, EntitlementId = 5, DepartmentId = 9, AllocationRule = "fixed_split", Percentage = 15, AllocatedCost = 15000, CalculatedAt = seedDate },
                new CostAllocation { Id = 10, EntitlementId = 5, DepartmentId = 10, AllocationRule = "fixed_split", Percentage = 5, AllocatedCost = 5000, CalculatedAt = seedDate }
            );

        }
    }
}
