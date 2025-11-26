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

            // ---------- Table names ----------
            modelBuilder.Entity<Device>().ToTable("devices");
            modelBuilder.Entity<Installation>().ToTable("installations");
            modelBuilder.Entity<UserAssignment>().ToTable("user_assignments");
            modelBuilder.Entity<UsageEvent>().ToTable("usage_tracking");
            modelBuilder.Entity<ComplianceAuditSnapshot>().ToTable("audits");

            // ---------- Primary keys ----------
            modelBuilder.Entity<Device>().HasKey(d => d.DeviceId);
            modelBuilder.Entity<Installation>().HasKey(i => i.InstallationId);
            modelBuilder.Entity<UserAssignment>().HasKey(a => a.AssignmentId);
            modelBuilder.Entity<UsageEvent>().HasKey(u => u.UsageEventId);
            modelBuilder.Entity<ComplianceAuditSnapshot>().HasKey(a => a.AuditId);

            // ---------- Relationships ----------
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

            // ---------- STATIC, REALISTIC SEED DATA ----------
            var baseDate = new DateTime(2025, 01, 01, 9, 0, 0, DateTimeKind.Utc);

            // Departments (logical IDs, other service)
            var deptIt = Guid.Parse("40000000-0000-0000-0000-000000000001");
            var deptFinance = Guid.Parse("40000000-0000-0000-0000-000000000002");
            var deptHr = Guid.Parse("40000000-0000-0000-0000-000000000003");
            var deptEng = Guid.Parse("40000000-0000-0000-0000-000000000004");
            var deptSales = Guid.Parse("40000000-0000-0000-0000-000000000005");

            // Users (logical IDs, from Identity service)
            var userAliceIt = Guid.Parse("30000000-0000-0000-0000-000000000001"); // IT
            var userBobFin = Guid.Parse("30000000-0000-0000-0000-000000000002"); // Finance
            var userCarolHr = Guid.Parse("30000000-0000-0000-0000-000000000003"); // HR
            var userDaveEng = Guid.Parse("30000000-0000-0000-0000-000000000004"); // Eng
            var userEveEng = Guid.Parse("30000000-0000-0000-0000-000000000005");
            var userFrankSales = Guid.Parse("30000000-0000-0000-0000-000000000006");
            var userGraceFin = Guid.Parse("30000000-0000-0000-0000-000000000007");
            var userHeidiIt = Guid.Parse("30000000-0000-0000-0000-000000000008");
            var userIvanSales = Guid.Parse("30000000-0000-0000-0000-000000000009");
            var userJudyHr = Guid.Parse("30000000-0000-0000-0000-000000000010");

            // Products (from Catalog service)
            var productOffice365 = Guid.Parse("10000000-0000-0000-0000-000000000001");
            var productPhotoshop = Guid.Parse("10000000-0000-0000-0000-000000000002");
            var productVsPro = Guid.Parse("10000000-0000-0000-0000-000000000003");
            var productSqlServer = Guid.Parse("10000000-0000-0000-0000-000000000004");
            var productZoom = Guid.Parse("10000000-0000-0000-0000-000000000005");
            var productSlack = Guid.Parse("10000000-0000-0000-0000-000000000006");
            var productPowerBi = Guid.Parse("10000000-0000-0000-0000-000000000007");
            var productJira = Guid.Parse("10000000-0000-0000-0000-000000000008");
            var productTeams = Guid.Parse("10000000-0000-0000-0000-000000000009");
            var productVsCode = Guid.Parse("10000000-0000-0000-0000-000000000010");

            // Entitlements (from Catalog service)
            var entOfficeIt = Guid.Parse("20000000-0000-0000-0000-000000000001");
            var entOfficeFinance = Guid.Parse("20000000-0000-0000-0000-000000000002");
            var entPhotoshopEng = Guid.Parse("20000000-0000-0000-0000-000000000003");
            var entVsProEng = Guid.Parse("20000000-0000-0000-0000-000000000004");
            var entSqlServerDb = Guid.Parse("20000000-0000-0000-0000-000000000005");
            var entZoomCorp = Guid.Parse("20000000-0000-0000-0000-000000000006");
            var entSlackCorp = Guid.Parse("20000000-0000-0000-0000-000000000007");
            var entPowerBiFin = Guid.Parse("20000000-0000-0000-0000-000000000008");
            var entJiraEng = Guid.Parse("20000000-0000-0000-0000-000000000009");
            var entTeamsCorp = Guid.Parse("20000000-0000-0000-0000-000000000010");

            // ---------- Devices (10) ----------
            var device1 = Guid.Parse("00000000-0000-0000-0000-000000000001");
            var device2 = Guid.Parse("00000000-0000-0000-0000-000000000002");
            var device3 = Guid.Parse("00000000-0000-0000-0000-000000000003");
            var device4 = Guid.Parse("00000000-0000-0000-0000-000000000004");
            var device5 = Guid.Parse("00000000-0000-0000-0000-000000000005");
            var device6 = Guid.Parse("00000000-0000-0000-0000-000000000006");
            var device7 = Guid.Parse("00000000-0000-0000-0000-000000000007");
            var device8 = Guid.Parse("00000000-0000-0000-0000-000000000008");
            var device9 = Guid.Parse("00000000-0000-0000-0000-000000000009");
            var device10 = Guid.Parse("00000000-0000-0000-0000-000000000010");

            modelBuilder.Entity<Device>().HasData(
                new Device { DeviceId = device1, Hostname = "DESKTOP-IT-01", DepartmentId = deptIt, OwnerUserId = userAliceIt, DeviceType = "Desktop", LastSeen = baseDate.AddMinutes(10), Status = "Active" },
                new Device { DeviceId = device2, Hostname = "LAPTOP-FIN-01", DepartmentId = deptFinance, OwnerUserId = userBobFin, DeviceType = "Laptop", LastSeen = baseDate.AddMinutes(20), Status = "Active" },
                new Device { DeviceId = device3, Hostname = "LAPTOP-FIN-02", DepartmentId = deptFinance, OwnerUserId = userGraceFin, DeviceType = "Laptop", LastSeen = baseDate.AddMinutes(-30), Status = "Active" },
                new Device { DeviceId = device4, Hostname = "LAPTOP-HR-01", DepartmentId = deptHr, OwnerUserId = userCarolHr, DeviceType = "Laptop", LastSeen = baseDate.AddHours(-1), Status = "Active" },
                new Device { DeviceId = device5, Hostname = "SERVER-APP-01", DepartmentId = deptEng, OwnerUserId = userDaveEng, DeviceType = "Server", LastSeen = baseDate.AddHours(-2), Status = "Active" },
                new Device { DeviceId = device6, Hostname = "SERVER-DB-01", DepartmentId = deptEng, OwnerUserId = userDaveEng, DeviceType = "Server", LastSeen = baseDate.AddHours(-12), Status = "Active" },
                new Device { DeviceId = device7, Hostname = "LAPTOP-ENG-01", DepartmentId = deptEng, OwnerUserId = userEveEng, DeviceType = "Laptop", LastSeen = baseDate.AddMinutes(5), Status = "Active" },
                new Device { DeviceId = device8, Hostname = "LAPTOP-ENG-02", DepartmentId = deptEng, OwnerUserId = userDaveEng, DeviceType = "Laptop", LastSeen = baseDate.AddMinutes(-5), Status = "Inactive" },
                new Device { DeviceId = device9, Hostname = "VDI-IT-01", DepartmentId = deptIt, OwnerUserId = userHeidiIt, DeviceType = "VDI", LastSeen = baseDate.AddDays(-1), Status = "Active" },
                new Device { DeviceId = device10, Hostname = "LAPTOP-SALES-01", DepartmentId = deptSales, OwnerUserId = userFrankSales, DeviceType = "Laptop", LastSeen = baseDate.AddMinutes(45), Status = "Active" }
            );

            // ---------- Installations (10) ----------
            modelBuilder.Entity<Installation>().HasData(
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000001"), DeviceId = device1, ProductId = productOffice365, EntitlementId = entOfficeIt, Version = "Microsoft 365 Apps", InstallDate = baseDate.AddDays(-90), LastSeen = baseDate.AddMinutes(10), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000002"), DeviceId = device2, ProductId = productOffice365, EntitlementId = entOfficeFinance, Version = "Microsoft 365 Apps", InstallDate = baseDate.AddDays(-70), LastSeen = baseDate.AddMinutes(20), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000003"), DeviceId = device3, ProductId = productPowerBi, EntitlementId = entPowerBiFin, Version = "Power BI Desktop", InstallDate = baseDate.AddDays(-60), LastSeen = baseDate.AddMinutes(-30), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000004"), DeviceId = device4, ProductId = productOffice365, EntitlementId = entOfficeIt, Version = "Microsoft 365 Apps", InstallDate = baseDate.AddDays(-120), LastSeen = baseDate.AddHours(-1), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000005"), DeviceId = device5, ProductId = productJira, EntitlementId = entJiraEng, Version = "Jira Server 9.0", InstallDate = baseDate.AddDays(-180), LastSeen = baseDate.AddHours(-2), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000006"), DeviceId = device6, ProductId = productSqlServer, EntitlementId = entSqlServerDb, Version = "SQL Server 2019", InstallDate = baseDate.AddDays(-200), LastSeen = baseDate.AddHours(-12), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000007"), DeviceId = device7, ProductId = productVsPro, EntitlementId = entVsProEng, Version = "VS 2022 Enterprise", InstallDate = baseDate.AddDays(-30), LastSeen = baseDate.AddMinutes(5), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000008"), DeviceId = device8, ProductId = productPhotoshop, EntitlementId = entPhotoshopEng, Version = "Photoshop 2024", InstallDate = baseDate.AddDays(-15), LastSeen = baseDate.AddMinutes(-5), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000009"), DeviceId = device9, ProductId = productSlack, EntitlementId = entSlackCorp, Version = "Slack Desktop", InstallDate = baseDate.AddDays(-45), LastSeen = baseDate.AddDays(-1), Discovered = true },
                new Installation { InstallationId = Guid.Parse("50000000-0000-0000-0000-000000000010"), DeviceId = device10, ProductId = productZoom, EntitlementId = entZoomCorp, Version = "Zoom Client 5.x", InstallDate = baseDate.AddDays(-20), LastSeen = baseDate.AddMinutes(45), Discovered = true }
            );

            // ---------- UserAssignments (10) ----------
            modelBuilder.Entity<UserAssignment>().HasData(
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000001"), UserId = userAliceIt, ProductId = productOffice365, EntitlementId = entOfficeIt, Status = "Active", AssignedAt = baseDate.AddDays(-120), LastUsedAt = baseDate.AddDays(-1), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000002"), UserId = userBobFin, ProductId = productOffice365, EntitlementId = entOfficeFinance, Status = "Active", AssignedAt = baseDate.AddDays(-100), LastUsedAt = baseDate.AddDays(-2), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000003"), UserId = userGraceFin, ProductId = productPowerBi, EntitlementId = entPowerBiFin, Status = "Active", AssignedAt = baseDate.AddDays(-80), LastUsedAt = baseDate.AddDays(-10), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000004"), UserId = userCarolHr, ProductId = productOffice365, EntitlementId = entOfficeIt, Status = "Active", AssignedAt = baseDate.AddDays(-90), LastUsedAt = baseDate.AddDays(-15), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000005"), UserId = userDaveEng, ProductId = productSqlServer, EntitlementId = entSqlServerDb, Status = "Active", AssignedAt = baseDate.AddDays(-200), LastUsedAt = baseDate.AddDays(-30), RevokedAt = null, ExemptFlag = true }, // exempt (DBA)
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000006"), UserId = userEveEng, ProductId = productVsPro, EntitlementId = entVsProEng, Status = "Active", AssignedAt = baseDate.AddDays(-60), LastUsedAt = baseDate.AddDays(-1), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000007"), UserId = userFrankSales, ProductId = productZoom, EntitlementId = entZoomCorp, Status = "Active", AssignedAt = baseDate.AddDays(-40), LastUsedAt = baseDate.AddDays(-1), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000008"), UserId = userIvanSales, ProductId = productTeams, EntitlementId = entTeamsCorp, Status = "Active", AssignedAt = baseDate.AddDays(-30), LastUsedAt = baseDate.AddDays(-3), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000009"), UserId = userHeidiIt, ProductId = productSlack, EntitlementId = entSlackCorp, Status = "Active", AssignedAt = baseDate.AddDays(-70), LastUsedAt = baseDate.AddDays(-7), RevokedAt = null, ExemptFlag = false },
                new UserAssignment { AssignmentId = Guid.Parse("60000000-0000-0000-0000-000000000010"), UserId = userJudyHr, ProductId = productOffice365, EntitlementId = entOfficeIt, Status = "Revoked", AssignedAt = baseDate.AddDays(-180), LastUsedAt = baseDate.AddDays(-90), RevokedAt = baseDate.AddDays(-30), ExemptFlag = false }
            );

            // ---------- UsageEvents (10) ----------
            modelBuilder.Entity<UsageEvent>().HasData(
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000001"), UserId = userAliceIt, DeviceId = device1, ProductId = productOffice365, EventType = "session_start", Timestamp = baseDate.AddHours(-2), SessionId = Guid.Parse("71000000-0000-0000-0000-000000000001"), DurationSeconds = 5400 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000002"), UserId = userBobFin, DeviceId = device2, ProductId = productOffice365, EventType = "session_start", Timestamp = baseDate.AddHours(-3), SessionId = Guid.Parse("71000000-0000-0000-0000-000000000002"), DurationSeconds = 3600 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000003"), UserId = userGraceFin, DeviceId = device3, ProductId = productPowerBi, EventType = "report_refresh", Timestamp = baseDate.AddHours(-4), SessionId = null, DurationSeconds = 900 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000004"), UserId = userCarolHr, DeviceId = device4, ProductId = productOffice365, EventType = "session_start", Timestamp = baseDate.AddHours(-5), SessionId = Guid.Parse("71000000-0000-0000-0000-000000000004"), DurationSeconds = 2700 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000005"), UserId = userDaveEng, DeviceId = device6, ProductId = productSqlServer, EventType = "db_maintenance", Timestamp = baseDate.AddDays(-1), SessionId = null, DurationSeconds = 7200 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000006"), UserId = userEveEng, DeviceId = device7, ProductId = productVsPro, EventType = "build_solution", Timestamp = baseDate.AddMinutes(-90), SessionId = null, DurationSeconds = 1200 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000007"), UserId = userFrankSales, DeviceId = device10, ProductId = productZoom, EventType = "meeting_join", Timestamp = baseDate.AddMinutes(-60), SessionId = Guid.Parse("71000000-0000-0000-0000-000000000007"), DurationSeconds = 3600 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000008"), UserId = userIvanSales, DeviceId = device10, ProductId = productTeams, EventType = "chat_activity", Timestamp = baseDate.AddMinutes(-30), SessionId = null, DurationSeconds = 1800 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000009"), UserId = userHeidiIt, DeviceId = device9, ProductId = productSlack, EventType = "message_post", Timestamp = baseDate.AddDays(-2), SessionId = null, DurationSeconds = 300 },
                new UsageEvent { UsageEventId = Guid.Parse("70000000-0000-0000-0000-000000000010"), UserId = userJudyHr, DeviceId = device4, ProductId = productOffice365, EventType = "session_start", Timestamp = baseDate.AddDays(-10), SessionId = Guid.Parse("71000000-0000-0000-0000-000000000010"), DurationSeconds = 1800 }
            );

            // ---------- ComplianceAuditSnapshots (10) ----------
            modelBuilder.Entity<ComplianceAuditSnapshot>().HasData(
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000001"), ProductId = productOffice365, SnapshotTime = baseDate.AddDays(-90), AssignedCount = 50, UsedCount = 45, EntitlementsPurchased = 55, Status = "Compliant" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000002"), ProductId = productOffice365, SnapshotTime = baseDate.AddDays(-60), AssignedCount = 60, UsedCount = 40, EntitlementsPurchased = 55, Status = "OverLicensed" },  // too many seats vs use
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000003"), ProductId = productPowerBi, SnapshotTime = baseDate.AddDays(-30), AssignedCount = 20, UsedCount = 18, EntitlementsPurchased = 20, Status = "Compliant" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000004"), ProductId = productPowerBi, SnapshotTime = baseDate.AddDays(-7), AssignedCount = 25, UsedCount = 5, EntitlementsPurchased = 20, Status = "OverLicensed" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000005"), ProductId = productSqlServer, SnapshotTime = baseDate.AddDays(-120), AssignedCount = 5, UsedCount = 5, EntitlementsPurchased = 5, Status = "Compliant" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000006"), ProductId = productSqlServer, SnapshotTime = baseDate.AddDays(-30), AssignedCount = 7, UsedCount = 7, EntitlementsPurchased = 5, Status = "UnderLicensed" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000007"), ProductId = productZoom, SnapshotTime = baseDate.AddDays(-14), AssignedCount = 30, UsedCount = 29, EntitlementsPurchased = 30, Status = "Compliant" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000008"), ProductId = productTeams, SnapshotTime = baseDate.AddDays(-14), AssignedCount = 35, UsedCount = 32, EntitlementsPurchased = 35, Status = "Compliant" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000009"), ProductId = productSlack, SnapshotTime = baseDate.AddDays(-60), AssignedCount = 15, UsedCount = 3, EntitlementsPurchased = 20, Status = "OverLicensed" },
                new ComplianceAuditSnapshot { AuditId = Guid.Parse("80000000-0000-0000-0000-000000000010"), ProductId = productJira, SnapshotTime = baseDate.AddDays(-45), AssignedCount = 10, UsedCount = 9, EntitlementsPurchased = 10, Status = "Compliant" }
            );
        }

    }
}
