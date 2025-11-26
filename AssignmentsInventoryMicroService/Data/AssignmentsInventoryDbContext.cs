using AssignmentsInventoryMicroService.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsInventoryMicroService.Data
{
    public class AssignmentsInventoryDbContext : DbContext
    {
        public AssignmentsInventoryDbContext(DbContextOptions<AssignmentsInventoryDbContext> options)
            : base(options) { }

        public DbSet<Device> Devices => Set<Device>();
        public DbSet<Installation> Installations => Set<Installation>();
        public DbSet<UserAssignment> UserAssignments => Set<UserAssignment>();
        public DbSet<UsageEvent> UsageEvents => Set<UsageEvent>();
        public DbSet<ComplianceAuditSnapshot> ComplianceAudits => Set<ComplianceAuditSnapshot>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // table names
            modelBuilder.Entity<Device>().ToTable("devices");
            modelBuilder.Entity<Installation>().ToTable("installations");
            modelBuilder.Entity<UserAssignment>().ToTable("user_assignments");
            modelBuilder.Entity<UsageEvent>().ToTable("usage_tracking");
            modelBuilder.Entity<ComplianceAuditSnapshot>().ToTable("audits");

            // PKs
            modelBuilder.Entity<Device>().HasKey(d => d.DeviceId);
            modelBuilder.Entity<Installation>().HasKey(i => i.InstallationId);
            modelBuilder.Entity<UserAssignment>().HasKey(a => a.AssignmentId);
            modelBuilder.Entity<UsageEvent>().HasKey(u => u.UsageEventId);
            modelBuilder.Entity<ComplianceAuditSnapshot>().HasKey(a => a.AuditId);

            // relationships
            modelBuilder.Entity<Device>()
                .HasMany(d => d.Installations)
                .WithOne(i => i.Device!)
                .HasForeignKey(i => i.DeviceId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UsageEvent>()
                .HasOne(u => u.Device)
                .WithMany()
                .HasForeignKey(u => u.DeviceId)
                .OnDelete(DeleteBehavior.Restrict);

            // --------- Dummy seed data ---------
            var device1Id = Guid.NewGuid();
            var device2Id = Guid.NewGuid();

            var productOffice = Guid.NewGuid();    // pretend product ids
            var productPhotoshop = Guid.NewGuid();

            var entOffice = Guid.NewGuid();
            var entPhotoshop = Guid.NewGuid();

            var userAlice = Guid.NewGuid();
            var userBob = Guid.NewGuid();

            modelBuilder.Entity<Device>().HasData(
                new Device
                {
                    DeviceId = device1Id,
                    Hostname = "DESKTOP-IT-01",
                    DepartmentId = Guid.NewGuid(),
                    OwnerUserId = userAlice,
                    DeviceType = "Desktop",
                    LastSeen = DateTime.UtcNow,
                    Status = "Active"
                },
                new Device
                {
                    DeviceId = device2Id,
                    Hostname = "LAPTOP-FIN-02",
                    DepartmentId = Guid.NewGuid(),
                    OwnerUserId = userBob,
                    DeviceType = "Laptop",
                    LastSeen = DateTime.UtcNow.AddMinutes(-15),
                    Status = "Active"
                }
            );

            modelBuilder.Entity<Installation>().HasData(
                new Installation
                {
                    InstallationId = Guid.NewGuid(),
                    DeviceId = device1Id,
                    ProductId = productOffice,
                    EntitlementId = entOffice,
                    Version = "Office 365",
                    InstallDate = DateTime.UtcNow.AddDays(-30),
                    LastSeen = DateTime.UtcNow,
                    Discovered = true
                },
                new Installation
                {
                    InstallationId = Guid.NewGuid(),
                    DeviceId = device2Id,
                    ProductId = productPhotoshop,
                    EntitlementId = entPhotoshop,
                    Version = "Photoshop 2024",
                    InstallDate = DateTime.UtcNow.AddDays(-10),
                    LastSeen = DateTime.UtcNow.AddMinutes(-20),
                    Discovered = true
                }
            );

            modelBuilder.Entity<UserAssignment>().HasData(
                new UserAssignment
                {
                    AssignmentId = Guid.NewGuid(),
                    UserId = userAlice,
                    ProductId = productOffice,
                    EntitlementId = entOffice,
                    Status = "Active",
                    AssignedAt = DateTime.UtcNow.AddDays(-45),
                    LastUsedAt = DateTime.UtcNow.AddHours(-1),
                    ExemptFlag = false
                },
                new UserAssignment
                {
                    AssignmentId = Guid.NewGuid(),
                    UserId = userBob,
                    ProductId = productPhotoshop,
                    EntitlementId = entPhotoshop,
                    Status = "Active",
                    AssignedAt = DateTime.UtcNow.AddDays(-60),
                    LastUsedAt = DateTime.UtcNow.AddDays(-40),     // good for reclaim demo
                    ExemptFlag = false
                }
            );

            modelBuilder.Entity<UsageEvent>().HasData(
                new UsageEvent
                {
                    UsageEventId = Guid.NewGuid(),
                    UserId = userAlice,
                    DeviceId = device1Id,
                    ProductId = productOffice,
                    EventType = "session_start",
                    Timestamp = DateTime.UtcNow.AddMinutes(-30),
                    SessionId = Guid.NewGuid(),
                    DurationSeconds = 1800
                },
                new UsageEvent
                {
                    UsageEventId = Guid.NewGuid(),
                    UserId = userBob,
                    DeviceId = device2Id,
                    ProductId = productPhotoshop,
                    EventType = "launch_app",
                    Timestamp = DateTime.UtcNow.AddDays(-40),
                    SessionId = null,
                    DurationSeconds = 600
                }
            );

            modelBuilder.Entity<ComplianceAuditSnapshot>().HasData(
                new ComplianceAuditSnapshot
                {
                    AuditId = Guid.NewGuid(),
                    ProductId = productOffice,
                    SnapshotTime = DateTime.UtcNow.AddDays(-1),
                    AssignedCount = 10,
                    UsedCount = 7,
                    EntitlementsPurchased = 12,
                    Status = "Compliant"
                },
                new ComplianceAuditSnapshot
                {
                    AuditId = Guid.NewGuid(),
                    ProductId = productPhotoshop,
                    SnapshotTime = DateTime.UtcNow.AddDays(-1),
                    AssignedCount = 20,
                    UsedCount = 5,
                    EntitlementsPurchased = 8,
                    Status = "OverLicensed"   // too many seats vs use
                }
            );
        }
    }
}
