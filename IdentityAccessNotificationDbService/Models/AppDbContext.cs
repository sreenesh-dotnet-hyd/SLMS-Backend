using Microsoft.EntityFrameworkCore;

namespace IdentityAccessNotificationDbService.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AuditLog> AuditLogs { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }

        public DbSet<Notifications> Notifications { get; set; }


       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // ================= WORKFLOW RELATIONS =================
    modelBuilder.Entity<WorkFlow>()
        .HasOne(w => w.RequestedByUser)
        .WithMany()
        .HasForeignKey(w => w.RequestedBy)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<WorkFlow>()
        .HasOne(w => w.ApprovedByUser)
        .WithMany()
        .HasForeignKey(w => w.ApprovedBy)
        .OnDelete(DeleteBehavior.Restrict);


    // ================= USERS =================
    var users = new[]
    {
        new User { Id = 1, Email = "john.admin@company.com", DepartmentId = "IT" },
        new User { Id = 2, Email = "sanjay.it@company.com", DepartmentId = "IT" },

        new User { Id = 3, Email = "priya.finance@company.com", DepartmentId = "Finance" },
        new User { Id = 4, Email = "rohan.finance@company.com", DepartmentId = "Finance" },

        new User { Id = 5, Email = "meera.audit@company.com", DepartmentId = "Audit" },
        new User { Id = 6, Email = "dev.audit@company.com", DepartmentId = "Audit" },

        new User { Id = 7, Email = "arun.viewer@company.com", DepartmentId = "HR" },
        new User { Id = 8, Email = "tina.viewer@company.com", DepartmentId = "Marketing" },

        new User { Id = 9, Email = "raj.employee@company.com", DepartmentId = "Engineering" },
        new User { Id = 10, Email = "nisha.employee@company.com", DepartmentId = "Engineering" }
    };
    modelBuilder.Entity<User>().HasData(users);


    // ================= ROLES =================
    var roles = new[]
    {
        new Role { Id = 1, Name = "Viewer", Description = "Read-only access" },
        new Role { Id = 2, Name = "IT Admin", Description = "Manage licenses and workflows" },
        new Role { Id = 3, Name = "Finance Team", Description = "Finance and cost allocation access" },
        new Role { Id = 4, Name = "Auditor", Description = "View audit logs & compliance reports" }
    };
    modelBuilder.Entity<Role>().HasData(roles);


    // ================= PERMISSIONS =================
    var permissions = new[]
    {
        new Permission { Id = 1, Code = "VIEW_SOFTWARE", Description = "View software catalog" },
        new Permission { Id = 2, Code = "MANAGE_LICENSES", Description = "Assign or revoke licenses" },
        new Permission { Id = 3, Code = "VIEW_FINANCE", Description = "View finance reports & allocation" },
        new Permission { Id = 4, Code = "VIEW_AUDIT", Description = "View audit logs" }
    };
    modelBuilder.Entity<Permission>().HasData(permissions);


    // ================= ROLE PERMISSIONS =================
    var rolePermissions = new[]
    {
        // Viewer
        new RolePermission { RoleId = 1, PermissionId = 1 },

        // IT Admin
        new RolePermission { RoleId = 2, PermissionId = 1 },
        new RolePermission { RoleId = 2, PermissionId = 2 },

        // Finance Team
        new RolePermission { RoleId = 3, PermissionId = 1 },
        new RolePermission { RoleId = 3, PermissionId = 3 },

        // Auditor
        new RolePermission { RoleId = 4, PermissionId = 1 },
        new RolePermission { RoleId = 4, PermissionId = 4 }
    };
    modelBuilder.Entity<RolePermission>()
        .HasKey(rp => new { rp.RoleId, rp.PermissionId });
    modelBuilder.Entity<RolePermission>().HasData(rolePermissions);


    // ================= USER ROLES =================
    var userRoles = new[]
    {
        new UserRole { Id = 1, user_id = 1, role_id = 2 }, // John - IT Admin
        new UserRole { Id = 2, user_id = 2, role_id = 2 }, // Sanjay - IT Admin

        new UserRole { Id = 3, user_id = 3, role_id = 3 }, // Priya - Finance
        new UserRole { Id = 4, user_id = 4, role_id = 3 }, // Rohan - Finance

        new UserRole { Id = 5, user_id = 5, role_id = 4 }, // Meera - Auditor
        new UserRole { Id = 6, user_id = 6, role_id = 4 }, // Dev - Auditor

        new UserRole { Id = 7, user_id = 7, role_id = 1 }, // Arun - Viewer
        new UserRole { Id = 8, user_id = 8, role_id = 1 }, // Tina - Viewer

        new UserRole { Id = 9, user_id = 9, role_id = 1 }, // Raj - Viewer
        new UserRole { Id = 10, user_id = 10, role_id = 1 } // Nisha - Viewer
    };
    modelBuilder.Entity<UserRole>().HasData(userRoles);


    // ================= NOTIFICATIONS =================
    var notifications = Enumerable.Range(1, 10).Select(i => new Notifications
    {
        id = i,
        user_id = ((i - 1) % 10) + 1,
        type = "WorkflowUpdate",
        Channel = (NotificationChannel)((i - 1) % 4)
    }).ToArray();

    modelBuilder.Entity<Notifications>().HasData(notifications);


    // ================= STATIC DATES =================
    var baseDate = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);


    // ================= AUDIT LOGS =================
    var audits = Enumerable.Range(1, 10).Select(i => new AuditLog
    {
        Id = i,
        ActorId = ((i - 1) % 10) + 1,
        Action = $"Updated workflow #{i}",
        EntityType = "Workflow",
        EntityId = i.ToString(),
        OldValues = "{\"status\":\"Pending\"}",
        NewValues = "{\"status\":\"Approved\"}",
        CreatedAt = baseDate.AddDays(i),
        IpAddress = "192.168.1.10",
        UserAgent = "Mozilla/5.0"
    }).ToArray();

    modelBuilder.Entity<AuditLog>().HasData(audits);


    // ================= WORKFLOWS =================
    var workflows = new[]
    {
        new WorkFlow
        {
            Id = 1,
            Type = WorkflowType.AssignLicense,
            Status = WorkflowStatus.Pending,
            RequestedBy = 9, // Raj
            ApprovedBy = 1, // John (IT Admin)
            EntityType = "License",
            EntityId = "101",
            Payload = "{\"license\":\"Figma\"}",
            CreatedAt = baseDate,
            UpdatedAt = baseDate.AddHours(2)
        },
        new WorkFlow
        {
            Id = 2,
            Type = WorkflowType.ReclaimLicense,
            Status = WorkflowStatus.Approved,
            RequestedBy = 10,
            ApprovedBy = 2,
            EntityType = "License",
            EntityId = "102",
            Payload = "{\"license\":\"Slack\"}",
            CreatedAt = baseDate.AddDays(1),
            UpdatedAt = baseDate.AddDays(1).AddHours(3)
        }
    };

    modelBuilder.Entity<WorkFlow>().HasData(workflows);
}



    }
}
